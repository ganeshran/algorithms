using System;
using Common;

namespace ReverseSubGroupList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = LinkedList.GetRandomList(14);
            Console.WriteLine("Got list, printing it");
            list.Print();
            Console.WriteLine("Reversing the list");
            var reverseList = ReverseList(list, 3, 5);
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

            return list;
        }

    }


}
