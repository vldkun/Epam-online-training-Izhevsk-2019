using System;

namespace Module08
{
    /// <summary>
    /// Izh-08-1. Encapsulation. Inheritance. Polymorphism
    /// </summary>
    public class Matrix
    {
        public int[,] Elements;
        private readonly int height;
        private readonly int width;

        public Matrix(int _height, int _width)
        {
            height = _height;
            width = _width;
            Elements = new int[height, width];
        }

        public Matrix(int[,] array)
        {
            height = array.GetLength(0);
            width = array.GetLength(1);
            Elements = new int[height, width];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Elements[i, j] = array[i, j];
                }
            }
        }

        public int this[int row, int col]
        {
            get => Elements[row, col];
            set => Elements[row, col] = value;
        }
        /// <summary>
        /// Sorting rows of a matrix.
        /// </summary>
        /// <param name="sortMode">
        /// 0 - sort by sum of row,
        /// 1 - sort by max element in row,
        /// 2 - sort by min element in row.
        /// </param>
        /// <param name="order">
        /// 0 - sorting in increasing order,
        /// 1 - sorting in decreasing order.
        /// </param>
        public void Sort(int sortMode, int order)
        {
            if ((order != 0 && order != 1) || (sortMode < 0 || sortMode > 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            var rows = width;
            var cols = height;
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
                        arrayOfKeys[i] += Elements[i, j];
                    }
                }
                else
                {
                    arrayOfKeys[i] = Elements[i, 0];
                    for (int j = 0; j < cols; j++)
                    {
                        if ((sortMode == 1 && arrayOfKeys[i] < Elements[i, j]) ||
                            (sortMode == 2 && arrayOfKeys[i] > Elements[i, j]))
                        {
                            arrayOfKeys[i] = Elements[i, j];
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
                    resultArray[i, j] = Elements[arrayOfIndexes[i], j];
                }
            }

            Elements = resultArray;
        }
    }
}
