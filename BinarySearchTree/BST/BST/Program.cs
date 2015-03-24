using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = PopulateNode();
            TraverseTree(root);
            var reverse = ReverseBinaryTree(root);
            Console.WriteLine("reversing");
            TraverseTree(root);
        }

        static Node ReverseBinaryTree(Node root)
        {
            if(root == null)
                return null;

            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;

            ReverseBinaryTree(root.Left);
            ReverseBinaryTree(root.Right);
            return root;
        }
        
        static void TraverseTree(Node root)
        {
            if(root == null)
                return;
            TraverseTree(root.Left);
            Console.WriteLine(root.Data);
            TraverseTree(root.Right);
        }



        private static Node PopulateNode()
        {
            Node root = new Node(4);
            root.Left = new Node(2);
            root.Right = new Node(7);
            root.Left.Left = new Node(1);
            root.Left.Right = new Node(3);
            root.Right.Right = new Node(10);
            root.Right.Left = new Node(5);
            root.Right.Right.Left = new Node(6);
            root.Right.Right.Right = new Node(12);
            root.Right.Left.Right = new Node(10);
            return root;
        }
    }
}
