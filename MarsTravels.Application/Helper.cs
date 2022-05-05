using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTravels.Application
{
    public static class Helper
    {
        public static bool StringEq(string s1, string s2)
        {
            return string.Equals(s1, s2, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
