using System;
using System.IO;
using NUnit.Framework;
using Module11;

namespace Module11Test
{
    [TestFixture]
    public class GcdTest
    {
        [TestCase(13, 13, ExpectedResult = 13)]
        [TestCase(624129, 2061517, ExpectedResult = 18913)]
        [TestCase(20, 100, ExpectedResult = 20)]
        [TestCase(-20, 100, ExpectedResult = 20)]
        [TestCase(0, 2, ExpectedResult = 2)]
        public int CheckGcdEuclid(int a, int b)
        {
            return Gcd.ComputeGcd(Gcd.GcdMethods.Euclid,a, b);
        }

        [TestCase(13, 13, ExpectedResult = 13)]
        [TestCase(624129, 2061517, ExpectedResult = 18913)]
        [TestCase(20, 100, ExpectedResult = 20)]
        [TestCase(-20, 100, ExpectedResult = 20)]
        [TestCase(0, 2, ExpectedResult = 2)]
        public int CheckGcdStein(int a, int b)
        {
            return Gcd.ComputeGcd(Gcd.GcdMethods.Stein, a, b);
        }

        [TestCase(new int[] {-9, 3, -6, 0}, ExpectedResult = 3)]
        [TestCase(new int[] {-10, 10, 20, 0}, ExpectedResult = 10)]
        [TestCase(new int[] {0, 0, 0, 10}, ExpectedResult = 10)]
        public int CheckGcdEuclidArray(int[] array)
        {
            return Gcd.ComputeGcd(Gcd.GcdMethods.Euclid, array);
        }

        [TestCase(new int[] {-9, 3, -6, 0}, ExpectedResult = 3)]
        [TestCase(new int[] {-10, 10, 20, 0}, ExpectedResult = 10)]
        [TestCase(new int[] {0, 0, 0, 10}, ExpectedResult = 10)]
        public int CheckGcdSteinArray(int[] array)
        {
            return Gcd.ComputeGcd(Gcd.GcdMethods.Stein, array);
        }

        [TestCase(0, 0)]
        public void GcdStein_CheckArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.ComputeGcd(Gcd.GcdMethods.Stein,a, b));
        }

        [TestCase(0, 0)]
        public void GcdEuclid_CheckArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.ComputeGcd(Gcd.GcdMethods.Euclid, a, b));
        }

        [TestCase(new int[] {0, 0, 0, 0})]
        public void GcdSteinArray_CheckArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.ComputeGcd(Gcd.GcdMethods.Stein, array));
        }

        [TestCase(new int[] {0, 0, 0, 0})]
        public void GcdEuclidArray_CheckArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.ComputeGcd(Gcd.GcdMethods.Euclid, array));
        }
    }
}