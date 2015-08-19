using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList(int _firstNodeValue)
        {
            this.Head = new Node(_firstNodeValue);
        }

        public void AddToLast(int _newNodeData)
        {
            var temp = this.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = new Node(_newNodeData);
        }

        public static LinkedList GetSortedList()
        {
            var newList =  new LinkedList(2);
            newList.AddToLast(4);
            newList.AddToLast(6);
            newList.AddToLast(9);
            newList.AddToLast(13);
            newList.AddToLast(16);
            return newList;
        }

        public static LinkedList GetRandomList(int length, int min = 1, int max = 100)
        {
            var random = new Random();
            var newList = new LinkedList(random.Next(min,max));
            for (int i = 0; i < length - 1; i++)
            {
                Thread.Sleep(10); // To get random values
                newList.AddToLast(random.Next(min,max));
            }
            return newList;

        }

        public void Print()
        {
            var temp = this.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
}

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int _data)
        {
            this.Data = _data;
        }
    }
}
