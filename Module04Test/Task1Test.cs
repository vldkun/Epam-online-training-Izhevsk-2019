using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module04;

namespace Module04Test
{
    [TestClass]
    public class Task1Test
    {
        [TestMethod]
        public void InsertNumber_in15insert15from0to0_15returned()
        {
            int num1 = 15;
            int num2 = 15;
            int i = 0;
            int j = 0;

            Assert.AreEqual(15, Task1.InsertNumber(num1, num2, i, j));
        }
        [TestMethod]
        public void InsertNumber_in8insert15from0to0_9returned()
        {
            int num1 = 8;
            int num2 = 15;
            int i = 0;
            int j = 0;

            Assert.AreEqual(9, Task1.InsertNumber(num1, num2, i, j));
        }
        [TestMethod]
        public void InsertNumber_in8insert15from3to8_120returned()
        {
            int num1 = 8;
            int num2 = 15;
            int i = 3;
            int j = 8;

            Assert.AreEqual(120, Task1.InsertNumber(num1, num2, i, j));
        }
    }
}
