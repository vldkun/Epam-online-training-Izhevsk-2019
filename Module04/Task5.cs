using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-5. Basic Coding in C#. 
    /// </summary>
    public class Task5
    {
        /// <summary>
        /// Finding next bigger number that consists of digits of input number
        /// </summary>
        /// <remarks>
        /// First find the rightmost digit that less than his right neighbor
        /// Then take all digits to his right except his right neighbor and make the smallest number
        /// Then combine them to this order: Left digits->his right neighbor->the smallest number->found digit
        /// </remarks>
        /// <param name="x">Positive number</param>
        /// <returns>Returns this number. If it don't exist, returns -1</returns>
        public static int FindNextBiggerNumber(int x)
        {

            int lastNum = x % 10;
            int firstNumbers = x / 10;
            ArrayList lastNumbers = new ArrayList();
            lastNumbers.Add(lastNum);
            while (firstNumbers != 0)
            {
                if (firstNumbers % 10 < lastNum)
                {

                    lastNumbers.RemoveAt(lastNumbers.Count - 1);
                    lastNumbers.Add(firstNumbers % 10);
                    firstNumbers = firstNumbers / 10;
                    lastNumbers.Sort();
                    StringBuilder lastNumbersSB = new StringBuilder();
                    foreach (var number in lastNumbers)
                    {
                        lastNumbersSB.Append(number);
                    }
                    string result = firstNumbers.ToString() + lastNum.ToString() + lastNumbersSB.ToString();
                    return Convert.ToInt32(result);
                }
                lastNum = firstNumbers % 10;
                firstNumbers = firstNumbers / 10;
                lastNumbers.Add(lastNum);
            }

            return -1;
        }
    }
}
