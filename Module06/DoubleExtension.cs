using System;
using System.Linq;
using System.Text;

namespace Module06
{
    /// <summary>
    /// Task Izh-06-1. Methods in details. 
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Converts double to string as its binary representation.
        /// </summary>
        /// <param name="number">Double to convert.</param>
        /// <returns>Returns string which is 64-length string of bits of this number.</returns>
        public static string ToBinaryString(this double number)
        {
            if (double.IsPositiveInfinity(number))
            {
                return "0111111111110000000000000000000000000000000000000000000000000000";
            }

            if (double.IsNegativeInfinity(number))
            {
                return "1111111111110000000000000000000000000000000000000000000000000000";
            }

            if (double.IsNaN(number))
            {
                return "1111111111111000000000000000000000000000000000000000000000000000";
            }

            if (double.IsPositiveInfinity(number))
            {
                return "0111111111110000000000000000000000000000000000000000000000000000";
            }

            var sign = number < 0 ? "1" : "0";

            double numAbs = Math.Abs(number);
            double exp = Math.Log(numAbs, 2) - 1;

            var exponent = (int) Math.Floor(exp);
            if (exponent < exp)
            {
                exponent++;
            }

            bool flagSubnormal = false;
            if (exponent < -1022)
            {
                exponent = -1022;
                flagSubnormal = true;
            }

            if (exponent > 0)
            {
                for (int i = 0; i < exponent; i++)
                {
                    numAbs = numAbs / 2;
                }
            }
            else
            {
                for (int i = 0; i < -exponent; i++)
                {
                    numAbs *= 2;
                }
            }

            double fractionalPart = numAbs;
            if (!flagSubnormal)
            {
                fractionalPart -= 1;
            }

            var fractionalPartBinarySB = new StringBuilder();
            for (int i = 0; i < 52; i++)
            {
                fractionalPart *= 2;
                var fractionalPartDigit = fractionalPart < 1 ? "0" : "1";
                fractionalPartBinarySB.Append(fractionalPartDigit);
                fractionalPart -= (int) fractionalPart;
            }

            if (number == 0.0 && double.IsNegativeInfinity(1.0 / number))
            {
                sign = "1";
            }

            exponent += 1023;

            var expBinarySB = new StringBuilder();
            if (!flagSubnormal)
            {
                while (exponent > 0)
                {
                    expBinarySB.Append(exponent % 2);
                    exponent = exponent / 2;
                }
            }

            while (expBinarySB.Length != 11)
            {
                expBinarySB.Append("0");
            }

            var expBinary = new string(expBinarySB.ToString().ToCharArray().Reverse().ToArray());

            var fractionSB = new StringBuilder();
            fractionSB.Append(fractionalPartBinarySB);
            if (fractionSB.Length > 52)
            {
                fractionSB.Remove(52, fractionSB.Length - 52);
            }

            return String.Concat(sign, expBinary, fractionSB);
        }
    }
}