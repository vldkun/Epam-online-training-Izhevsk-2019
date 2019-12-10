using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task6Test
    {
        [TestCase("24","17", ExpectedResult = "41")]
        [TestCase("-24", "-17", ExpectedResult = "-41")]
        [TestCase("-323", "-116", ExpectedResult = "-439")]
        [TestCase("-24", "17", ExpectedResult = "-7")]
        [TestCase("24", "-17", ExpectedResult = "7")]
        [TestCase("999", "1", ExpectedResult = "1000")]
        [TestCase("2423", "0", ExpectedResult = "2423")]
        [TestCase("1000", "-1", ExpectedResult = "999")]
        [TestCase("0", "0", ExpectedResult = "0")]
        [TestCase("-994541", "994541", ExpectedResult = "0")]
        public string TestSumOfBigNumbers(string num1, string num2)
        {
            return Task6.SumOfBigNumbers(num1, num2);
        }

        [TestCase("-10", 3, ExpectedResult = "990")]
        [TestCase("-1", 4, ExpectedResult = "9999")]
        [TestCase("-12", 4, ExpectedResult = "9988")]
        [TestCase("-9988", 4, ExpectedResult = "12")]
        public string TestComplement(string num, int len)
        {
            return Task6.Complement(num, len);
        }
    }
}
