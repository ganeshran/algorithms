using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MakeItAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "cbdijjl";
            var str2 = "jlaefis";
            Console.WriteLine(NumberOfDeletions(str1,str2));
        }

        static int NumberOfDeletions(string str1, string str2)
        {
            var dict1 = new int[26];
            var dict2 = new int[26];
            for (int i = 0; i < str1.Length; i++)
                dict1[(int) str1[i] - 97]++;

            for (int i = 0; i < str2.Length; i++)
                dict2[(int) str2[i] - 97]++;

            int deletions = 0;

            for (int i = 0; i < 26; i++)
            {
                deletions += Math.Abs(dict1[i] - dict2[i]);
            }

            return deletions;

        }


    }
}
