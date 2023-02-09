using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class DeleteArrayElement
    {
        public static void DeleteAnElementFromArray()
        {
            int[] array1 = new int[5];

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at postion {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lets try to delete the element in the array");
            Console.WriteLine("***************");
            Console.WriteLine("Which element do you wish to delete in the array\n" +
                "Please insert the position of the element ");
            int elementPosition = int.Parse(Console.ReadLine());

            if (elementPosition > array1.Length)
            {
                Console.WriteLine("No such element exists");
                Console.WriteLine("\nTry again\n***************");
                Console.WriteLine("insert the element position");
                elementPosition = int.Parse(Console.ReadLine());
            }

            for (int i = elementPosition-1; i < array1.Length-1; i++)
            {
                array1[i] = array1[i + 1];
            }

            array1 = new int[4];

            Console.WriteLine("The element list after delettion are: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" {array1[i]}");
            }
        }
    }
}
