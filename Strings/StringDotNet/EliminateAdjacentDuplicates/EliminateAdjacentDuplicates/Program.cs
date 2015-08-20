using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliminateAdjacentDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInput(new string[]{"ABBC","ACBBC","ABBBCDDC","A","ABC"}); 

        }

        public static void TestInput(IEnumerable<string> inputArray)
        {
            var rem = new RemoveDuplicates();
            foreach (var input in inputArray)
            {
                Console.WriteLine("Input: {0}, Output: {1}",input,rem.RemoveUsingStack(input));
            }
        }

      
    }


    internal class RemoveDuplicates
    {
        public string RemoveUsingStack(string input)
        {
            // Stack is useless for this solution because too many string manipulation
            var stack = new Stack<char>();
            var builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {

                if (stack.Count == 0 || stack.Peek() != input[i])
                    stack.Push(input[i]);
                else
                {
                    stack.Pop();
                }
            }

            while (stack.Count > 0)
            {
                builder.Append(stack.Pop());
            }
            //VERY POOR CODE.
            var charArray = builder.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveIteratively(string input)
        {
            int i = 0,j = 0;

            return input;
        }
    }
}
