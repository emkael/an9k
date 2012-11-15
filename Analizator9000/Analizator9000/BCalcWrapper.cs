using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Analizator9000
{
    class BCalcWrapper
    {
        [DllImport("bin\\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr bcalcDDS_new(IntPtr format, IntPtr hands, Int32 trump, Int32 leader);

        [DllImport("bin\\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 bcalcDDS_getTricksToTake(IntPtr solver);

        [DllImport("bin\\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr bcalcDDS_getLastError(IntPtr solver);

        [DllImport("bin\\libbcalcdds.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void bcalcDDS_delete(IntPtr solver);

        private static String table = "NESW";
        private static String trumps = "CDHSN";
        public static int runDeal(String deal, char trumpSuit, char declarer)
        {
            int decl = BCalcWrapper.table.IndexOf(declarer);
            if (decl < 0)
            {
                throw new Exception("Nieprawidłowy rozgrywający");
            }
            int leader = (decl + 1) % 4;
            int trump = BCalcWrapper.trumps.IndexOf(trumpSuit);
            if (trump < 0)
            {
                throw new Exception("Nieprawidłowe miano");
            }
            IntPtr solver = BCalcWrapper.bcalcDDS_new(Marshal.StringToHGlobalAnsi(BCalcWrapper.table), Marshal.StringToHGlobalAnsi(deal), trump, leader);
            IntPtr error = BCalcWrapper.bcalcDDS_getLastError(solver);
            String eStr = Marshal.PtrToStringAnsi(error);
            if (eStr != null)
            {
                throw new Exception(eStr);
            }
            int ret = 13 - BCalcWrapper.bcalcDDS_getTricksToTake(solver);
            BCalcWrapper.bcalcDDS_delete(solver);
            return ret;
        }
    }
}
