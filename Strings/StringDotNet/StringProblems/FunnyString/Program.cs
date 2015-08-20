using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfCases = int.Parse(Console.ReadLine());
        for(int i = 0;i<numberOfCases;i++)
            Console.WriteLine(CheckIfFunny(Console.ReadLine()) ? "Funny" : "Not Funny");
    }
    
     static bool CheckIfFunny(string input)
        {
            for (int i = 0; i < input.Length -1 ; i++)
            {
                int j = input.Length - i - 1;
                if (Math.Abs(((int) input[i]) - ((int) input[i + 1])) != Math.Abs(((int) input[j]) - (int) input[j - 1]))
                    return false;
            }
            return true;
        }
    
    
}

    