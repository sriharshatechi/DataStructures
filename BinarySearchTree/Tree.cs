using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Tree
    {
        private Node Root;
        public Node GetRoot()
        {
            return Root;
        }
        public Node InsertNode(int value)
        {
            Node toBeInserted = new Node(value);

            if(Root == null)
            {

                Root = toBeInserted;
                return Root;
            }
            Node temp = Root;
            while (!FoundRightSlot(value, temp))
            {
                if (value < temp.data)
                {
                    temp = temp.LeftChild;
                }
                else
                {
                    temp = temp.RightChild;
                }
            } 
            if (temp.data > value)
            {
                temp.LeftChild = toBeInserted;
            }
            else
            {
                temp.RightChild = toBeInserted;
            }
            return Root;
        }
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.LeftChild);
                Console.WriteLine(root.data);
                InOrder(root.RightChild);
            }
        }
        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrder(root.LeftChild);               
                PreOrder(root.RightChild);
            }
        }
        public void PostOrder(Node root)
        {
            if (root != null)
            {
               
                PostOrder(root.LeftChild);
                PostOrder(root.RightChild);
                Console.WriteLine(root.data);
            }
        }
        private bool FoundRightSlot(int value, Node temp)
        {
           if(value<temp.data&&temp.LeftChild== null)
            {
                return true;
            }
            else if(value>temp.data && temp.RightChild == null)
            {
                return true;
            }
            else if(temp.RightChild == null && temp.LeftChild == null)
            {
                return true;
            }
            return false;
        }
    }
}
