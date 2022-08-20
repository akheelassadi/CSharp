using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class FibonacciSeries
    {
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static void DisplayFibonacci(int number)
        {
            int next = 0;
            int prev = 0;
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(next);
                if (next == 0)
                {
                    next = 1;
                }
                else
                {
                    int temp = next;
                    next = next + prev;
                    prev = temp;
                }
            }
        }
    }
}
