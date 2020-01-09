using System;

namespace Module05
{
    /// <summary>
    /// Task Izh-05-2. Creating types in C#. 
    /// </summary>
    public class Task2
    {
        public enum SortMode
        {
            BySum,
            ByMax,
            ByMin
        }

        public enum Order
        {
            Increasing,
            Decreasing
        }

        /// <summary>
        /// Sorting rows of a matrix.
        /// </summary>
        /// <param name="array">Matrix - 2D array.</param>
        /// <param name="sortMode">
        /// Sorting by sum of row or by max or min element in row.
        /// </param>
        /// <param name="order">
        /// Sorting in increasing or decreasing order.
        /// </param>
        /// <returns>Returns new sorted matrix.</returns>
        public static int[,] SortMatrix(int[,] array, SortMode sortMode, Order order)
        {
            var rows = array.GetLength(0);
            var cols = array.GetLength(1);
            var resultArray = new int[rows, cols];

            var arrayOfKeys = new int[rows];
            var arrayOfIndexes = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                arrayOfIndexes[i] = i;
            }

            for (int i = 0; i < rows; i++)
            {
                if (sortMode == SortMode.BySum)
                {
                    arrayOfKeys[i] = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        arrayOfKeys[i] += array[i, j];
                    }
                }
                else
                {
                    arrayOfKeys[i] = array[i, 0];
                    for (int j = 0; j < cols; j++)
                    {
                        if ((sortMode == SortMode.ByMax && arrayOfKeys[i] < array[i, j]) ||
                            (sortMode == SortMode.ByMin && arrayOfKeys[i] > array[i, j]))
                        {
                            arrayOfKeys[i] = array[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = rows - 1; j > i; j--)
                {
                    if ((order == Order.Increasing && arrayOfKeys[j - 1] > arrayOfKeys[j]) ||
                        (order == Order.Decreasing && arrayOfKeys[j - 1] < arrayOfKeys[j]))
                    {
                        var tempKey = arrayOfKeys[j - 1];
                        arrayOfKeys[j - 1] = arrayOfKeys[j];
                        arrayOfKeys[j] = tempKey;
                        var tempIndex = arrayOfIndexes[j - 1];
                        arrayOfIndexes[j - 1] = arrayOfIndexes[j];
                        arrayOfIndexes[j] = tempIndex;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultArray[i, j] = array[arrayOfIndexes[i], j];
                }
            }

            return resultArray;
        }
    }
}
