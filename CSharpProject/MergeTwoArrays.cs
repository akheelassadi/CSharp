using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class MergeTwoArrays
    {
        public static int[] GetMergedArray()
        {
            int[] array1 = new int[3];
            int[] array2 = new int[array1.Length];
            int[] mergedArray = new int[array1.Length + array2.Length];

            Console.WriteLine("Enter the elements in the first array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements in the second array: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < mergedArray.Length; i++)
            {
                if (i < mergedArray.Length/2)
                {
                    mergedArray[i] = array1[i];
                }
                else
                {
                    mergedArray[i] = array2[i-array2.Length];
                }
            }

            return mergedArray;
        }

        public static void SortMergedArray()
        {
            int[] arr = GetMergedArray();
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
        }
    }
}
