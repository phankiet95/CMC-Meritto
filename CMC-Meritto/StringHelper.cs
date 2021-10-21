using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMC_Meritto
{
    public static class StringHelper
    {
        public static string[] getList(string s)
        {
            if (s == "" || s == null)
                return new string[] { };

            string[] lines = s.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            return lines;
        }

        public static string upcaseFirstchar(string s)
        {
            if (s == "")
                return "";
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
