using System;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-3. Basic Coding in C#. 
    /// </summary>
    public class Task3
    {
        private const double Eps = 0.00001;

        /// <summary>
        /// Finding an index of an element in the array that has equal sums of elements left and right.
        /// </summary>
        /// <param name="array">The array for searching.</param>
        /// <returns>If this element exists returns his index, either returns -1.</returns>
        public static int FindIndex(double[] array)
        {
            if (array.Length < 3)
            {
                return -1;
            }

            double leftSum = array[0];
            double rightSum = 0;
            for (int i = 2; i < array.Length; i++)
            {
                rightSum += array[i];
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (Math.Abs(rightSum - leftSum) < Eps)
                {
                    return i;
                }

                leftSum += array[i];
                rightSum -= array[i + 1];
            }

            return -1;
        }
    }
}
