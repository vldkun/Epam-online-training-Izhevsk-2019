using System;
using NUnit.Framework;
using Module05;

namespace Module05Test
{
    [TestFixture]
    class Task2Test
    {
        private static object[][] TestCases = new[]
        {
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                0, 0,
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {-2, -1, 0, 10, -12},
                    {0, 0, 0, 0, 1},
                    {1, 2, 3, 4, 5},
                    {2, 8, 10, 1, 3}
                }
            },
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                1, 0,
                new int[,]
                {
                    {0, 0, 0, 0, 1},
                    {0, 1, 3, -6, -3},
                    {1, 2, 3, 4, 5},
                    {2, 8, 10, 1, 3},
                    {-2, -1, 0, 10, -12}
                }
            },
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                2, 0,
                new int[,]
                {
                    {-2, -1, 0, 10, -12},
                    {0, 1, 3, -6, -3},
                    {0, 0, 0, 0, 1},
                    {2, 8, 10, 1, 3},
                    {1, 2, 3, 4, 5}
                }
            },
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                0, 1,
                new int[,]
                {
                    {2, 8, 10, 1, 3},
                    {1, 2, 3, 4, 5},
                    {0, 0, 0, 0, 1},
                    {0, 1, 3, -6, -3},
                    {-2, -1, 0, 10, -12}
                }
            },
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                1, 1,
                new int[,]
                {
                    {2, 8, 10, 1, 3},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5},
                    {0, 1, 3, -6, -3},
                    {0, 0, 0, 0, 1},
                }
            },
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                2, 1,
                new int[,]
                {
                    {2, 8, 10, 1, 3},
                    {1, 2, 3, 4, 5},
                    {0, 0, 0, 0, 1},
                    {0, 1, 3, -6, -3},
                    {-2, -1, 0, 10, -12}
                }
            }
        };

        [TestCaseSource("TestCases")]
        public void CheckSorting(int[,] array, int sortMode, int order, int[,] expectedArray)
        {
            Assert.AreEqual(expectedArray, Task2.SortMatrix(array, sortMode, order));
        }

        private static object[][] TestCasesNegative = new[]
        {
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                -2, 0
            },
            new object[]
            {
                new int[,]
                {
                    {0, 1, 3, -6, -3},
                    {2, 8, 10, 1, 3},
                    {0, 0, 0, 0, 1},
                    {-2, -1, 0, 10, -12},
                    {1, 2, 3, 4, 5}
                },
                0, 4
            }
        };

        [TestCaseSource("TestCasesNegative")]
        public void MatrixSorting_CheckArgumentOutOfRangeException(int[,] array, int sortMode, int order)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => Task2.SortMatrix(array, sortMode, order));
        }
    }
}
