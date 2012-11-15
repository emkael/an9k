using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Analizator9000
{
    class DealerWrapper
    {
        private Form1 debugForm;
        private String scriptname;
        private StreamWriter outputFile;
        private bool running = false;
        private long produce = 0;
        private long lineCount = 0;

        public DealerWrapper(String scriptname, Form1 debugForm, long produce)
        {
            if (!File.Exists(scriptname))
            {
                throw new Exception("Nie znaleziono pliku: " + scriptname);
            }
            if (produce < 1)
            {
                throw new Exception("Nieprawidłowa liczba rozdań do wyprodukowania");
            }
            this.scriptname = scriptname;
            this.debugForm = debugForm;
            this.produce = produce;
        }

        private void debugWriteLine(String line) {
            this.debugForm.addStatusLine(line);
        }

        private bool handleData(string data)
        {
            if (data != null)
            {
                String[] dataLines = data.Split('\n');
                foreach (String line in dataLines)
                {
                    Match lineMatch = Regex.Match(line.Trim(), "^n\\s*(\\S*)\\s*e\\s*(\\S*)\\s*s\\s*(\\S*)\\s*w\\s*(\\S*)$");
                    if (lineMatch.Success)
                    {
                        this.outputFile.WriteLine(lineMatch.Result("${1} ${2} ${3} ${4}"));
                        this.lineCount++;
                    }
                }
                int progress = ((int)(100 * this.lineCount / this.produce));
                this.debugForm.setProgress(progress);
                this.debugWriteLine(data);
                return true;
            }
            return false;
        }

        public void closeFile()
        {
            this.outputFile.Close();
        }

        private delegate void onEndDelegate(String filename);
        public void run(Action<String> onEnd)
        {
            if (!this.running)
            {
                this.running = true;
                this.lineCount = 0;
                String filename = "an9k-" + DateTime.Now.ToString("yyyyMMddHHmmssFFF") + ".deals";
                this.outputFile = new StreamWriter("files\\"+filename);
                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = "bin\\dealer.exe";
                pInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pInfo.CreateNoWindow = true;
                pInfo.Arguments = "\"" + this.scriptname + "\"";
                pInfo.UseShellExecute = false;
                pInfo.RedirectStandardOutput = true;
                pInfo.RedirectStandardError = true;
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
