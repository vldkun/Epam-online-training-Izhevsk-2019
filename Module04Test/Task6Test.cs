using System;
using NUnit.Framework;
using Module04;

namespace Module04Test
{
    [TestFixture]
    public class Task6Test
    {
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -69, 70, 15, 17 }, 6, ExpectedResult = new int[] { 6, 68, -69 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -68, 70, 15, 17 }, 9, ExpectedResult = new int[] { })]
        public int[] CheckDigitFiltering(int[] sourceArray, int digit)
        {
            return Task6.FilterDigit(sourceArray, digit);
        }
    }
}