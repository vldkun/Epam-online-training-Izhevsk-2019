using System;
using System.Collections;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-6. Basic Coding in C#. 
    /// </summary>
    public class Task6
    {
        /// <summary>
        /// Filter the array deleting all elements that hasn't certain digit.
        /// </summary>
        /// <param name="array">Array of int numbers.</param>
        /// <param name="filter">The digit should be in all elements of returned array.</param>
        /// <returns>Returns array those all elements contains filter.</returns>
        public static int[] FilterDigit(int[] array, int filter)
        {
            ArrayList filteredArray = new ArrayList();
            foreach (var elem in array)
            {
                if (Convert.ToString(elem).Contains(filter.ToString()))
                {
                    filteredArray.Add(elem);
                }
            }

            int[] resultArray = (int[]) filteredArray.ToArray(typeof(int));
            return resultArray;
        }
    }
}
