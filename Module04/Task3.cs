using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task3
    {
        private const double Eps = 0.001;
        public int FindIndex(double[] a)
        {
            if (a.Length < 3)
                return -1;

            double leftSum = a[0], rightSum = 0;
            for (int i = 2; i < a.Length; i++)
            {
                rightSum += a[i];
            }
            for (int i = 2; i < a.Length - 1; i++)
            {
                if (Math.Abs(rightSum - leftSum) < Eps)
                    return i;
                leftSum += a[i];
                rightSum -= a[i + 1];
            }

            return -1;
        }
    }
}
