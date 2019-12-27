using System.Collections.Generic;
using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class Task2Test
    {
        [Test]
        public void CountFrequencyOfOccurrencesTest()
        {
            var text =
                "The test file contains 1 information. The text is test 1. Test 1 is information, in text file 1.";
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("the",2);
            dictionary.Add("test", 3);
            dictionary.Add("contains", 1);
            dictionary.Add("1", 4);
            dictionary.Add("information", 2);
            dictionary.Add("file", 2);
            dictionary.Add("text", 2);
            dictionary.Add("is", 2);
            dictionary.Add("in", 1);

            Assert.AreEqual(dictionary,Task2.CountFrequencyOfOccurrences(text));

        }
    }
}
