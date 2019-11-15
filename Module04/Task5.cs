using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task5
    {
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
