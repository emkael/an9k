using System;
using System.Collections.Generic;
using System.IO;

namespace Analizator9000
{
    /// <summary>
    /// Provided with a set of deals and contracts to check, conducts the actual statistics by gathering the results of BCalc analysis.
    /// </summary>
    class Accumulator
    {
        /// <summary>
        /// Two-dimensional dictionary of accumulated analysis results (sample count, sample sum and sample square sum).
        /// </summary>
        private Dictionary<int, Dictionary<int, long[]>> sums;
        /// <summary>
        /// Number of deals already analyzed.
        /// </summary>
        private long analyzed = 0;
        /// <summary>
        /// Total number of deals to analyze.
        /// </summary>
        private long toAnalyze = 0;
        /// <summary>
        /// List (well, a stack) of deals to process.
        /// </summary>
        protected Stack<String> deals;
        /// <summary>
        /// A back-reference to calling Form, for progress presentation purposes.
        /// </summary>
        protected Form1 form;
        /// <summary>
        /// List of contracts to analyze in BCalc notation (integers for denomination and declarer).
        /// </summary>
        protected Dictionary<int, List<int>> contracts;
        /// <summary>
        /// Results file handle (version of StreamWriter initialized as synchronized).
        /// </summary>
        protected TextWriter outputFile;
        /// <summary>
        /// Filename for analysis output.
        /// </summary>
        private String filename;

        /// <summary>
        /// Accumulator constructor.
        /// </summary>
        /// <param name="deals">Array of deals to process, in BCalc's "NESW" format with prepended deal number for orientation.</param>
        /// <param name="contracts">List of denomination-declarer pairs (structures).</param>
        /// <param name="form">GUI instance.</param>
        public Accumulator(String[] deals, List<Contract> contracts, Form1 form)
        {
            this.deals = new Stack<String>(deals);
            if (this.deals.Count == 0)
            {
                throw new Exception("Podano pusty zbiór rozdań");
            }
            this.toAnalyze = deals.LongLength;
            this.form = form;
            this.sums = new Dictionary<int, Dictionary<int, long[]>>();
            for (int den = 0; den < BCalcWrapper.denominations.Length; den++)
            {
                this.sums.Add(den, new Dictionary<int,long[]>());
                for (int hand = 0; hand < BCalcWrapper.table.Length; hand++)
                {
                    if (contracts.Contains(new Contract(den, hand)))
                    {
                        this.sums[den].Add(hand, new long[] { 0, 0, 0 });
                    }
                    else
                    {
                        this.sums[den].Add(hand, new long[] { -1, -1, 0 });
                    }
                }
            }
            this.contracts = new Dictionary<int, List<int>>();
            foreach (Contract contract in contracts)
            {
                if (!this.contracts.ContainsKey(contract.Denomination))
                {
                    this.contracts.Add(contract.Denomination, new List<int>());
                }
                this.contracts[contract.Denomination].Add(contract.Declarer);
            }
            this.filename = Utils.getFilename("result");
            this.outputFile = TextWriter.Synchronized(File.AppendText(@"files\"+this.filename));
        }

        /// <summary>
        /// Number of threads initially run (and, subsequently, a maximum number that *should* be retained throughout analysis).
        /// </summary>
        private int portionSize = 10;
        /// <summary>
        /// Number of threads currently running.
        /// </summary>
        private int threadsRunning = 0;
        /// <summary>
        /// Initiates the analysis of a portion of deals.
        /// </summary>
        /// <param name="portionSize">Portion size. If set to 0, assumes the default/initial portion size.</param>
        /// <returns>Number of deals left to analyze.</returns>
        public int run(int portionSize = 0)
        {
            if (portionSize == 0)
            {
                portionSize = this.portionSize;
            }
            if (portionSize > this.deals.Count)
            {
                portionSize = this.deals.Count;
            }
            int toRun = Math.Min(portionSize, this.deals.Count);
            for (int i = 0; i < toRun; i++)
            {
                Action<String> worker = this.analyzeDeal;
                lock (this.deals)
                {
                    worker.BeginInvoke(this.deals.Pop(), this.endAnalyze, worker);
                }
                this.threadsRunning++;
            }
            return this.deals.Count;
        }

        /// <summary>
        /// Worker method for a single deal.
        /// </summary>
        /// <param name="deal">Deal in BCalc's "NESW" format, with deal number prepended.</param>
        private void analyzeDeal(String deal)
        {
            try
            {
                this.form.addStatusLine(deal);
                BCalcWrapper solver = new BCalcWrapper(deal);
                foreach (KeyValuePair<int, List<int>> row in this.contracts)
                {
                    try
                    {
                        solver.setTrump(row.Key);
                    }
                    catch (Exception ex)
                    {
                        this.form.addStatusLine("Błąd: " + ex.Message);
                    }
                    foreach (int entry in row.Value)
                    {
                        try
                        {
                            BCalcResult result = solver.run(entry);
                            if (!this.abort)
                            {
                                String line = "#" + result.dealNo + ", " + result.declarer + " gra w " + result.trumpSuit + ", lew: " + result.tricks;
                                this.form.addStatusLine(line);
                                this.outputFile.WriteLine(line);
                                this.update(result);
                                this.form.setResult(this.getString());
                            }
                        }
                        catch (Exception ex)
                        {
                            this.form.addStatusLine("Błąd: " + ex.Message);
                        }
                    }
                }
                solver.destroy();
            }
            catch (Exception ex)
            {
                this.outputFile.WriteLine(ex.Message);
                this.form.addStatusLine("Błąd: " + ex.Message);
            }
        }

        /// <summary>
        /// Flag stating whether the user aborted the analysis.
        /// </summary>
        private bool abort = false;
        /// <summary>
        /// Analysis abort method.
        /// </summary>
        public void abortAnalysis()
        {
            this.abort = true;
        }

        protected Object threadLock = new Object();
        /// <summary>
        /// Callback method for worker threads, ends the single deal analysis, updates the total result and fires next analysis if necessary.
        /// </summary>
        /// <param name="methodResult">Method invokation result from the worker method.</param>
        private void endAnalyze(IAsyncResult methodResult)
        {
            ((Action<String>)methodResult.AsyncState).EndInvoke(methodResult);
            lock (this.threadLock)
            {
                bool finished = false;
                if (this.abort)
                {
                    this.form.setProgress(0);
                    this.form.addStatusLine("Analiza przewana. Częściowe wyniki w pliku: " + this.filename);
                    finished = true;
                }
                else
                {

                    this.threadsRunning--;
                    this.analyzed++;
                    this.form.setProgress((int)(100 * this.analyzed / this.toAnalyze));
                    if (threadsRunning == 0 && this.deals.Count == 0)
                    {
                        this.form.setProgress(100);
                        this.form.addStatusLine("Analiza zakończona. Wyniki w pliku: " + this.filename);
                        finished = true;
                    }
                    if (threadsRunning < this.portionSize)
                    {
                        // Increasing the parameter would cause exponential thread creation rate. Funny.
                        this.run(1);
                    }
                }
                if (finished)
                {
                    try
                    {
                        this.outputFile.WriteLine(this.getString(true));
                        this.outputFile.Close();
                    }
                    catch (Exception) { };
                    this.form.endAnalysis();
                }
            }
        }
                

        /// <summary>
        /// Presents the current analysis results in textual form.
        /// </summary>
        /// <param name="full">Return full analysis for log file purpose (may be used in override methods)</param>
        /// <returns>Text table containing means and std. deviations for distinct contracts.</returns>
        protected virtual String getString(bool full = false)
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine();
            sw.WriteLine("         N              E              S              W");
            foreach (KeyValuePair<int, Dictionary<int, long[]>> row in this.sums)
            {
                sw.Write(BCalcWrapper.denominations[row.Key]+" ");
                foreach (KeyValuePair<int, long[]> entry in row.Value)
                {
                    if (entry.Value[0] >= 0)
                    {
                        double mean = (entry.Value[2] != 0) ? (double)entry.Value[0] / entry.Value[2] : 0.0;
                        double stdDev = (entry.Value[2] != 0) ? Math.Sqrt((double)entry.Value[1] / entry.Value[2] - mean * mean) : 0.0;
                        sw.Write(" {0,5:0.00} ± {1,5:0.00} ", mean, stdDev);
                    }
                    else
                    {
                        sw.Write("               ");
                    }
                }
                sw.WriteLine();
            }
            sw.Close();
            return sw.ToString();
        }

        /// <summary>
        /// Feeds the overall results with chunks of data from single contract analysis.
        /// </summary>
        /// <param name="result">Result of BCalc analysis.</param>
        protected virtual void update(BCalcResult result)
        {
            int tricks = result.tricks;
            int suit = BCalcWrapper.denominations.IndexOf(result.trumpSuit);
            int player = BCalcWrapper.table.IndexOf(result.declarer);
            this.sums[suit][player][0] += tricks;
            this.sums[suit][player][1] += tricks * tricks;
            this.sums[suit][player][2] ++;
        }
    }
}
