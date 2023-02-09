using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class ReverseString
    {
        public static void ReverseGivenString(string input)
        {
            char[] inputArray = input.ToCharArray();

            for (int i = inputArray.Length-1; i >= 0; i--)
            {
                Console.Write(inputArray[i]);
            }
        }
    }
}
