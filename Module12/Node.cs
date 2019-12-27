namespace Module12
{
    internal class Node<T>
    {
        public Node(T data)
        {
            Next = null;
            Prev = null;
            Data = data;
        }

        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public T Data { get; set; }
    }
}
