using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Module09
{
    /// <summary>
    /// Izh-09-4. Framework Fundamentals
    /// </summary>
    public class Task4
    {
        /// <summary>
        /// Changing string without any elements with the same value next to each other and preserving the original order of elements.
        /// </summary>
        /// <param name="str">String to change.</param>
        /// <returns>Returns changed string.</returns>
        public static string UniqueInOrder(string str)
        {
            var uniqueStrSb = new StringBuilder();
            foreach (var elem in str)
            {
                if (uniqueStrSb.Length > 0 && uniqueStrSb[uniqueStrSb.Length - 1] != elem || uniqueStrSb.Length == 0)
                {
                    uniqueStrSb.Append(elem);
                }
            }

            return uniqueStrSb.ToString();
        }

        /// <summary>
        /// Changing list without any elements with the same value next to each other and preserving the original order of elements.
        /// </summary>
        /// <typeparam name="T">Type of list elements</typeparam>
        /// <param name="list">List to change.</param>
        /// <returns>Returns changed list.</returns>
        public static List<T> UniqueInOrder<T>(List<T> list)
        {
            var uniqueList = new List<T>();
            foreach (var elem in list)
            {
                if (uniqueList.Count > 0 && !uniqueList[uniqueList.Count - 1].Equals(elem) || uniqueList.Count == 0)
                {
                    uniqueList.Add(elem);
                }
            }

            return uniqueList;
        }
    }
}

