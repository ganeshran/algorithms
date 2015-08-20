using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramReplacements
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int Replacements(string input)
        {

            if (input.Length%2 != 0)
                return -1;
            var arr1 = new int[26];
            var arr2 = new int[26];

            for (int i = 0, j = input.Length - 1; i < input.Length/2; i++,j--)
            {
                arr1[(int) input[i] - 97]++;
                arr2[(int) input[j] - 97]++;
            }
            var repl = 0;
            for (int i = 0; i < 26; i++)
            {
                arr1[i] = Math.Abs(arr1[i] - arr2[i]);
                repl += arr1[i];
            }
            return repl/2;

        }
    }
}
