using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-2. Basic Coding in C#. 
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// The recursive search of max element
        /// Returns the max of two array halves 
        /// </summary>
        public static int FindMaxElem(int[] array, int leftIndex, int rightIndex)
        {
            if (rightIndex == leftIndex)
                return array[rightIndex];
            int medIndex = (leftIndex + rightIndex) / 2;
            return Math.Max(FindMaxElem(array, leftIndex, medIndex), FindMaxElem(array, medIndex + 1, rightIndex));
        }
    }
}
