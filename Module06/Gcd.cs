using System;

namespace Module06
{
    /// <summary>
    /// Task Izh-06-2. Methods in details. 
    /// </summary>
    public class Gcd
    {
        /// <summary>
        /// Computes GCD by Euclidean algorithm of two int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>Returns GCD.</returns>
        public static int GcdEuclid(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Gcd not exist");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            return GcdEuclid(b, a % b);
        }

        /// <summary>
        /// Computes GCD by Stein's algorithm of two int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>Returns GCD.</returns>
        public static int GcdStein(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Gcd not exist");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            int shift;
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
            {
                a >>= 1;
            }

            do
            {
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                if (a > b)
                {
                    int temp = b;
                    b = a;
                    a = temp;
                }

                b -= a;
            } while (b != 0);

            return a << shift;
        }

        /// <summary>
        /// Computes GCD by Euclidean algorithm of many int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="array">The array of numbers</param>
        /// <returns>Returns GCD.</returns>
        public static int GcdEuclidArray(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException("Too few elements in array");
            }

            int gcd = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (!(gcd == 0 && array[i] == 0))
                {
                    gcd = GcdEuclid(gcd, array[i]);
                }
            }

            if (gcd == 0)
            {
                throw new ArgumentException("Gcd not exist if all elements are zero.");
            }

            return gcd;
        }

        /// <summary>
        /// Computes GCD by Stein's algorithm of many int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="array">The array of numbers</param>
        /// <returns>Returns GCD.</returns>
        public static int GcdSteinArray(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException("Too few elements in array");
            }

            int gcd = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (!(gcd == 0 && array[i] == 0))
                {
                    gcd = GcdStein(gcd, array[i]);
                }
            }

            if (gcd == 0)
            {
                throw new ArgumentException("Gcd not exist if all elements are zero.");
            }

            return gcd;
        }

        /// <summary>
        /// Measures computing 100 times GCD of two int numbers, one of them shouldn't be zero. Measure method 1.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>Returns array of computing times in ticks. First element is time of Euclidean, second is time of Stein's.</returns>
        public static long[] MeasureRunningTimeGcd(int a, int b)
        {
            var calcTimes = new long[2];
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdEuclid(a, b);
            }

            watch1.Stop();
            calcTimes[0] = watch1.ElapsedTicks;
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdStein(a, b);
            }

            watch2.Stop();
            calcTimes[1] = watch2.ElapsedTicks;
            return calcTimes;
        }

        /// <summary>
        /// Measures computing 100 times GCD of two int numbers, one of them shouldn't be zero. Measure method 2.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>Returns array of computing times in ticks. First element is time of Euclidean, second is time of Stein's.</returns>
        public static long[] MeasureRunningTimeGcd2(int a, int b)
        {
            var calcTimes = new long[2];
            var startTime1 = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdEuclid(a, b);
            }

            var stopTime1 = DateTime.Now;
            var timeSpan1 = stopTime1 - startTime1;
            calcTimes[0] = timeSpan1.Ticks;
            var startTime2 = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdStein(a, b);
            }

            var stopTime2 = DateTime.Now;
            var timeSpan2 = stopTime2 - startTime2;
            calcTimes[1] = timeSpan2.Ticks;
            return calcTimes;
        }

        /// <summary>
        /// Measures computing 100 times GCD of many int numbers, one of them shouldn't be zero. Measure method 1.
        /// </summary>
        /// <param name="array">The array of numbers</param>
        /// <returns>Returns array of computing times in ticks. First element is time of Euclidean, second is time of Stein's.</returns>
        public static long[] MeasureRunningTimeGcdArray(int[] array)
        {
            var calcTimes = new long[2];
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdEuclidArray(array);
            }

            watch1.Stop();
            calcTimes[0] = watch1.ElapsedTicks;
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdSteinArray(array);
            }

            watch2.Stop();
            calcTimes[1] = watch2.ElapsedTicks;
            return calcTimes;
        }

        /// <summary>
        /// Measures computing 100 times GCD of many int numbers, one of them shouldn't be zero. Measure method 2.
        /// </summary>
        /// <param name="array">The array of numbers</param>
        /// <returns>Returns array of computing times in ticks. First element is time of Euclidean, second is time of Stein's.</returns>
        public static long[] MeasureRunningTimeGcdArray2(int[] array)
        {
            var calcTimes = new long[2];
            var startTime1 = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdEuclidArray(array);
            }

            var stopTime1 = DateTime.Now;
            var timeSpan1 = stopTime1 - startTime1;
            calcTimes[0] = timeSpan1.Ticks;
            var startTime2 = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                var gcd = GcdSteinArray(array);
            }

            var stopTime2 = DateTime.Now;
            var timeSpan2 = stopTime2 - startTime2;
            calcTimes[1] = timeSpan2.Ticks;
            return calcTimes;
        }
    }
}