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
            HalfInsertionSort(new int[]{2,3,4,5,6,7,8,9,10,1});
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
