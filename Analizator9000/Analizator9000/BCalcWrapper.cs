using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Analizator9000
{
    /// <summary>
    /// Structure holding single deal analysis result.
    /// </summary>
    struct BCalcResult
    {
        /// <summary>
        /// Trump denomination (N/S/H/D/C).
        /// </summary>
        public char trumpSuit;
        /// <summary>
        /// Declaring player (N/E/S/W).
        /// </summary>
        public char declarer;
        /// <summary>
        /// Number of tricks taken by the declaring side.
        /// </summary>
        public int tricks;
        /// <summary>
        /// Deal number, parsed out from input string.
        /// </summary>
        public long dealNo;
        /// <summary>
        /// Constructor for result structure.
        /// </summary>
        /// <param name="a">Trump denomination (N/S/H/D/C).</param>
        /// <param name="b">Declaring player (N/E/S/W).</param>
        /// <param name="c">Number of tricks taken by the declaring side.</param>
        /// <param name="d">Deal number, parsed out from input string.</param>
        public BCalcResult(char a, char b, int c, long d)
        {
            trumpSuit = a;
            declarer = b;
            tricks = c;
            dealNo = d;
        }
    };
    /// <summary>
    /// Wrapper class for libbcalcDDS.ddl.
    /// </summary>
    class BCalcWrapper
    {
        /// <summary>
        /// Allocates new instance of BCalc solver.
        /// </summary>
        /// <param name="format">Deal format string. See the original documentation for details.</param>
        /// <param name="hands">Card distribution.</param>
        /// <param name="trump">Trump denomination, in numeric format. See the original documentation for details.</param>
        /// <param name="leader">Player on lead, in numeric format. See the original documentation for details.</param>
        /// <returns>Pointer to solver instance.</returns>
        /// <remarks>Original documentation: http://bcalc.w8.pl/API_C/bcalcdds_8h.html#ab636045f65412652246b769e8e95ed6f</remarks>
        //TODO Enum/constants for trumps/players, definitely.
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr bcalcDDS_new(IntPtr format, IntPtr hands, Int32 trump, Int32 leader);

        /// <summary>
        /// Conducts DD analysis.
        /// </summary>
        /// <param name="solver">Pointer to solver instance.</param>
        /// <returns>Number of tricks to take by leading side.</returns>
        /// <remarks>Original documentation: http://bcalc.w8.pl/API_C/bcalcdds_8h.html#a369ce661d027bef3f717967e42bf8b33</remarks>
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 bcalcDDS_getTricksToTake(IntPtr solver);

        /// <summary>
        /// Checks for solver errors.
        /// </summary>
        /// <param name="solver">Pointer to solver instance.</param>
        /// <returns>Error string or NULL if no error accured.</returns>
        /// <remarks>Original documentation: http://bcalc.w8.pl/API_C/bcalcdds_8h.html#a89cdec200cde91331d40f0900dc0fb46</remarks>
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr bcalcDDS_getLastError(IntPtr solver);

        /// <summary>
        /// Frees allocated solver instance and cleans up after it.
        /// </summary>
        /// <param name="solver">Pointer to solver instance.</param>
        /// <remarks>Original documentation: http://bcalc.w8.pl/API_C/bcalcdds_8h.html#a4a68da83bc7da4663e2257429539912d</remarks>
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_delete(IntPtr solver);

        /// <summary>
        /// Sets trump denomination and resets the analysis.
        /// </summary>
        /// <param name="solver">Pointer to solver instance.</param>
        /// <param name="trump">Trump denomination, in numeric format. See the original documentation for details.</param>
        /// <remarks>Original documentation: http://bcalc.w8.pl/API_C/bcalcdds_8h.html#a88fba3432e66efa5979bbc9e1f044164</remarks>
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_setTrumpAndReset(IntPtr solver, Int32 trump);

        /// <summary>
        /// Sets leading player and resets the analysis.
        /// </summary>
        /// <param name="solver">Pointer to solver instance.</param>
        /// <param name="player">Player on lead, in numeric format. See the original documentation for details.</param>
        /// <remarks>Original documentation: http://bcalc.w8.pl/API_C/bcalcdds_8h.html#a616031c1e1d856c4aac14390693adb4c</remarks>
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_setPlayerOnLeadAndReset(IntPtr solver, Int32 player);

        /// <summary>
        /// Translation table between player characters and numeric values.
        /// </summary>
        public static String table = "NESW";
        /// <summary>
        /// Translation table between denomination characters and numeric values.
        /// </summary>
        public static String denominations = "CDHSN";

        /// <summary>
        /// Pointer to solver instance.
        /// </summary>
        private IntPtr solver;
        /// <summary>
        /// Deal distribution.
        /// </summary>
        private String deal;
        /// <summary>
        /// Internal number of deal being analyzed.
        /// </summary>
        private long dealNo;
        /// <summary>
        /// Trump suit, in numeric format.
        /// </summary>
        private int trumps;
        
        /// <summary>
        /// Constructor of class instance for single deal analysis.
        /// </summary>
        /// <param name="deal">Deal distribution prefixed with deal number.</param>
        public BCalcWrapper(String deal)
        {
            try
            {
                Match dealMatch = Regex.Match(deal, @"^(\d+): (.*)$");
                if (!dealMatch.Success) {
                    throw new Exception();
                }
                this.deal = dealMatch.Groups[2].Value;
                this.dealNo = Convert.ToInt64(dealMatch.Groups[1].Value);
            }
            catch (Exception)
            {
                throw new Exception("Nie można wczytać rozdania: " + deal);
            }
            this.solver = BCalcWrapper.bcalcDDS_new(Marshal.StringToHGlobalAnsi(BCalcWrapper.table), Marshal.StringToHGlobalAnsi(this.deal), 0, 0);
            this.errorCheck();
        }

        /// <summary>
        /// Sets the trump denomination.
        /// </summary>
        /// <param name="trumpSuit">Trump denomination, in numeric format.</param>
        public void setTrump(int trumpSuit)
        {
            if (trumpSuit < 0)
            {
                throw new Exception("Nieprawidłowe miano: " + trumpSuit);
            }
            BCalcWrapper.bcalcDDS_setTrumpAndReset(solver, trumpSuit);
            this.errorCheck();
            this.trumps = trumpSuit;
        }

        /// <summary>
        /// Runs the single contract analysis.
        /// </summary>
        /// <param name="declarer">Declaring player, in numeric format.</param>
        /// <returns>Result structur for the contract.</returns>
        public BCalcResult run(int declarer)
        {
            if (declarer < 0)
            {
                throw new Exception("Nieprawidłowy rozgrywający: " + declarer);
            }
            int l = (declarer + 1) % 4;
            BCalcWrapper.bcalcDDS_setPlayerOnLeadAndReset(solver, l);
            this.errorCheck();
            int result = BCalcWrapper.bcalcDDS_getTricksToTake(this.solver);
            this.errorCheck();
            return new BCalcResult(BCalcWrapper.denominations[this.trumps], BCalcWrapper.table[declarer], 13 - result, this.dealNo);
        }

        /// <summary>
        /// Releases the solver instaces.
        /// </summary>
        public void destroy() {
            BCalcWrapper.bcalcDDS_delete(this.solver);
        }

        /// <summary>
        /// Checks for errors, throws exception if any occured.
        /// </summary>
        private void errorCheck()
        {
            IntPtr error = BCalcWrapper.bcalcDDS_getLastError(this.solver);
            String eStr = Marshal.PtrToStringAnsi(error);
            if (eStr != null)
            {
                throw new Exception(eStr);
            }
        }

    }
}
