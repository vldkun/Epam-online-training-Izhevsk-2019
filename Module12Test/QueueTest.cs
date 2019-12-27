using System.Text;
using NUnit.Framework;
using Module12;
using System;

namespace Module12Test
{
    [TestFixture]
    public class QueueTest
    {
        [Test]
        public void EnqueueTest()
        {
            var queue = new Queue<int>();
            queue.Enqueue(301);
            queue.Enqueue(2341);
            queue.Enqueue(-16);
            queue.Enqueue(0);

            var queueStr = new StringBuilder();
            foreach (var elem in queue)
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
        public void DequeueTest()
        {
            var queue = new Queue<string>();
            queue.Enqueue("aca");
            queue.Enqueue("aba");
            queue.Enqueue("mn2");
            queue.Enqueue("ndf");
            queue.Enqueue("sqe");
            queue.Enqueue("abav");
            queue.Dequeue();
            queue.Dequeue();

            var queueStr = new StringBuilder();
            foreach (var elem in queue)
            {
                queueStr.Append(elem + " ");
            }

            if (queueStr[queueStr.Length - 1] == ' ')
            {
                queueStr.Remove(queueStr.Length - 1, 1);
            }

            Assert.AreEqual("abav sqe ndf mn2", queueStr.ToString());
        }

        [Test]
        public void RemoveFromEmptyQueueTest()
        {
            var queue = new Queue<string>();
            Assert.Throws<InvalidOperationException>(
                () => queue.Dequeue());
        }
    }
}
