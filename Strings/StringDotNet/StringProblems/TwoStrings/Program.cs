using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoStrings("hello","world"));
        }

        static bool TwoStrings(string str1, string str2)
        {
            int[] arr1 = new int[26];

            for (int i = 0; i < str1.Length; i++)
            {
                arr1[(int) str1[i] - 97] = 1;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (arr1[(int) str2[i] - 97] == 1)
                    return true;
            }
            return false;
        }
    }
}
