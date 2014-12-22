using System;
namespace Analizator9000
{
    /// <summary>
    /// International Match Point scoring method
    /// </summary>
    class ImpScorer : BaseScorer
    {
        /// <summary>
        /// Scoring method for IMPs
        /// </summary>
        /// <param name="score1">Score to calculate the outcome</param>
        /// <param name="score2">Score to compare to</param>
        /// <returns></returns>
        protected override double getResultFromScores(long score1, long score2)
        {
            double result = 0.0;
            long difference = Math.Abs(score1 - score2); // given the absolute difference between scores...
            int[] thresholds = { 20, 50, 90, 130, 170, 220, 270, 320, 370, 430, 500, 600, 750, 900, 1100, 1300, 1500, 1750, 2000, 2250, 2500, 3000, 3500, 4000 };
            foreach (int t in thresholds) // ... add 1 IMP for every threshold that the difference is over
            {
                if (difference >= t)
                {
                    result++;
                }
            }
            if (score1 < score2) // if the score is worse, reverse the score
            {
                result = -result;
            }
            return result;
        }

        /// <summary>
        /// Averging method for IMPs
        /// </summary>
        /// <param name="scoreCount">Number of scores in the traveller</param>
        /// <returns>Number of comparisons between scores for every score (n - 1)</returns>
        protected override double getDivisorFromScoreCount(int scoreCount)
        {
            return scoreCount - 1;
        }
    }
}
