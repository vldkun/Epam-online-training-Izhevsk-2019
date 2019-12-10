using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task5Test
    {
        [TestCase("The greatest victory is that which requires no battle", ExpectedResult = "battle no requires which that is victory greatest The")]
        
        public string TestReverseString(string str)
        {
            return Task5.ReverseString(str);
        }
    }
}