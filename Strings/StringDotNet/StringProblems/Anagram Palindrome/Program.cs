using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagramPalindrome(Console.ReadLine()) ? "YES" : "NO");
        }

        static bool IsAnagramPalindrome(string input)
        {
           var dict = new Dictionary<char,int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                    dict.Remove(input[i]);
                else
                    dict.Add(input[i],1);
            }
            return input.Length%2 == 0 ? dict.Count == 0 : dict.Count == 1;
        }
    }
}
