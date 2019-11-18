using System;
using NUnit.Framework;
using Module04;

namespace Module04Test
{
    [TestFixture]
    public class Task4Test
    {
        [TestCase("AsdfeAd", "Assqaasssqs", ExpectedResult = "AsdfeAdqaaq")]
        [TestCase("Abc", "dfe", ExpectedResult = "Abcdfe")]
        [TestCase("AASS", "AASS", ExpectedResult = "AASS")]
        [TestCase("ABC", "abc", ExpectedResult = "ABCabc")]
        public string CheckStringConcatenation(string firstStr, string secondStr)
        {
            return Task4.ConcatNoRepeats(firstStr, secondStr);
        }
    }
}
