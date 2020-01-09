using System;

namespace Module11
{
    /// <summary>
    /// Task Izh-11-1. Methods in details. 
    /// </summary>
    public class Gcd
    {
        private delegate int GcdMethod(int a, int b);
        private delegate int GcdArrayMethod(int[] array);

        public enum GcdMethods
        {
            Euclid = 0,
            Stein
        }

        /// <summary>
        /// Computes GCD of two int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="gcd">Euclidean or Stein algorithm.</param>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>Returns GCD.</returns>
        public static int ComputeGcd(GcdMethods gcd, int a, int b)
        {
            GcdMethod method;
            if (gcd == GcdMethods.Stein)
            {
                method = GcdStein;
            }
            else
            {
                method = GcdEuclid;
            }

            return method(a,b);
        }

        /// <summary>
        /// Computes GCD of many int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="gcd">Euclidean or Stein algorithm.</param>
        /// <param name="array">The array of numbers.</param>
        /// <returns>Returns GCD.</returns>
        public static int ComputeGcd(GcdMethods gcd, int[] array)
        {
            GcdArrayMethod method;
            if (gcd == GcdMethods.Stein)
            {
                method = GcdStein;
            }
            else
            {
                method = GcdEuclid;
            }

            return method(array);
        }

        /// <summary>
        /// Computes GCD by Euclidean algorithm of two int numbers, one of them shouldn't be zero.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>Returns GCD.</returns>
        private static int GcdEuclid(int a, int b)
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
        private static int GcdStein(int a, int b)
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
        private static int GcdEuclid(int[] array)
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
        private static int GcdStein(int[] array)
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
    }
}