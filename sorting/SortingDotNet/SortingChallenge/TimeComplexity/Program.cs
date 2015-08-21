using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            FullInsertionSort(new int[] {2, 1, 3, 1, 2});
        }

        private static int FullInsertionSort(int[] ar)
        {
            int shifts = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (ar[j + 1] >= ar[j]) break;

                    int temp = ar[j];
                    ar[j] = ar[j + 1];
                    ar[j + 1] = temp;
                    shifts++;

                }

            }
            return shifts;
        }
    }
}
