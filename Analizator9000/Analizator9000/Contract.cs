using System;

namespace Analizator9000
{
    /// <summary>
    /// Tuple describing contract parameters.
    /// </summary>
    public class Contract: IEquatable<Contract>
    {
        /// <summary>
        /// Denomination: non-trumps
        /// </summary>
        public const int DENOMINATION_NONTRUMP = 4;
        /// <summary>
        /// Denomination: spades
        /// </summary>
        public const int DENOMINATION_SPADES = 3;
        /// <summary>
        /// Denomination: hearts
        /// </summary>
        public const int DENOMINATION_HEARTS = 2;
        /// <summary>
        /// Denomination: diamonds
        /// </summary>
        public const int DENOMINATION_DIAMONDS = 1;
        /// <summary>
        /// Denomination: clubs
        /// </summary>
        public const int DENOMINATION_CLUBS = 0;
        /// <summary>
        /// Declarer: North
        /// </summary>
        public const int DECLARER_NORTH = 0;
        /// <summary>
        /// Declarer: East
        /// </summary>
        public const int DECLARER_EAST = 1;
        /// <summary>
        /// Declarer: South
        /// </summary>
        public const int DECLARER_SOUTH = 2;
        /// <summary>
        /// Declarer: West
        /// </summary>
        public const int DECLARER_WEST = 3;
        /// <summary>
        /// Vulnerability: none
        /// </summary>
        public const int VULNERABLE_NONE = 0;
        /// <summary>
        /// Vulnerability: all
        /// </summary>
        public const int VULNERABLE_BOTH = 1;
        /// <summary>
        /// Vulnerability: NS
        /// </summary>
        public const int VULNERABLE_NS = 2;
        /// <summary>
        /// Vulnerability: EW
        /// </summary>
        public const int VULNERABLE_EW = 3;
        /// <summary>
        /// Level of the contract.
        /// </summary>
        public int Level;
        /// <summary>
        /// Trump denomination, in numeric format.
        /// </summary>
        /// <see cref="BCalcWrapper"/>
        public int Denomination;
        /// <summary>
        /// Contract without double
        /// </summary>
        public const int MODIFIERS_NONE = 0;
        /// <summary>
        /// Contract doubled
        /// </summary>
        public const int MODIFIERS_DOUBLE = 1;
        /// <summary>
        /// Contract redoubled
        /// </summary>
        public const int MODIFIERS_REDOUBLE = 2;
        /// <summary>
        /// Modifiers - double or redouble.
        /// </summary>
        public int Modifiers;
        /// <summary>
        /// Declaring player, in numeric format.
        /// </summary>
        /// <see cref="BCalcWrapper"/>
        public int Declarer;
        /// <summary>
        /// Number of occurrences of the contract within board traveller.
        /// </summary>
        public int Frequency;
        /// <summary>
        /// Position of the contract in boards traveller table.
        /// </summary>
        public int TableRow;

        /// <summary>
        /// Constructor for contract without full information (just general trick-taking in a denomination).
        /// </summary>
        /// <param name="denom">Trump denomination.</param>
        /// <param name="decl">Declaring player.</param>
        public Contract(int denom, int decl)
        {
            this.Denomination = denom;
            this.Declarer = decl;
        }

        /// <summary>
        /// Constructor with full contract information.
        /// </summary>
        /// <param name="level">Contract level.</param>
        /// <param name="denom">Trump denomination.</param>
        /// <param name="decl">Declaring player.</param>
        /// <param name="modifiers">Modifiers: 1 = X, 2 = XX</param>
        /// <param name="frequency">Traveller frequency</param>
        /// <param name="tableRow">Traveller row index</param>
        public Contract(int level, int denom, int decl, int modifiers = 0, int frequency = 0, int tableRow = 0)
        {
            this.Frequency = frequency;
            this.Level = level;
            this.Denomination = denom;
            this.Declarer = decl;
            this.Modifiers = modifiers;
            this.TableRow = tableRow;
        }

        /// <summary>
        /// IEquatable method for comparing (checking equality) of two tuples.
        /// </summary>
        /// <param name="other">Tuple to compare to.</param>
        /// <returns>TRUE if both tuple components are equal.</returns>
        public bool Equals(Contract other)
        {
            return this.Denomination == other.Denomination && this.Declarer == other.Declarer &&
                this.Level == other.Level && this.Modifiers == other.Modifiers && this.Frequency == other.Frequency && this.TableRow == other.TableRow;
        }

        /// <summary>
        /// Method used in object comparisons, taking the Equals() method into account.
        /// <see cref="Equals"/>
        /// </summary>
        /// <returns>Object hash</returns>
        public override int GetHashCode()
        {
            int hash = this.Denomination;
            hash *= 10;
            hash += this.Declarer;
            hash *= 10;
            hash += this.Level;
            hash *= 10;
            hash += this.Modifiers;
            hash *= 10;
            hash += this.Frequency;
            hash *= 10;
            hash += this.TableRow;
            return hash;
        }

        /// <summary>
        /// Calculates score for contract result
        /// </summary>
        /// <param name="result">BCalc output result</param>
        /// <param name="vulnerability">Vulnerability for the deal</param>
        /// <returns>Score for NS pair</returns>
        public int getScore(BCalcResult result, int vulnerability)
        {
            // All PASS.
            if (this.Level == 0)
            {
                return 0;
            }
            if (BCalcWrapper.table[this.Declarer] != result.declarer)
            {
                throw new Exception("Declarer mismatch!");
            }
            // Determining vulnerability of the contract
            bool vulnerable = (vulnerability == Contract.VULNERABLE_BOTH)
                || (vulnerability == Contract.VULNERABLE_EW && this.Declarer == Contract.DECLARER_EAST)
                || (vulnerability == Contract.VULNERABLE_EW && this.Declarer == Contract.DECLARER_WEST)
                || (vulnerability == Contract.VULNERABLE_NS && this.Declarer == Contract.DECLARER_NORTH)
                || (vulnerability == Contract.VULNERABLE_NS && this.Declarer == Contract.DECLARER_SOUTH);
            int score = 0;
            // Contract not made
            if (this.Level + 6 > result.tricks)
            {
                int undertricks = this.Level + 6 - result.tricks;
                if (this.Modifiers < 1) // undoubled undertricks
                {
                    score = vulnerable ? -100 : -50;
                    score *= undertricks;
                }
                else // (re-)doubled undertricks
                {
                    do
                    {
                        if (undertricks == 1) // first undertrick: 100 non-vul, 200 vul
                        {
                            score -= vulnerable ? 200 : 100;
                        }
                        else
                        {
                            if (undertricks == 2 && !vulnerable) // second non-vul undertrick: 200
                            {
                                score -= 200;
                            }
                            else // further undertricks: 300
                            {
                                score -= 300;
                            }
                        }
                        undertricks--;
                    }
                    while (undertricks > 0);
                    score *= this.Modifiers; // redouble doubles the score
                }
            }
            else // Contract made, yay!
            {
                int parTricks = this.Level;
                do
                {
                    if (this.Denomination == Contract.DENOMINATION_NONTRUMP && parTricks == 1) // first non-trump trick: 40
                    {
                        score += 40;
                    }
                    else // other tricks
                    {
                        switch (this.Denomination)
                        {
                            case Contract.DENOMINATION_NONTRUMP:
                            case Contract.DENOMINATION_SPADES:
                            case Contract.DENOMINATION_HEARTS:
                                score += 30;
                                break;
                            case Contract.DENOMINATION_DIAMONDS:
                            case Contract.DENOMINATION_CLUBS:
                                score += 20;
                                break;
                        }
                    }
                    parTricks--;
                }
                while (parTricks > 0);
                if (this.Modifiers > 0) // (re-)doubled tricks
                {
                    score *= this.Modifiers * 2;
                }
                score += (score >= 100) ? (vulnerable ? 500 : 300) : 50; // game premium
                if (this.Level == 7) // grand slam premium
                {
                    score += vulnerable ? 1500 : 1000;
                }
                else if (this.Level == 6) // small slam premium
                {
                    score += vulnerable ? 750 : 500;
                }
                score += this.Modifiers * 50; // failed (re-)double premium
                int overtricks = result.tricks - this.Level - 6;
                score += this.Modifiers > 0
                    ? (vulnerable ? 200 : 100) * this.Modifiers * overtricks // (re-)double overtricks: 100/200/200/400
                    : overtricks * ((this.Denomination == Contract.DENOMINATION_CLUBS || this.Denomination == Contract.DENOMINATION_DIAMONDS) ? 20 : 30); // undoubled overtricks
            }
            // If EW played the board, the score is shifted to the other side
            if (this.Declarer == Contract.DECLARER_WEST || this.Declarer == Contract.DECLARER_EAST)
            {
                score = -score;
            }
            return score;
        }
    }
}
