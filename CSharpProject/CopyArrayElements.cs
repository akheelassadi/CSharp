using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class CopyArrayElements
    {
        public static void CopyOneArrayToOtherArray()
        {
            //copy one elemnt from an array to other
            int[] array1 = new int[3];
            int[] array2 = new int[3];

            Console.WriteLine("Enter the elements in the first array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
                array2[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
        }
    }
}
