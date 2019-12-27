using System;
using System.Text;
using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void PushTest()
        {
            var stack = new Stack<int>();
            stack.Push(301);
            stack.Push(2341);
            stack.Push(-16);
            stack.Push(0);

            var queueStr = new StringBuilder();
            foreach (var elem in stack)
            {
                queueStr.Append(elem + " ");
            }

            if (queueStr[queueStr.Length - 1] == ' ')
            {
                queueStr.Remove(queueStr.Length - 1, 1);
            }

            Assert.AreEqual("0 -16 2341 301", queueStr.ToString());
        }

        [Test]
        public void PopTest()
        {
            var stack = new Stack<string>();
            stack.Push("aca");
            stack.Push("aba");
            stack.Push("mn2");
            stack.Push("ndf");
            stack.Push("sqe");
            stack.Push("abav");
            stack.Pop();
            stack.Pop();

            var queueStr = new StringBuilder();
            foreach (var elem in stack)
            {
                queueStr.Append(elem + " ");
            }

            if (queueStr[queueStr.Length - 1] == ' ')
            {
                queueStr.Remove(queueStr.Length - 1, 1);
            }

            Assert.AreEqual("ndf mn2 aba aca", queueStr.ToString());
        }

        [Test]
        public void RemoveFromEmptyStackTest()
        {
            var stack = new Stack<string>();
            Assert.Throws<InvalidOperationException>(
                () => stack.Pop());
        }
    }
}