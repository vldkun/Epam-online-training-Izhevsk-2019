using System;
using System.Collections.Generic;
using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class Task1Test
    {
        [TestCase(new int[] {-1, 4, 31, 45, 343, 343}, 45, ExpectedResult = 3)]
        [TestCase(new int[] {-1}, -1, ExpectedResult = 0)]
        [TestCase(new int[] {-1, 4}, 4, ExpectedResult = 1)]
        [TestCase(new int[] {-1, 4, 31, 45, 343, 343}, 5, ExpectedResult = -1)]
        [TestCase(new int[] {345, 43, 32, 32, 23, 1, -123}, 23, ExpectedResult = 4)]
        [TestCase(new int[] {345, 43, 32, 32, 23, 1, -123}, 22, ExpectedResult = -1)]
        [TestCase(new int[] {345, 43, 32, 32, 23, 1, -123}, 32, ExpectedResult = 2)]
        public int BinarySearchTest(int[] array, int key)
        {
            return Task1.BinarySearch(array, key, Comparer<int>.Create(((i, i1) => i.CompareTo(i1))));
        }
    }
}
