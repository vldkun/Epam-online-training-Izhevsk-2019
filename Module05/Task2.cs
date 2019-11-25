using System;

namespace Module05
{
    /// <summary>
    /// Task Izh-05-2. Creating types in C#. 
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// Sorting rows of a matrix.
        /// </summary>
        /// <param name="array">Matrix - 2D array.</param>
        /// <param name="sortMode">
        /// 0 - sort by sum of row,
        /// 1 - sort by max element in row,
        /// 2 - sort by min element in row.
        /// </param>
        /// <param name="order">
        /// 0 - sorting in increasing order,
        /// 1 - sorting in decreasing order.
        /// </param>
        /// <returns>Returns new sorted matrix.</returns>
        public static int[,] SortMatrix(int[,] array, int sortMode, int order)
        {
            if ((order != 0 && order != 1) || (sortMode < 0 || sortMode > 2))
            {
                throw new ArgumentOutOfRangeException();
            }

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
                if (sortMode == 0)
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
                        if ((sortMode == 1 && arrayOfKeys[i] < array[i, j]) ||
                            (sortMode == 2 && arrayOfKeys[i] > array[i, j]))
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
                    if ((order == 0 && arrayOfKeys[j - 1] > arrayOfKeys[j]) ||
                        (order == 1 && arrayOfKeys[j - 1] < arrayOfKeys[j]))
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
