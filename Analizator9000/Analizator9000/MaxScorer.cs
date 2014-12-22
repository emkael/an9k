namespace Analizator9000
{
    /// <summary>
    /// Matchpoint scoring method
    /// </summary>
    class MaxScorer : BaseScorer
    {
        /// <summary>
        /// Scoring method for matchpoints
        /// </summary>
        /// <param name="score1">Score to calculate the outcome</param>
        /// <param name="score2">Score to compare to</param>
        /// <returns>2 matchpoints for a better score, no matchpoints for worse, 1 if scores are the same</returns>
        override protected double getResultFromScores(long score1, long score2)
        {
            return score1 > score2 ? 2.0 : (score1 < score2 ? 0.0 : 1.0);
        }

        /// <summary>
        /// Averaging method for matchpoints
        /// </summary>
        /// <param name="scoreCount">Number of scores in the traveller</param>
        /// <returns>Maximum matchpoint score (2 * (n - 1))</returns>
        protected override double getDivisorFromScoreCount(int scoreCount)
        {
            return 2.0 * (scoreCount - 1);
        }
    }
}
