using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagellanMock
{
    public static class StringExtension
    {
        public static string NTrace(this string s, params object[] args)
        {
            string msg = string.Format(s, args);
            System.Diagnostics.Trace.WriteLine(msg);
            return msg;
        }

        public static string XTrace(this string s, Exception ex)
        {
            return ex.ToString().NTrace(ex);
        }

        public static string XTrace(this string s, Exception ex, params object[] args)
        {
            ex.ToString().NTrace(ex);
            return s.NTrace(args);
        }
    }
}
