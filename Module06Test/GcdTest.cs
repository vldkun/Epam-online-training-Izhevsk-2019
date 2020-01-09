using System;
using System.IO;
using NUnit.Framework;
using Module06;

namespace Module06Test
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
            return Gcd.GcdEuclid(a, b);
        }

        [TestCase(13, 13, ExpectedResult = 13)]
        [TestCase(624129, 2061517, ExpectedResult = 18913)]
        [TestCase(20, 100, ExpectedResult = 20)]
        [TestCase(-20, 100, ExpectedResult = 20)]
        [TestCase(0, 2, ExpectedResult = 2)]
        public int CheckGcdStein(int a, int b)
        {
            return Gcd.GcdStein(a, b);
        }

        [TestCase(new int[] {-9, 3, -6, 0}, ExpectedResult = 3)]
        [TestCase(new int[] {-10, 10, 20, 0}, ExpectedResult = 10)]
        [TestCase(new int[] {0, 0, 0, 10}, ExpectedResult = 10)]
        public int CheckGcdEuclidArray(int[] array)
        {
            return Gcd.GcdEuclid(array);
        }

        [TestCase(new int[] {-9, 3, -6, 0}, ExpectedResult = 3)]
        [TestCase(new int[] {-10, 10, 20, 0}, ExpectedResult = 10)]
        [TestCase(new int[] {0, 0, 0, 10}, ExpectedResult = 10)]
        public int CheckGcdSteinArray(int[] array)
        {
            return Gcd.GcdStein(array);
        }

        [TestCase(0, 0)]
        public void GcdStein_CheckArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.GcdStein(a, b));
        }

        [TestCase(0, 0)]
        public void GcdEuclid_CheckArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.GcdEuclid(a, b));
        }

        [TestCase(new int[] {0, 0, 0, 0})]
        public void GcdSteinArray_CheckArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.GcdStein(array));
        }

        [TestCase(new int[] {0, 0, 0, 0})]
        public void GcdEuclidArray_CheckArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(
                () => Gcd.GcdEuclid(array));
        }

        [Test]
        public void TestMeasuringOfComputingTimeGcd()
        {
            var path = @"..\temp\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var testFile = new FileInfo(path + "test1.txt");
            if (!testFile.Exists)
            {
                testFile.Create();
            }

            var a = 624129;
            var b = 2061517;
            var times1 = Gcd.MeasureRunningTimeGcd(a, b);
            times1 = Gcd.MeasureRunningTimeGcd(a, b);
            var times2 = Gcd.MeasureRunningTimeGcd2(a, b);
            times2 = Gcd.MeasureRunningTimeGcd2(a, b);
            using (var sw = new StreamWriter(testFile.FullName))
            {
                sw.WriteLine("Running time of gcd method(measured by System.Diagnostics):");
                sw.WriteLine(" Euclidean algorithm: {0,10} ticks.\n Stein's algorithm: {1,12} ticks.", times1[0],
                    times1[1]);
                sw.WriteLine("Running time of gcd method(measured by System.DateTime):");
                sw.WriteLine(" Euclidean algorithm: {0,10} ticks.\n Stein's algorithm: {1,12} ticks.", times2[0],
                    times2[1]);
            }

            Assert.Pass();
        }

        [Test]
        public void TestMeasuringOfComputingTimeGcdArray()
        {
            var path = @"..\temp\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var testFile = new FileInfo(path + "test2.txt");
            if (!testFile.Exists)
            {
                testFile.Create();
            }

            var array = new int[] {-1000, 1050, 2030, 2500};
            var times1 = Gcd.MeasureRunningTimeGcd(array);
            times1 = Gcd.MeasureRunningTimeGcd(array);
            var times2 = Gcd.MeasureRunningTimeGcd2(array);
            times2 = Gcd.MeasureRunningTimeGcd2(array);
            using (var sw = new StreamWriter(testFile.FullName))
            {
                sw.WriteLine("Running time of gcd of array method(measured by System.Diagnostics):");
                sw.WriteLine(" Euclidean algorithm: {0,10} ticks.\n Stein's algorithm: {1,12} ticks.", times1[0],
                    times1[1]);
                sw.WriteLine("Running time of gcd of array method(measured by System.DateTime):");
                sw.WriteLine(" Euclidean algorithm: {0,10} ticks.\n Stein's algorithm: {1,12} ticks.", times2[0],
                    times2[1]);
            }

            Assert.Pass();
        }
    }
}