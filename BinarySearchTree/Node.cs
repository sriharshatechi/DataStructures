using System;

namespace BinarySearchTree
{
    public class Node
    {
        public readonly int data;
        Node Left;
        Node Right;
        public Node(int dataToBeStored)
        {
            data = dataToBeStored;
        }
        public Node RightChild { get => Right; set => Right = value; }
        public Node LeftChild { get => Left; set => Left = value; }
    }
}
