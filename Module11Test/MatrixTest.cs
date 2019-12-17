using System;
using NUnit.Framework;
using Module11;

namespace Module11Test
{
    [TestFixture]
    public class MatrixTest
    {
        private int[,] array =
        {
            {0, 1, 3, -6, -3},
            {2, 8, 10, 1, 3},
            {0, 0, 0, 0, 1},
            {-2, -1, 0, 10, -12},
            {1, 2, 3, 4, 5}
        };

        [Test]
        public void CheckSortingBySumAscendingOrder()
        {
            var matrix = new Matrix(array);
            int[,] expectedArray =
            {
                {0, 1, 3, -6, -3},
                {-2, -1, 0, 10, -12},
                {0, 0, 0, 0, 1},
                {1, 2, 3, 4, 5},
                {2, 8, 10, 1, 3}
            };

            matrix.Sort((a, b) => a + b, i => i > 0);

            Assert.AreEqual(expectedArray, matrix.Elements);
        }

        [Test]
        public void CheckSortingByMaxAscendingOrder()
        {
            var matrix = new Matrix(array);
            int[,] expectedArray =
            {
                {0, 0, 0, 0, 1},
                {0, 1, 3, -6, -3},
                {1, 2, 3, 4, 5},
                {2, 8, 10, 1, 3},
                {-2, -1, 0, 10, -12}
            };

            matrix.Sort((a, b) => Math.Max(a, b), i => i > 0);

            Assert.AreEqual(expectedArray, matrix.Elements);
        }

        [Test]
        public void CheckSortingByMinAscendingOrder()
        {
            var matrix = new Matrix(array);
            int[,] expectedArray =
            {
                {-2, -1, 0, 10, -12},
                {0, 1, 3, -6, -3},
                {0, 0, 0, 0, 1},
                {2, 8, 10, 1, 3},
                {1, 2, 3, 4, 5}
            };

            matrix.Sort((a, b) => Math.Min(a, b), i => i > 0);

            Assert.AreEqual(expectedArray, matrix.Elements);
        }

        [Test]
        public void CheckSortingBySumDescendingOrder()
        {
            var matrix = new Matrix(array);
            int[,] expectedArray =
            {
                {2, 8, 10, 1, 3},
                {1, 2, 3, 4, 5},
                {0, 0, 0, 0, 1},
                {0, 1, 3, -6, -3},
                {-2, -1, 0, 10, -12}
            };

            matrix.Sort((a, b) => a + b, i => i < 0);

            Assert.AreEqual(expectedArray, matrix.Elements);
        }

        [Test]
        public void CheckSortingByMaxDescendingOrder()
        {
            var matrix = new Matrix(array);
            int[,] expectedArray =
            {
                {2, 8, 10, 1, 3},
                {-2, -1, 0, 10, -12},
                {1, 2, 3, 4, 5},
                {0, 1, 3, -6, -3},
                {0, 0, 0, 0, 1}
            };

            matrix.Sort((a, b) => Math.Max(a, b), i => i < 0);

            Assert.AreEqual(expectedArray, matrix.Elements);
        }

        [Test]
        public void CheckSortingByMinDescendingOrder()
        {
            var matrix = new Matrix(array);
            int[,] expectedArray =
            {
                {2, 8, 10, 1, 3},
                {1, 2, 3, 4, 5},
                {0, 0, 0, 0, 1},
                {0, 1, 3, -6, -3},
                {-2, -1, 0, 10, -12}
            };

            matrix.Sort((a, b) => Math.Min(a, b), i => i < 0);

            Assert.AreEqual(expectedArray, matrix.Elements);
        }
    }
}
