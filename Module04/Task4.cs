using System;
using System.Linq;
using System.Text;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-4. Basic Coding in C#. 
    /// </summary>
    public class Task4
    {
        /// <summary>
        /// Concatenation to the first string all the characters from the second string
        /// except characters the first string has.
        /// </summary>
        /// <param name="str1">The fist string.</param>
        /// <param name="str2">The second string.</param>
        /// <returns>Returns result concatenated string.</returns>
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
