using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BST
{
    class BinarySearchTree
    {
        public Node Tree { get; set; }
        public BinarySearchTree(int initData)
        {
            this.Tree = new Node(9);
        }
    }
}
