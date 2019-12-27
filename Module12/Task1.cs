using System;
using System.Collections.Generic;

namespace Module12
{
    /// <summary>
    /// Izh-12-1. Generics and Collections
    /// </summary>
    public class Task1
    {
        /// <summary>
        /// Binary search of element in sorted array.
        /// </summary>
        /// <typeparam name="T">Type of array.</typeparam>
        /// <param name="sortedArray">Sorted array to find.</param>
        /// <param name="key"></param>
        /// <param name="comparer"></param>
        /// <returns>Returns index of element or -1 if not found.</returns>
        public static int BinarySearch<T>(T[] sortedArray, T key, Comparer<T> comparer)
        {
            var leftIndex = 0;
            var rightIndex = sortedArray.Length;
            var order = comparer.Compare(sortedArray[0], sortedArray[sortedArray.Length - 1]);
            while (leftIndex < rightIndex)
            {
                var midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (comparer.Compare(key, sortedArray[leftIndex]) == 0)
                {
                    return leftIndex;
                }


                if (comparer.Compare(key, sortedArray[midIndex]) == 0)
                {
                    if (midIndex == leftIndex + 1)
                    {
                        return midIndex;
                    }

                    rightIndex = midIndex + 1;
                }
                else
                {
                    if ((comparer.Compare(sortedArray[midIndex], key) > 0) ^ (order > 0))
                    {
                        rightIndex = midIndex;
                    }
                    else
                    {
                        leftIndex = midIndex + 1;
                    }
                }
            }

            return -1;
        }
    }
}
