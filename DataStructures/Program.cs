using BinarySearchTree;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree tree = new Tree();
            tree.InsertNode(10);
            tree.InsertNode(5);
            tree.InsertNode(15);
            var root = tree.InsertNode(2);
            root = tree.InsertNode(100);
            root = tree.InsertNode(1);
         
            tree.InOrder(tree.GetRoot());
            Console.WriteLine("PreOrder");
            tree.PreOrder(tree.GetRoot());
            Console.WriteLine("PostOrder");
            tree.PostOrder(tree.GetRoot());
        }
    }
}
