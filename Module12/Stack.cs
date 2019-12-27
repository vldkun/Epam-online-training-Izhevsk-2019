using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Module12
{
    /// <summary>
    /// Izh-12-5. Generics and Collections
    /// </summary>
    public class Stack<T>
    {
        private Node<T> _top;

        public int Count { get; private set; }

        public Stack()
        {
            _top = null;
            Count = 0;
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var tempData = _top.Data;
            _top = _top.Prev;
            Count--;
            return tempData;
        }

        public void Push(T data)
        {
            if (_top == null)
            {
                _top = new Node<T>(data);
            }
            else
            {
                var tempNode = new Node<T>(data);
                tempNode.Prev = _top;
                _top = tempNode;
            }

            Count++;
        }

        public T Peek()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _top.Data;
        }

        /// <summary>
        /// Iteration throw stack from top to down.
        /// </summary>
        /// <returns>Returns each element of stack.</returns>
        public IEnumerator GetEnumerator()
        {
            var iterator = _top;
            for (int i = 0; i < Count; i++)
            {
                yield return iterator.Data;
                iterator = iterator.Prev;
            }
        }
    }
}
