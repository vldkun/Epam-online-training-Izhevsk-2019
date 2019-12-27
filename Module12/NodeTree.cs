namespace Module12
{
    public class NodeTree<TKey,TValue>
    {
        public NodeTree(TKey key, TValue value)
        {
            Parent = null;
            Right = null;
            Left = null;
            Key = key;
            Value = value;
        }

        public NodeTree<TKey, TValue> Right { get; set; }
        public NodeTree<TKey,TValue> Left { get; set; }
        public NodeTree<TKey, TValue> Parent { get; set; }
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
