using System;
using System.Collections;
using System.Collections.Generic;

namespace Module12
{
    /// <summary>
    /// Izh-12-7. Generics and Collections
    /// </summary>
    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        private NodeTree<TKey, TValue> _root;
        public int Count { get; private set; }

        public BinarySearchTree()
        {
            _root = null;
            Count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            if (_root == null)
            {
                _root = new NodeTree<TKey, TValue>(key, value);
                Count++;
                return;
            }

            var current = _root;
            while (true)
            {
                if (key.CompareTo(current.Key) < 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = new NodeTree<TKey, TValue>(key, value);
                        current.Left.Parent = current;
                        Count++;
                        return;
                    }

                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new NodeTree<TKey, TValue>(key, value);
                        current.Right.Parent = current;
                        Count++;
                        return;
                    }

                    current = current.Right;
                }
            }
        }

        public IEnumerable InOrderTraverse()
        {
            foreach (var nodeData in InOrderTraverse(_root))
                yield return nodeData;
        }

        private IEnumerable InOrderTraverse(NodeTree<TKey, TValue> node)
        {
            if (node != null)
            {
                foreach (var nodeData in InOrderTraverse(node.Left))
                {
                    yield return nodeData;
                }

                yield return new TreeData<TKey, TValue>(node.Key, node.Value);
                foreach (var nodeData in InOrderTraverse(node.Right))
                {
                    yield return nodeData;
                }
            }
        }

        public IEnumerable PreOrderTraverse()
        {
            foreach (var nodeData in PreOrderTraverse(_root))
                yield return nodeData;
        }

        private IEnumerable PreOrderTraverse(NodeTree<TKey, TValue> node)
        {
            if (node != null)
            {
                yield return new TreeData<TKey, TValue>(node.Key, node.Value);
                foreach (var nodeData in PreOrderTraverse(node.Left))
                {
                    yield return nodeData;
                }

                foreach (var nodeData in PreOrderTraverse(node.Right))
                {
                    yield return nodeData;
                }
            }
        }

        public IEnumerable PostOrderTraverse()
        {
            foreach (var nodeData in PostOrderTraverse(_root))
                yield return nodeData;
        }

        private IEnumerable PostOrderTraverse(NodeTree<TKey, TValue> node)
        {
            if (node != null)
            {
                foreach (var nodeData in PostOrderTraverse(node.Left))
                {
                    yield return nodeData;
                }

                foreach (var nodeData in PostOrderTraverse(node.Right))
                {
                    yield return nodeData;
                }

                yield return new TreeData<TKey, TValue>(node.Key, node.Value);
            }
        }

        public TValue Find(TKey key)
        {
            var current = _root;
            while (true)
            {
                if (current == null)
                {
                    throw new KeyNotFoundException("No elements in tree with this key.");
                }

                if (key.CompareTo(current.Key) < 0)
                {
                    current = current.Left;
                }

                if (key.CompareTo(current.Key) > 0)
                {
                    current = current.Right;
                }

                if (key.CompareTo(current.Key) == 0)
                {
                    return current.Value;
                }
            }
        }

        public void Remove(TKey key)
        {
            var current = _root;
            while (true)
            {
                if (current == null) return;
                if (key.CompareTo(current.Key) < 0)
                {
                    current = current.Left;
                }

                if (key.CompareTo(current.Key) > 0)
                {
                    current = current.Right;
                }

                if (key.CompareTo(current.Key) == 0)
                {
                    if (current.Left == null && current.Right == null)
                    {
                        if (current.Parent.Left == current)
                        {
                            current.Parent.Left = null;
                        }
                        else
                        {
                            current.Parent.Right = null;
                        }
                    }
                    else
                    {
                        if (current.Left != null && current.Right != null)
                        {
                            if (current.Right.Left == null)
                            {
                                current.Key = current.Right.Key;
                                current.Value = current.Right.Value;
                                current.Right = current.Right.Right;
                                if (current.Right != null)
                                {
                                    current.Right.Parent = current;
                                }
                            }
                            else
                            {
                                current.Key = current.Right.Left.Key;
                                current.Value = current.Right.Left.Value;
                                key = current.Key;
                                current = current.Right;
                                continue;
                            }
                        }
                        else
                        {
                            if (current.Right != null)
                            {
                                current.Right.Parent = current.Parent;
                                if (current.Parent.Left == current)
                                {
                                    current.Parent.Left = current.Right;
                                }
                                else
                                {
                                    current.Parent.Right = current.Right;
                                }
                            }
                            else
                            {
                                current.Left.Parent = current.Parent;
                                if (current.Parent.Left == current)
                                {
                                    current.Parent.Left = current.Left;
                                }
                                else
                                {
                                    current.Parent.Right = current.Left;
                                }
                            }
                        }
                    }

                    return;
                }
            }
        }
    }
}