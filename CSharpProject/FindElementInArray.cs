using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class FindElementInArray
    {
        public static void FindSecondLargestElementInArray()
        {
            int[] array1 = new int[5];

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            int largestElement = 0, SecondLargestElement = 0;
            
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > largestElement)
                {
                    largestElement = array1[i];
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != largestElement)
                {
                    if (array1[i] > SecondLargestElement)
                    {
                        SecondLargestElement = array1[i];
                    }
                }
            }
            
            Console.WriteLine($"The second largest element in the array: {SecondLargestElement}");
        }
    }
}
