using System;
using System.Linq.Expressions;

namespace MakeItBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(MakeItBigger("b"));
        }

        private static string MakeItBigger(string inputString)
        {
            var input = inputString.ToCharArray();
            //identify longest non increasing suffix

            int start_index = input.Length - 1;
            int length = 0;

            for (int j = input.Length - 1; j > 0; j--)
            {
                length++;
                if (input[j] > input[j - 1])
                    break;
                start_index = j-1;
            }

            if (start_index == 0 || input.Length == 1)
                return "no answer";

            if (length == 1)
            {
                char temp = input[input.Length - 2];
                input[input.Length - 2] = input[input.Length - 1];
                input[input.Length - 1] = temp;
                return new string(input);
            }

            //Identify pivot element
            int pivot = start_index - 1;

            //finding rightmost successor 
            // and swap with pivot
            for (int i = start_index; i < start_index + length; i++)
            {
                if (input[pivot] <= input[i]) continue;
                char temp = input[pivot];
                input[pivot] = input[i - 1];
                input[i - 1] = temp;
            }

            //Reverse the suffix

            for (int i = start_index,j=input.Length-1; i <= start_index + length/2; i++,j--)
            {
                char temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }


            return new string(input);
        }
    }
}
