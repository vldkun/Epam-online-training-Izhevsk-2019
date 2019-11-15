using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task3
    {
        private const double Eps = 0.00001;
        public static int FindIndex(double[] array)
        {
            if (array.Length < 3)
            {
                return -1;
            }

            double leftSum = array[0];
            double rightSum = 0;
            for (int i = 2; i < array.Length; i++)
            {
                rightSum += array[i];
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (Math.Abs(rightSum - leftSum) < Eps)
                {
                    return i;
                }

                leftSum += array[i];
                rightSum -= array[i + 1];
            }

            return -1;
        }
    }
}
