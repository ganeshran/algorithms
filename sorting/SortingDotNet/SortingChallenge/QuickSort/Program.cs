using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine(String.Join(" ", QuickSort(new int[] {2, 10, 3, 7, 9, 4, 6, 12, 8})));
            Console.WriteLine(String.Join(" ", QuickSort(new int[] {4, 5, 3, 7, 2})));
        }

        public static int[] QuickSort(int[] ar)
        {
            int pivot = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if(ar[i] >= pivot) continue;
                for (int j = i; j > 0; j--)
                {
                    int temp = ar[j];
                    ar[j] = ar[j - 1];
                    ar[j-1] = temp;
                }
            }
            return ar;
        }

        public static int[] QuickSortWrong(int[] ar)
        {
            //Swap pivot to center of array
            int pivot = ar[0];
            ar[0] = ar[ar.Length/2];
            ar[ar.Length/2] = pivot;

            for (int i = 0, j = ar.Length - 1; i < ar.Length/2 +1 && j > ar.Length/2 +1;)
            {
                if (ar[i] > pivot && ar[j] < pivot)
                {
                    int temp = ar[j];
                    ar[j] = ar[i];
                    ar[i] = temp;
                    i++;
                    j--;
                }
                else if (ar[i] < pivot)
                    i++;
                else if (ar[j] > pivot)
                    j--;
                else
                {
                    i++;
                    j--;
                }
                
            }
            return ar;

        }
    }
}
