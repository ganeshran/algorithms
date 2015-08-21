using System;

namespace SortingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ');

            for (int i = 0; i < length; i++)
            {
                if (int.Parse(arr[i]) == value)
                {
                    Console.WriteLine(i);
                    break;
                }

            }
        }
    }
}
