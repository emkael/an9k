using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator9000
{
    class Contract: IEquatable<Contract>
    {
        public int Denomination;
        public int Declarer;
        
        public Contract(int denom, int decl)
        {
            this.Denomination = denom;
            this.Declarer = decl;
        }

        public bool Equals(Contract other)
        {
            return this.Denomination == other.Denomination && this.Declarer == other.Declarer;
        }
    }
}
