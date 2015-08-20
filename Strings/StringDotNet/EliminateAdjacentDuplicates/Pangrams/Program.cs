using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("We promptly judged antique ivory buckles for the next prize") ? "pangram" : "not pangram");
            Console.WriteLine(IsPangram("We promptly judged antique ivory buckles for the prize ") ? "pangram" : "not pangram");
        }

        static bool IsPangram(string input)
        {
            var dict = new Dictionary<char, int>();
            foreach (var ch in input.ToUpper())
                if (Char.IsLetter(ch) && !dict.ContainsKey(ch))
                    dict.Add(ch,1);
            return dict.Keys.Count == 26;
        }
    }
}
