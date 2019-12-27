using System;
using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class BinarySearchTreeTest
    {
        [Test]
        public void AddToTreeAndFindTest()
        {
            var dataArray = new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13};
            var tree = new BinarySearchTree<int, int>();
            foreach (var data in dataArray)
            {
                tree.Add(data, data);
            }

            Assert.AreEqual(dataArray.Length, tree.Count);
            Assert.IsTrue(Array.TrueForAll(dataArray, e => e == tree.Find(e)));
        }

        [Test]
        public void InOrderTraverseTest()
        {
            var dataArray = new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13};
            var expectedOrder = new int[] {1, 3, 4, 6, 7, 8, 10, 13, 14};
            var tree = new BinarySearchTree<int, int>();
            foreach (var data in dataArray)
            {
                tree.Add(data, data);
            }

            var i = 0;
            foreach (TreeData<int, int> data in tree.InOrderTraverse())
            {
                Assert.AreEqual(expectedOrder[i], data.Value);
                i++;
            }
        }

        [Test]
        public void PreOrderTraverseTest()
        {
            var dataArray = new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13};
            var expectedOrder = new int[] {8, 3, 1, 6, 4, 7, 10, 14, 13};
            var tree = new BinarySearchTree<int, int>();
            foreach (var data in dataArray)
            {
                tree.Add(data, data);
            }

            var i = 0;
            foreach (TreeData<int, int> data in tree.PreOrderTraverse())
            {
                Assert.AreEqual(expectedOrder[i], data.Value);
                i++;
            }
        }

        [Test]
        public void PostOrderTraverseTest()
        {
            var dataArray = new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13};
            var expectedOrder = new int[] {1, 4, 7, 6, 3, 13, 14, 10, 8};
            var tree = new BinarySearchTree<int, int>();
            foreach (var data in dataArray)
            {
                tree.Add(data, data);
            }

            var i = 0;
            foreach (TreeData<int, int> data in tree.PostOrderTraverse())
            {
                Assert.AreEqual(expectedOrder[i], data.Value);
                i++;
            }
        }

        [TestCase(13, new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13}, ExpectedResult = new int[] {1, 4, 7, 6, 3, 14, 10, 8})]
        [TestCase(14, new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13}, ExpectedResult = new int[] {1, 4, 7, 6, 3, 13, 10, 8})]
        [TestCase(3, new int[] {8, 10, 3, 6, 1, 4, 7, 14, 13}, ExpectedResult = new int[] {1, 7, 6, 4, 13, 14, 10, 8})]
        public int[] RemoveFromTreeTest(int key, int[] dataArray)
        {
            var tree = new BinarySearchTree<int, int>();
            foreach (var data in dataArray)
            {
                tree.Add(data, data);
            }
            tree.Remove(key);
            var expectedOrder = new int[tree.Count - 1];
            var i = 0;
            foreach (TreeData<int, int> data in tree.PostOrderTraverse())
            {
                expectedOrder[i] = data.Value;
                i++;
            }

            return expectedOrder;
        }
    }
}
