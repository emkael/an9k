using System.Collections.Generic;

namespace Analizator9000
{
    /// <summary>
    /// Base scoring utility, for scoring methods which produce the board scores comparing all scores with each other and averaging over the results (e.g. matchpoints, Cavendish IMP).
    /// </summary>
    abstract class BaseScorer : IScorer
    {
        public Dictionary<Contract, double> scoreBoard(Dictionary<Contract, long> scores)
        {
            Dictionary<Contract, double> result = new Dictionary<Contract, double>();
            int scoreCount = 0;
            foreach (KeyValuePair<Contract, long> score in scores)
            {
                if (score.Key.Frequency > 0)
                {
                    // Accumulating number of scores in a board
                    scoreCount += score.Key.Frequency;
                    result[score.Key] = 0;
                    foreach (KeyValuePair<Contract, long> otherScore in scores)
                    {
                        if (score.Key != otherScore.Key) // all different scores are compared with the score
                        {
                            result[score.Key] += this.getResultFromScores(score.Value, otherScore.Value) * otherScore.Key.Frequency;
                        }
                        else // and all but one (the score we're calculating) from the same scores
                        {
                            result[score.Key] += this.getResultFromScores(score.Value, otherScore.Value) * (score.Key.Frequency - 1);
                        }
                    }
                }
            }
            // Averaging every score by dividing by a certain factor
            double divisor = this.getDivisorFromScoreCount(scoreCount);
            if (divisor > 0)
            {
                foreach (KeyValuePair<Contract, long> score in scores)
                {

                    result[score.Key] /= divisor;
                }
            }
            return result;
        }

        /// <summary>
        /// Scoring method for comparing two scores
        /// </summary>
        /// <param name="score1">Score to calculate the outcome</param>
        /// <param name="score2">Score to compare to</param>
        /// <returns>Score between two scores in the method used</returns>
        protected abstract double getResultFromScores(long score1, long score2);

        /// <summary>
        /// Produces averaging factor for specified number of scores on a board
        /// </summary>
        /// <param name="scoreCount">Number of scores in the traveller</param>
        /// <returns>Factor for score average division</returns>
        virtual protected double getDivisorFromScoreCount(int scoreCount)
        {
            return scoreCount;
        }
    }
}
