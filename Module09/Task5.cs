using System;
using System.Text;

namespace Module09
{
    /// <summary>
    /// Izh-09-5. Framework Fundamentals
    /// </summary>
    public class Task5
    {
        /// <summary>
        /// Reverses all of the words within the string passed in. 
        /// </summary>
        /// <param name="str">String to reverse.</param>
        /// <returns>Returns reversed string.</returns>
        public static string ReverseString(string str)
        {
            string[] arrayOfStrings = str.Split(' ');
            var reversedStrSb = new StringBuilder(arrayOfStrings[arrayOfStrings.Length - 1]);
            for (int i = arrayOfStrings.Length - 2; i >= 0; i--)
            {
                reversedStrSb.Append(" " + arrayOfStrings[i]);
            }

            return reversedStrSb.ToString();
        }
    }
}