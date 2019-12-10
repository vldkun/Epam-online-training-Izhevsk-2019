using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task2Test
    {
        [TestCase("a clash of KINGS", "a an the of", ExpectedResult = "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", ExpectedResult = "The Wind in the Willows")]
        [TestCase("the quick brown fox", ExpectedResult = "The Quick Brown Fox")]
        public string TestTitleCase(string str, string exceptionalList = "")
        {
            return Task2.TitleCase(str,exceptionalList);
        }
    }
}