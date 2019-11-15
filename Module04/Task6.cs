using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task6
    {
        public static int[] FilterDigit(int[] array, int filterNumber)
        {
            ArrayList filteredArray = new ArrayList();
            foreach (var elem in array)
            {
                if (Convert.ToString(elem).Contains(filterNumber.ToString()))
                {
                    filteredArray.Add(elem);
                }
            }

            int[] resultArray = (int[])filteredArray.ToArray(typeof(int));
            return resultArray;
        }
    }
}
