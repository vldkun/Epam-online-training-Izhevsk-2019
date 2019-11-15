using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task4
    {
        public static string ConcatNoRepeats(string str1, string str2)
        {
            StringBuilder resultStrSB = new StringBuilder();
            resultStrSB.Append(str1);
            foreach (var symbol in str2)
            {
                if (!str1.Contains(symbol))
                {
                    resultStrSB.Append(symbol);
                }
            }
            return resultStrSB.ToString();
        }
    }
}
