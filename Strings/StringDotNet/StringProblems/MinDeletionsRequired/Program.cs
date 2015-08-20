using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDeletionsRequired
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinDeletionsRequired("AAABBB"));
        }


        static int MinDeletionsRequired(string input)
        {
            int deletions = 0;
            var stack = new Stack<char>();
            stack.Push(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (stack.Count > 0 && stack.Peek() == input[i])
                    deletions++;
                else
                    stack.Push(input[i]);
            }

            return deletions;
        }
    }
}
