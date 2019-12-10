using System;
using System.Text;

namespace Module09
{
    /// <summary>
    /// Izh-09-2. Framework Fundamentals
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// Convert string to where only the first letter of the word is in upper case,
        /// except whe words in exceptional list that should be only lower case.
        /// </summary>
        /// <param name="str">The original string to be converted.</param>
        /// <param name="exceptionalList">Space-delimited list of minor words that must always be lowercase except for the first word in the string.</param>
        /// <returns></returns>
        public static string TitleCase(string str, string exceptionalList = "")
        {
            string[] words = str.Split(' ');
            string[] exceptionalWords = exceptionalList.Split(' ');
            var resultSb = new StringBuilder();
            for (int i = 0; i < exceptionalWords.Length; i++)
            {
                exceptionalWords[i] = exceptionalWords[i].ToLower();
            }

            foreach (var word in words)
            {
                if (Array.IndexOf(exceptionalWords, word.ToLower()) >= 0)
                {
                    resultSb.Append(word.ToLower() + " ");
                }
                else
                {
                    var newWordSb = new StringBuilder();
                    newWordSb.Append(word[0].ToString().ToUpper());
                    if (word.Length > 1)
                    {
                        newWordSb.Append(word.Substring(1).ToLower());
                    }

                    resultSb.Append(newWordSb + " ");
                }
            }

            var firstLetter = resultSb[0].ToString().ToUpper();
            resultSb.Remove(0, 1);
            resultSb.Insert(0, firstLetter);
            if (resultSb[resultSb.Length - 1] == ' ')
            {
                resultSb.Remove(resultSb.Length - 1, 1);
            }

            return resultSb.ToString();
        }
    }
}
