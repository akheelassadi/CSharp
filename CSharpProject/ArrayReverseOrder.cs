using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class ArrayReverseOrder
    {
        public static void DisplayArrayInReverseOrder()
        {
            //2. Display array in reverse order
            int[] array1 = new int[3];

            Console.WriteLine("Enter the elements in the first array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Elements stored in the array are: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }

            Console.WriteLine($"\nElements in the reverse order: ");
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array1[i]} ");
            }
        }       
    }
}
