using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class SortArrayElements
    {
        public static void DisplayArrayElementsInAscOrder()
        {
            int[] array1 = new int[5];

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i+1; j < array1.Length; j++)
                {
                    if (array1[j] < array1[i])
                    {
                        int temp = array1[j];
                        array1[j] = array1[i];
                        array1[i] = temp; 
                    }
                }
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
        }
    }
}
