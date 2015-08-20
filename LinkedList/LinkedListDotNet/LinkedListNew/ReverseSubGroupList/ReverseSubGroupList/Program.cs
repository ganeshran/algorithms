using System;
using Common;

namespace ReverseSubGroupList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = LinkedList.GetRandomList(7);
            Console.WriteLine("Got list, printing it");
            list.Print();
            Console.WriteLine("Reversing the list");
            var reverseList = ReverseList(list, 2, 3);
            reverseList.Print();
        }


        public static LinkedList ReverseList(LinkedList list, int index, int numberOfElements)
        {
            var head = list.Head;
            var curr = head;

            //first move to index node
            int iCounter = 0;
            while (iCounter++ != index && curr != null)
                curr = curr.Next;
            

            //Now we are at the index where the list needs to be reversed
            ReverseRecursive(curr, numberOfElements, 1);
            return list;
        }

        private static void ReverseRecursive(Node head, int numberOfElements, int iCounter)
        {
            Node curr = head;
            Node next = head.Next;

            if(iCounter == numberOfElements)
                return;

            ReverseRecursive(next,numberOfElements,++iCounter);
            curr.Next.Next = curr;
            curr.Next = null;
            head = next;
        }

        

    }


}
