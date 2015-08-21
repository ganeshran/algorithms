using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FullInsertionSort(new int[] {1, 4, 3, 5, 6, 2});
        }

        private static void FullInsertionSort(int[] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (ar[j + 1] > ar[j]) break;

                    int temp = ar[j];
                    ar[j] = ar[j + 1];
                    ar[j + 1] = temp;

                }
                PrintArray(ar);
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write("{0} ",i);
            }
            Console.Write("\n");
        }

        private static void HalfInsertionSort(int[] ar)
        {
            int unsorted = ar[ar.Length - 1];
            bool breakNext = false;
            for(int j=ar.Length-1;j >= 0 && !breakNext; j--)
            {
                if (j > 0 && unsorted < ar[j-1] )
                {
                    ar[j] = ar[j - 1];

                }
                else
                {
                    ar[j] = unsorted;
                    breakNext = true;
                }
                for(int i=0;i<ar.Length;i++)
                    Console.Write("{0} ", ar[i]);
                Console.Write("\n");
            }
        }
    }
}
