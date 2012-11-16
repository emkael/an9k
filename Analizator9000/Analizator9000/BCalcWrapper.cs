using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Analizator9000
{
    struct BCalcResult
    {
        public char trumpSuit;
        public char declarer;
        public int tricks;
        public long dealNo;
        public BCalcResult(char a, char b, int c, long d)
        {
            trumpSuit = a;
            declarer = b;
            tricks = c;
            dealNo = d;
        }
    };
    class BCalcWrapper
    {
        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr bcalcDDS_new(IntPtr format, IntPtr hands, Int32 trump, Int32 leader);

        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 bcalcDDS_getTricksToTake(IntPtr solver);

        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr bcalcDDS_getLastError(IntPtr solver);

        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_delete(IntPtr solver);

        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_setTrumpAndReset(IntPtr solver, Int32 trump);

        [DllImport(@"bin\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_setPlayerOnLeadAndReset(IntPtr solver, Int32 player);

        public static String table = "NESW";
        public static String denominations = "CDHSN";

        private IntPtr solver;
        private String deal;
        private long dealNo;
        private int trumps;
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

        public void destroy() {
            BCalcWrapper.bcalcDDS_delete(this.solver);
        }

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
