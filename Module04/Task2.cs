using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task2
    {
        public static int FindMaxElem(int[] a, int leftIndex, int rightIndex)
        {
            if (rightIndex - leftIndex < 2)
                return Math.Max(a[leftIndex], a[rightIndex]);
            int medIndex = (leftIndex + rightIndex) / 2;
            return Math.Max(FindMaxElem(a, leftIndex, medIndex), FindMaxElem(a, medIndex, rightIndex));
        }
    }
}
