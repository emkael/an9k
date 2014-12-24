using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Analizator9000
{
    /// <summary>
    /// Analysis accumulator for scoreing contracts
    /// </summary>
    class ScoreAccumulator : Accumulator
    {
        private readonly string[] vulnerabilities = { "obie przed", "obie po", "NS po", "EW po" };
        /// <summary>
        /// Vulnerability setting of the analysis
        /// </summary>
        private int vulnerability;
        /// <summary>
        /// List of contracts coming from GUI table
        /// </summary>
        private List<Contract> contractsToScore;
        /// <summary>
        /// Scores for the contracts
        /// </summary>
        private Dictionary<long, Dictionary<Contract, long>> scores;
        /// <summary>
        /// Counter of deals already fully scored
        /// </summary>
        private long dealsScored = 0;
        /// <summary>
        /// Number of tricks accumulator
        /// </summary>
        private Dictionary<Contract, long> trickSums;
        /// <summary>
        /// Sum of scores accumulator
        /// </summary>
        private Dictionary<Contract, long> scoreSums;
        /// <summary>
        /// Matchpoint score accumulator
        /// </summary>
        private Dictionary<Contract, double> maxScoreSums;
        /// <summary>
        /// IMP score accumulator
        /// </summary>
        private Dictionary<Contract, double> impScoreSums;
        /// <summary>
        /// Scorer instance for matchpoints
        /// </summary>
        private IScorer maxScorer;
        /// <summary>
        /// Scorer instance for IMPs
        /// </summary>
        private IScorer impScorer;
        /// <summary>
        /// Constructor for score accumulator
        /// </summary>
        /// <param name="deals">Base class parameter</param>
        /// <param name="contracts">Base class parameter (contracts for BCalc engine)</param>
        /// <param name="contractsToScore">List of contracts in board traveller</param>
        /// <param name="vulnerability">Vulnerability setting for analysis</param>
        /// <param name="form">Base class parameter</param>
        public ScoreAccumulator(String[] deals, List<Contract> contracts, List<Contract> contractsToScore, int vulnerability, Form1 form) : base(deals, contracts, form) {
            this.contractsToScore = contractsToScore;
            this.vulnerability = vulnerability;
            this.scores = new Dictionary<long, Dictionary<Contract, long>>();
            this.trickSums = new Dictionary<Contract,long>();
            this.scoreSums = new Dictionary<Contract,long>();
            this.maxScoreSums = new Dictionary<Contract,double>();
            this.maxScorer = new MaxScorer();
            this.impScoreSums = new Dictionary<Contract,double>();
            this.impScorer = new ImpScorer();
            foreach (Contract sC in this.contractsToScore)
            {
                if (sC.Frequency > 0)
                {
                    this.trickSums[sC] = 0;
                    this.scoreSums[sC] = 0;
                    this.maxScoreSums[sC] = 0;
                    this.impScoreSums[sC] = 0;
                }
            }
        }

        /// <summary>
        /// Returns user-readable summary of analysis
        /// </summary>
        /// <param name="full">Append matchpoint/IMP scores summary</param>
        /// <returns>Formatted log string</returns>
        protected override String getString(bool full = false)
        {
            String output = base.getString(full);
            if (full)
            {
                StringWriter sw = new StringWriter();
                sw.WriteLine();
                sw.WriteLine("Założenia: {0}", this.vulnerabilities[this.vulnerability]);
                sw.WriteLine(" KONTRAKT      LEWY    ZAPIS    MAX    IMP   ");
                foreach (KeyValuePair<Contract, long> tricks in this.trickSums)
                {
                    sw.WriteLine(" {0,6} (x{1,3}) {2,5:0.00} {3,9:0.00} {4,5:0.00} {5,7:0.00} ", this.getContractLogLine(tricks.Key), tricks.Key.Frequency,
                        tricks.Value / this.dealsScored, this.scoreSums[tricks.Key] / this.dealsScored,
                        this.maxScoreSums[tricks.Key] / this.dealsScored, this.impScoreSums[tricks.Key] / this.dealsScored);
                }
                sw.Close();
                output += sw.ToString();
            }
            return output;
        }

        /// <summary>
        /// Handling single DD analysis result
        /// </summary>
        /// <param name="result">BCalc analysis result</param>
        protected override void update(BCalcResult result) {
            base.update(result);
            lock (this.contractsToScore)
            {
                if (!this.scores.Keys.Contains(result.dealNo)) // first time we see such deal, so we should initialize some stuff
                {
                    this.scores[result.dealNo] = new Dictionary<Contract, long>();
                    foreach (Contract sC in this.contractsToScore)
                    {
                        this.scores[result.dealNo][sC] = sC.Level > 0 ? long.MinValue : 0; // All Pass contracts are already scored, other are set as "empty" (MinValue)
                    }
                }
                foreach (Contract sC in this.contractsToScore)
                {
                    // if the analysis result matches the contract, to score, score it
                    if (sC.Level > 0 && BCalcWrapper.table[sC.Declarer] == result.declarer && BCalcWrapper.denominations[sC.Denomination] == result.trumpSuit)
                    {
                        int score = sC.getScore(result, this.vulnerability);
                        string logLine = "#" + result.dealNo.ToString() + ", " + this.getContractLogLine(sC) + ": " + result.tricks.ToString() + " lew, " + score.ToString();
                        this.form.addStatusLine(logLine);
                        this.outputFile.WriteLine(logLine);
                        this.scores[result.dealNo][sC] = score;
                        this.trickSums[sC] += result.tricks;
                        this.scoreSums[sC] += score;
                    }
                }
                // check if the entire board can already be scored
                this.checkScoring(result.dealNo);
            }
        }

        /// <summary>
        /// Check whether the entire board for specific deal can be scored
        /// </summary>
        /// <param name="dealNo">Deal number</param>
        private void checkScoring(long dealNo)
        {
            // Don't score as long as there are some unscored contracts
            foreach (KeyValuePair<Contract, long> scoreTable in this.scores[dealNo])
            {
                if (scoreTable.Value == long.MinValue)
                {
                    return;
                }
            }
            this.dealsScored++;
            // IMP scores for every contract in the traveller
            Dictionary<Contract, double> impScores = this.impScorer.scoreBoard(this.scores[dealNo]);
            foreach (KeyValuePair<Contract, double> result in impScores)
            {
                this.impScoreSums[result.Key] += result.Key.Frequency > 0 ? result.Value : 0;
            }
            // Matchpoint scores for every contract in the traveller
            Dictionary<Contract, double> maxScores = this.maxScorer.scoreBoard(this.scores[dealNo]);
            foreach (KeyValuePair<Contract, double> result in maxScores)
            {
                this.maxScoreSums[result.Key] += result.Key.Frequency > 0 ? result.Value : 0;
            }
            this.logScores(impScores, dealNo, "IMP");
            this.logScores(maxScores, dealNo, "max");
            this.form.updateContractTable(this.trickSums, this.scoreSums, this.maxScoreSums, this.impScoreSums, this.dealsScored);
        }

        /// <summary>
        /// Helper method for logging entire board scores
        /// </summary>
        /// <param name="scores">Scored board</param>
        /// <param name="dealNo">Deal number</param>
        /// <param name="type">Score suffix</param>
        private void logScores(Dictionary<Contract, double> scores, long dealNo, string type)
        {
            foreach (KeyValuePair<Contract, double> score in scores) {
                string logLine = "#" + dealNo.ToString() + ", " + this.getContractLogLine(score.Key) + ": " + score.Value.ToString("0.##") + " " + type;
                this.form.addStatusLine(logLine);
                this.outputFile.WriteLine(logLine);
            }
        }

        /// <summary>
        /// Generates human-readable representation of a contract (level, denomination, modifiers, declarer)
        /// </summary>
        /// <param name="contract">Contract to transform</param>
        /// <returns>Representation of the contract, e.g. 3Hx N, PASS 1Nxx S, 7S E</returns>
        private string getContractLogLine(Contract contract)
        {
            if (contract.Level == 0)
            {
                return "PASS";
            }
            return contract.Level.ToString() + BCalcWrapper.denominations[contract.Denomination] + new String('x', contract.Modifiers) + " " + BCalcWrapper.table[contract.Declarer];
        }
    }
}
