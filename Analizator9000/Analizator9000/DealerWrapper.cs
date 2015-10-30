using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Analizator9000
{
    /// <summary>
    /// Runs dealer generator and captures its output.
    /// </summary>
    class DealerWrapper
    {
        /// <summary>
        /// Calling user interfaces instance.
        /// </summary>
        private Form1 debugForm;
        /// <summary>
        /// Name of the input script file.
        /// </summary>
        private String scriptname;
        /// <summary>
        /// Stream to the generation results output file.
        /// </summary>
        private StreamWriter outputFile;
        /// <summary>
        /// Flag ensuring only one instance of dealer is running.
        /// </summary>
        private bool running = false;
        /// <summary>
        /// Number of lines (deals) to produce.
        /// </summary>
        private long produce = 0;
        /// <summary>
        /// Number of lines (deals) already produced.
        /// </summary>
        private long lineCount = 0;

        /// <summary>
        /// Dealer wrapper class constructor.
        /// </summary>
        /// <param name="scriptname">Input script file name.</param>
        /// <param name="debugForm">Calling interface form.</param>
        /// <param name="produce">Number of deals to produce.</param>
        public DealerWrapper(String scriptname, Form1 debugForm, long produce)
        {
            if (!File.Exists(scriptname))
            {
                throw new Exception(Form1.GetResourceManager().GetString("DealerWrapper_errorFileNotFound", Form1.GetCulture()) + ": " + scriptname);
            }
            if (produce < 1)
            {
                throw new Exception(Form1.GetResourceManager().GetString("DealerWrapper_errorInvalidDealCount", Form1.GetCulture()));
            }
            this.scriptname = scriptname;
            this.debugForm = debugForm;
            this.produce = produce;
        }

        /// <summary>
        /// Sends a single line to debug field of the calling form.
        /// </summary>
        /// <param name="line">Message to be appended to the debug output.</param>
        private void debugWriteLine(String line) {
            this.debugForm.addStatusLine(line);
        }

        /// <summary>
        /// Processes a chunk of dealer output.
        /// </summary>
        /// <param name="data">Output string of dealer instance.</param>
        /// <returns>TRUE if dealer it still running, FALSE if null string arrived -> process ended.</returns>
        private bool handleData(string data)
        {
            if (data != null)
            {
                String[] dataLines = data.Split('\n');
                foreach (String line in dataLines)
                {
                    Match lineMatch = Regex.Match(line.Trim(), @"^n\s*(\S*)\s*e\s*(\S*)\s*s\s*(\S*)\s*w\s*(\S*)$");
                    if (lineMatch.Success)
                    {
                        this.lineCount++;
                        this.outputFile.Write(this.lineCount);
                        this.outputFile.WriteLine(lineMatch.Result(": ${1} ${2} ${3} ${4}"));
                    }
                }
                int progress = ((int)(100 * this.lineCount / this.produce));
                this.debugForm.setProgress(progress);
                this.debugWriteLine(data);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Closes the output file stream.
        /// </summary>
        public void closeFile()
        {
            this.outputFile.Close();
        }

        /// <summary>
        /// Delegate for process end callback invocation.
        /// </summary>
        /// <param name="filename">Output file name.</param>
        private delegate void onEndDelegate(String filename);
        /// <summary>
        /// Worker method for dealer generating.
        /// </summary>
        /// <param name="onEnd">Callback to the function which takes output file name as a parameter.</param>
        public void run(Action<String> onEnd)
        {
            if (!this.running)
            {
                this.running = true;
                this.lineCount = 0;
                String filename = Utils.getFilename("deals");
                this.outputFile = new StreamWriter(@"files\"+filename);
                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = @"bin\dealer.exe";
                pInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pInfo.CreateNoWindow = true;
                pInfo.Arguments = "\"" + this.scriptname + "\"";
                pInfo.UseShellExecute = false;
                pInfo.RedirectStandardOutput = true;
                pInfo.RedirectStandardError = true;
                pInfo.StandardOutputEncoding = pInfo.StandardErrorEncoding = Encoding.UTF8;
                this.debugWriteLine(pInfo.FileName + " " + pInfo.Arguments);
                Process dealerProc = new Process();
                dealerProc.StartInfo = pInfo;
                dealerProc.OutputDataReceived += (sender, output) =>
                {
                    if (output != null)
                    {
                        if (!this.handleData(output.Data))
                        {
                            this.closeFile();
                            (new onEndDelegate(onEnd)).Invoke(filename);
                        }
                    }
                };
                dealerProc.ErrorDataReceived += (sender, error) => { if (error != null) { this.debugWriteLine(error.Data); } };
                dealerProc.Start();
                dealerProc.BeginErrorReadLine();
                dealerProc.BeginOutputReadLine();
            }
        }

    }
}
