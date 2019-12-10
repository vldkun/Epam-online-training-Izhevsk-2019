using System;
using System.Collections.Generic;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task4Test
    {
        [TestCase("AAAABBBCCDAABBB", ExpectedResult = "ABCDAB")]
        [TestCase("ABBCcAD", ExpectedResult = "ABCcAD")]
        [TestCase("12233", ExpectedResult = "123")]
        public string TestUniqueInOrderString(string str)
        {
            return Task4.UniqueInOrder(str);
        }
        private static object[][] TestCases = new[]
        {
            new object[]
            {
                new List<double>() {1.1, 2.2, 2.2, 3.3},
                new List<double>() {1.1, 2.2, 3.3}
            },
            new object[]
            {
                new List<int>() {2,4,4,2,1,1,1},
                new List<int>() {2,4,2,1}
            }
        };

        [TestCaseSource("TestCases")]
        public void TestUniqueInOrderList<T>(List<T> list, List<T> expectedList)
        {
            Assert.AreEqual(Task4.UniqueInOrder(list),expectedList);
        }
    }
}