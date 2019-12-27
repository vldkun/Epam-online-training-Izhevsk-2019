
using System;
using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class SetTest
    {
        [Test]
        public void AddToSetTest()
        {
            var set = new Set<int>();
            set.Add(301);
            set.Add(2341);
            set.Add(-16);
            set.Add(0);
            set.Add(2341);
            set.Add(0);
            var expectedSet = new int[] {0, -16, 2341, 301};

            Assert.AreEqual(expectedSet.Length, set.Count);
            var i = 0;
            foreach (int elem in set)
            {
                Assert.IsTrue(Array.IndexOf(expectedSet, elem) >= 0);
                i++;
            }
        }

        [Test]
        public void RemoveFromSetTest()
        {
            var set = new Set<int>();
            set.Add(301);
            set.Add(2341);
            set.Add(-16);
            set.Add(0);
            set.Remove(2341);
            set.Remove(10);
            set.Add(13);
            var expectedSet = new int[] {0, -16, 301, 13};

            Assert.AreEqual(expectedSet.Length, set.Count);
            var i = 0;
            foreach (int elem in set)
            {
                Assert.IsTrue(Array.IndexOf(expectedSet, elem) >= 0);
                i++;
            }
        }
    }
}