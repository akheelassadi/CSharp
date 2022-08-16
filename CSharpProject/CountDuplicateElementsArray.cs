using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class CountDuplicateElementsArray
    {
        public static void CountDuplicateElementsInArray()
        {
            int[] array1 = new int[3];

            Console.WriteLine("Enter the elements in the first array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            var dictionary = new Dictionary<int, int>();

            foreach (var value in array1)
            {
                dictionary.TryGetValue(value, out int count);
                dictionary[value] = count + 1;
            }

            Console.WriteLine("unique elements in the array are: ");
            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    Console.Write(item.Key);
                }
            }
        }
    }
}
