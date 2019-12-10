using System;
using System.Collections;
using System.Text;

namespace Module09
{
    /// <summary>
    /// Izh-09-6. Framework Fundamentals
    /// </summary>
    public class Task6
    {
        /// <summary>
        /// Computing 9-th complement of a number.
        /// </summary>
        /// <param name="num">Number to find complement.</param>
        /// <param name="length">Number of digits in complement</param>
        /// <returns>Returns string - 9-th complement.</returns>
        public static string Complement(string num, int length)
        {
            if (length < num.Length - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            var compStr = new StringBuilder();
            compStr.Append('9', length - num.Length + 1);
            for (int i = 1; i < num.Length; i++)
            {
                compStr.Append(9 - (int) char.GetNumericValue(num[i]));
            }

            var resultSb = new StringBuilder();
            var carry = 1;
            var index = length - 1;
            while (index >= 0)
            {
                var sum = (int) char.GetNumericValue(compStr[index]) + carry;
                carry = sum / 10;
                resultSb.Insert(0, sum % 10);
                index--;
            }

            while (resultSb.Length > 1 && resultSb[0] == '0')
            {
                resultSb.Remove(0, 1);
            }
            return resultSb.ToString();
        }
        /// <summary>
        /// Calculating sum of big numbers.
        /// </summary>
        /// <param name="num1">First number in string.</param>
        /// <param name="num2">Second number in string.</param>
        /// <returns>Returns string - sum of two numbers.</returns>
        public static string SumOfBigNumbers(string num1, string num2)
        {
            var result = new ArrayList();
            var sign1 = 1;
            var sign2 = 1;
            
            var length = Math.Max(num1.Length, num2.Length);
            if (num1[0] == '-')
            {
                sign1 = -1;
                num1 = Complement(num1, length);
            }

            if (num2[0] == '-')
            {
                sign2 = -1;
                num2 = Complement(num2, length);
            }

            var index1 = num1.Length - 1;
            var index2 = num2.Length - 1;
            var carry = 0;
            while (index1 >= 0 && index2 >= 0)
            {
                var sum = (int) char.GetNumericValue(num1[index1]) + (int) char.GetNumericValue(num2[index2]) + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
                index1--;
                index2--;
            }

            while (index1 >= 0)
            {
                var sum = (int) char.GetNumericValue(num1[index1]) + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
                index1--;
            }

            while (index2 >= 0)
            {
                var sum = (int) char.GetNumericValue(num2[index2]) + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
                index2--;
            }

            if (carry != 0)
            {
                result.Insert(0, carry);
            }

            var resultSb = new StringBuilder();
            foreach (var ch in result)
            {
                resultSb.Append(ch);
            }

            if (sign1 == -1 || sign2 == -1)
            {
                if ((int) char.GetNumericValue(resultSb[0]) == 1)
                {
                    resultSb.Remove(0, 1);
                    if (sign1 == -1 && sign2 == -1)
                    {
                        var resultStr = Complement(resultSb.ToString(), resultSb.Length - 1);
                        return "-" + resultStr;
                    }
                }
                else
                {
                    resultSb.Insert(0, "-");
                    var resultStr = Complement(resultSb.ToString(),resultSb.Length - 1);
                    return "-" + resultStr;
                }
            }

            while (resultSb.Length > 1 && resultSb[0] == '0')
            {
                resultSb.Remove(0, 1);
            }
            return resultSb.ToString();
        }
    }
}
