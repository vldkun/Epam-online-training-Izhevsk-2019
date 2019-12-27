using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Module12
{
    /// <summary>
    /// Izh-12-4. Generics and Collections
    /// </summary>
    public class Queue<T>
    {
        private Node<T> _front;
        private Node<T> _back;

        public int Count { get; private set; }

        public Queue()
        {
            _front = null;
            _back = null;
            Count = 0;
        }

        public void Enqueue(T data)
        {
            if (_front == null)
            {
                _back = new Node<T>(data);
                _front = _back;
                Count++;
                return;
            }

            if (_front == _back)
            {
                _back = new Node<T>(data);
                _back.Next = _front;
                _front.Prev = _back;
                Count++;
                return;
            }

            var tempBack = new Node<T>(data);
            tempBack.Next = _back;
            _back.Prev = tempBack;
            _back = tempBack;
            Count++;
        }

        public T Dequeue()
        {
            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var tempData = _front.Data;
            _front = _front.Prev;
            if (_front != null)
            {
                _front.Next = null;
            }

            Count--;
            return tempData;
        }

        public T Peek()
        {
            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return _front.Data;
        }

        /// <summary>
        /// Iteration from end to begin of queue.
        /// </summary>
        /// <returns>Returns each element of queue.</returns>
        public IEnumerator GetEnumerator()
        {
            var iterator = _back;
            for (int i = 0; i < Count; i++)
            {
                yield return iterator.Data;
                iterator = iterator.Next;
            }
        }
    }
}
