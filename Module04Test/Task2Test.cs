using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module04;

namespace Module04Test
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void FindMaxElem_inArray1_9returned()
        {
            int[] array1 = new[] {1, 4, 3, 9, -2, -23, 5, 3, 4, 5, 5, -12, 3, 9, -123};
            int leftIndex = 0;
            int rightIndex = array1.Length - 1;

            Assert.AreEqual(9, Task2.FindMaxElem(array1, leftIndex, rightIndex));
        }

        [TestMethod]
        public void FindMaxElem_inArray2_1returned()
        {
            int[] array2 = new[] {1};
            int leftIndex = 0;
            int rightIndex = array2.Length - 1;

            Assert.AreEqual(1, Task2.FindMaxElem(array2, leftIndex, rightIndex));
        }
    }
}
