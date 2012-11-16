using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Analizator9000
{
    class Accumulator
    {
        private Dictionary<int, Dictionary<int, long[]>> sums;
        private long analyzed = 0;
        private long toAnalyze = 0;
        private Stack<String> deals;
        private Form1 form;
        private Dictionary<int, List<int>> contracts;
        private TextWriter outputFile;
        private String filename;

        public Accumulator(String[] deals, List<Contract> contracts, Form1 form)
        {
            this.deals = new Stack<String>(deals);
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

        private int portionSize = 10;
        private int threadsRunning = 0;
        public int run(int portionSize = 0)
        {
            if (portionSize == 0)
            {
                portionSize = this.portionSize;
            }
            int toRun = Math.Min(portionSize, this.deals.Count);
            for (int i = 0; i < toRun; i++)
            {
                Action<String> worker = this.analyzeDeal;
                worker.BeginInvoke(this.deals.Pop(), this.endAnalyze, worker);
                this.threadsRunning++;
            }
            return this.deals.Count;
        }

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
                                this.update(result);
                                this.form.setResult(this.getString());
                                this.form.addStatusLine(line);
                                this.outputFile.WriteLine(line);
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

        private bool abort = false;
        public void abortAnalysis()
        {
            this.abort = true;
        }

        private void endAnalyze(IAsyncResult methodResult)
        {
            ((Action<String>)methodResult.AsyncState).EndInvoke(methodResult);
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
                    this.run(1);
                }
            }
            if (finished)
            {
                try
                {
                    this.outputFile.WriteLine(this.getString());
                    this.outputFile.Close();
                }
                catch (Exception) { };
                this.form.endAnalysis();
            }
        }

        private String getString()
        {
            StringWriter sw = new StringWriter();
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

        private void update(BCalcResult result)
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
