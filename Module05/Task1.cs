using System;

namespace Module05
{
    /// <summary>
    /// Task Izh-05-1. Creating types in C#. 
    /// </summary>
    public class Task1
    {
        /// <summary>
        /// Finding Nth root using Newton's method
        /// with defined precision.
        /// </summary>
        /// <param name="number">The number to find root.</param>
        /// <param name="degree">The degree of root.</param>
        /// <param name="precision">The precision of calculation.</param>
        /// <returns>Returns calculated root.</returns>
        public static double FindNthRoot(double number, int degree, double precision)
        {
            if (degree <= 0 || ((number < 0) && (degree % 2 == 0)) || !(precision > 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            double xK = number;
            double xKNext = (degree + number - 1) / degree;
            while (!(Math.Abs(xK - xKNext) < precision / 2.0))
            {
                xK = xKNext;
                xKNext = ((degree - 1) * xK + number / Math.Pow(xK, degree - 1)) / degree;
            }

            int accuracy = 0;
            double _precision = precision;
            while (_precision < 1)
            {
                accuracy++;
                _precision *= 10;
            }

            return Math.Round(xKNext, accuracy);
        }
    }
}
