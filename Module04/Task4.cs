using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task4
    {
        public string ConcatNoRepeats(string s1, string s2)
        {
            return String.Concat(s1, s2).Distinct().ToString();
        }
    }
}
