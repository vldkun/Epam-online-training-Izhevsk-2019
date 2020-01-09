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
                Task2.SortMode.BySum, Task2.Order.Increasing,
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
                Task2.SortMode.ByMax, Task2.Order.Increasing,
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
                Task2.SortMode.ByMin, Task2.Order.Increasing,
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
                Task2.SortMode.BySum, Task2.Order.Decreasing,
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
                Task2.SortMode.ByMax, Task2.Order.Decreasing,
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
                Task2.SortMode.ByMin, Task2.Order.Decreasing,
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

        [TestCaseSource(nameof(TestCases))]
        public void CheckSorting(int[,] array, Task2.SortMode sortMode, Task2.Order order, int[,] expectedArray)
        {
            Assert.AreEqual(expectedArray, Task2.SortMatrix(array, sortMode, order));
        }
    }
}
