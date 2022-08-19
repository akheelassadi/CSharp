using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class FindMinAndMaxElementInArray
    {
        public static void DisplayMaxElementInArray()
        {
            int[] array1 = new int[5];

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
            }
            Console.WriteLine($"Maximum element in the array is {max}");
        }

        public static void DisplayMinElementInArray()
        {
            int[] array1 = new int[5];

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            int min = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {              
                if (array1[i] < min)
                {
                    min = array1[i];
                }
            }
            Console.WriteLine($"Min element in the array is {min}");
        }
    }
}
