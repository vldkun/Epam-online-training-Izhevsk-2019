using System;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-2. Basic Coding in C#. 
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// The recursive search of max element.
        /// </summary>
        /// <param name="array">The array to find max.</param>
        /// <param name="leftIndex">Left border of searching.</param>
        /// <param name="rightIndex">Right border of searching.</param>
        /// <returns>Returns the max of two array halves.</returns>
        public static int FindMaxElem(int[] array, int leftIndex, int rightIndex)
        {
            if (rightIndex == leftIndex)
                return array[rightIndex];
            int medIndex = (leftIndex + rightIndex) / 2;
            return Math.Max(FindMaxElem(array, leftIndex, medIndex), FindMaxElem(array, medIndex + 1, rightIndex));
        }
    }
}
