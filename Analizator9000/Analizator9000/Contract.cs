using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator9000
{
    /// <summary>
    /// Tuple describing contract parameters. Created only because .NET 3.5 doesn't have Tuple type yet.
    /// </summary>
    class Contract: IEquatable<Contract>
    {
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
        /// Modifiers - double or redouble.
        /// </summary>
        public int Modifiers;
        /// <summary>
        /// Declaring player, in numeric format.
        /// </summary>
        /// <see cref="BCalcWrapper"/>
        public int Declarer;
        
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
        public Contract(int level, int denom, int decl, int modifiers = 0)
        {
            this.Level = level;
            this.Denomination = denom;
            this.Declarer = decl;
            this.Modifiers = modifiers;
        }

        /// <summary>
        /// IEquatable method for comparing (checking equality) of two tuples.
        /// </summary>
        /// <param name="other">Tuple to compare to.</param>
        /// <returns>TRUE if both tuple components are equal.</returns>
        public bool Equals(Contract other)
        {
            return this.Denomination == other.Denomination && this.Declarer == other.Declarer &&
                this.Level == other.Level && this.Modifiers == other.Modifiers;
        }
    }
}
