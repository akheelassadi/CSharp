using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class SumOfArrayElements
    {
        public static void SumOfAllElementsInArray()
        {
            int[] array1 = new int[3];

            Console.WriteLine("Enter the elements in the first array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }

            Console.WriteLine(sum);
        }
    }
}
