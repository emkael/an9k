using System.Collections.Generic;

namespace Analizator9000
{
    /// <summary>
    /// Interface for board scoring utilities
    /// </summary>
    interface IScorer
    {
        /// <summary>
        /// Main method, takes dictionary of contract scores and calculates board scores for each contract
        /// </summary>
        /// <param name="scores">Dictionary of scored contracts</param>
        /// <returns>Dictionary containing board scores for each contract</returns>
        Dictionary<Contract, double> scoreBoard(Dictionary<Contract, long> scores);
    }
}
