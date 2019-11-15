using System;
using NUnit.Framework;
using Module04;

namespace Module04Test
{
    [TestFixture]
    public class Task4Test
    {
        [TestCase("AsdfeAd", "Assqaasssqs", ExpectedResult = "AsdfeAdqaaq")]
        public string CheckStringConcatenation(string firstStr, string secondStr)
        {
            return Task4.ConcatNoRepeats(firstStr, secondStr);
        }
    }
}
