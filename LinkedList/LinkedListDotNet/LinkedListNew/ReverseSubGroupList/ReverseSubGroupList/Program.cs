using Common;

namespace ReverseSubGroupList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseList(LinkedList.GetRandomList(14));
        }


        public static void ReverseList(LinkedList list)
        {
            list.Print();
        }

    }


}
