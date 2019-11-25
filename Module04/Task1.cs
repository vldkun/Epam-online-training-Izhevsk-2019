using System;

namespace Module04
{
    /// <summary>
    /// Task Izh-04-1. Basic Coding in C#. 
    /// </summary>
    public class Task1
    {
        /// <summary>
        /// Inserts (j - i + 1) right bits from the second number
        /// to bit positions from i to j in the first number. 
        /// </summary>
        /// <param name="num1">The first number.</param>
        /// <param name="num2">The second number.</param>
        /// <param name="i">The first insertion position.</param>
        /// <param name="j">The first last position.</param>
        /// <returns>Returns result number.</returns>
        public static int InsertNumber(int num1, int num2, int i, int j)
        {
            uint mask = 0;
            mask = ~mask;
            mask = mask >> i << i;
            mask = mask << (31 - j) >> (31 - j);
            
            return (num1 & (int)(~mask)) | (int)mask & (num2 << i);
        }
    }
}
