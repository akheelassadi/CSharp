using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class Palindrome
    {
        public static string ReverseGivenString(string input)
        {
            string reversedString = "";
            char[] inputArray = input.ToCharArray();

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                reversedString += inputArray[i];
            }
            return reversedString;
        }

        public static bool IsGivenStringPalindrome(string input)
        {
            string reversedstring = ReverseGivenString(input);
            bool flag = false;

            if (input.Equals(reversedstring))
            {
                flag = true;
                Console.WriteLine($"Given string {input} is a palindrome");
            }

            return flag;
        }
    }
}
