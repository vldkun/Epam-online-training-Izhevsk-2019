using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task3Test
    {
        [TestCase("www.example.com", "key=value", ExpectedResult = "www.example.com?key=value")]
        [TestCase("www.example.com?key=value", "key2=value2", ExpectedResult = "www.example.com?key=value&key2=value2")]
        [TestCase("www.example.com?key=oldValue", "key=newValue", ExpectedResult = "www.example.com?key=newValue")]
        [TestCase("www.example.com#top", "key=value", ExpectedResult = "www.example.com?key=value#top")]
        [TestCase("www.example.com?key=value#top", "key2=value2", ExpectedResult = "www.example.com?key=value&key2=value2#top")]
        [TestCase("www.example.com?key=oldValue#top", "key=newValue", ExpectedResult = "www.example.com?key=newValue#top")]

        public string TestAddOrChangeUrlParameter(string url, string keyValueParameter)
        {
            return Task3.AddOrChangeUrlParameter(url, keyValueParameter);
        }
    }
}