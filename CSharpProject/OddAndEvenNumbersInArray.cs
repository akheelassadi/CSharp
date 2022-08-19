using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class OddAndEvenNumbersInArray
    {
        public static void DisplayEvenAndOddNumbers()
        {
            int[] array1 = new int[10] { 0, 1, 2, 3, 4, 5, -6, 7 ,8 ,9};
            var evenArray = new ArrayList();
            var oddArray = new ArrayList();

            for (int i = 0; i < array1.Length; i++)
            {             
                if (array1[i] % 2 == 0)
                {
                    evenArray.Add(array1[i]);
                }
                else
                {
                    oddArray.Add(array1[i]);
                }
            }

            Console.WriteLine($"even elements in the array are: ");
            for (int i = 0; i < evenArray.Count; i++)
            {
                Console.Write($"{evenArray[i]} ");
            }

            Console.WriteLine($"\nodd elements in the array are: ");
            for (int i = 0; i < oddArray.Count; i++)
            {
                Console.Write($"{oddArray[i]} ");
            }

        }
}
}
