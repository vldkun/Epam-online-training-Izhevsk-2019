using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    public class Task1
    {
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
