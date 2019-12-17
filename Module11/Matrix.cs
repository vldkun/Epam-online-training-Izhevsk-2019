using System;

namespace Module11
{
    /// <summary>
    /// Izh-11-2. Delegates. Lambdas and Events
    /// </summary>
    public class Matrix
    {
        public int[,] Elements;
        private readonly int _height;
        private readonly int _width;

        public Matrix(int height, int width)
        {
            _height = height;
            _width = width;
            Elements = new int[height, width];
        }

        public Matrix(int[,] array)
        {
            _height = array.GetLength(0);
            _width = array.GetLength(1);
            Elements = new int[_height, _width];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
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

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        /// <summary>
        /// Sorting rows of a matrix.
        /// </summary>
        /// <param name="comparisonCriterion">
        /// This criterion will be consequentially
        /// applied to elements of each row. It can be sum, min or max.
        /// </param>
        /// <param name="sortingOrder">
        /// Predicate of difference of two numbers.
        /// Ascending order - if difference bigger than zero, predicate is true. 
        /// Descending order - false.
        /// </param>
        public void Sort(Func<int, int, int> comparisonCriterion, Predicate<int> sortingOrder)
        {
            var rows = _width;
            var cols = _height;
            var resultArray = new int[rows, cols];

            var arrayOfKeys = new int[rows];
            var arrayOfIndexes = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                arrayOfIndexes[i] = i;
            }

            for (int i = 0; i < rows; i++)
            {
                arrayOfKeys[i] = Elements[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    arrayOfKeys[i] = comparisonCriterion(Elements[i, j], arrayOfKeys[i]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = rows - 1; j > i; j--)
                {
                    if (sortingOrder(arrayOfKeys[j - 1] - arrayOfKeys[j]))
                    {
                        Swap(ref arrayOfKeys[j - 1], ref arrayOfKeys[j]);
                        Swap(ref arrayOfIndexes[j - 1], ref arrayOfIndexes[j]);
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
