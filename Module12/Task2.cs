
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Module12
{
    /// <summary>
    /// Izh-12-2. Generics and Collections
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// Determining the frequency of occurrences of words in the text.
        /// </summary>
        /// <param name="str">Some text.</param>
        /// <returns>Returns dictionary, which is set of pairs of word and its frequency.</returns>
        public static Dictionary<string, int> CountFrequencyOfOccurrences(string str)
        {
            var arrayOfWords = Regex.Split(str, @"[^0-9a-zA-Z]+");
            var dictionary = new Dictionary<string, int>();
            foreach (var word in arrayOfWords)
            {
                var lowWord = word.ToLower();
                if (dictionary.ContainsKey(lowWord))
                {
                    dictionary[lowWord]++;
                }
                else
                {
                    if (lowWord != string.Empty)
                    {
                        dictionary.Add(lowWord, 1);
                    }
                }
            }

            return dictionary;
        }
    }
}
