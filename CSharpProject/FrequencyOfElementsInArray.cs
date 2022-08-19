using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class FrequencyOfElementsInArray
    {
        // 3 2 1 1 3
        // 
        public static void DisplayFrequencyOfEachElementInArray()
        {
            int[] array1 = new int[5];

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the element at {i}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            /*thorugh for loops
            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array1.Length; j++)
                    {
                        //iterate through first element
                        int firstELement = array1[i];
                        if (firstELement == array1[j])
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{array1[i]} occured {counter} times");
                    counter = 0;
                }*/

            //using dictionary
            var dictionary = new Dictionary<int, int>();

            foreach (var item in array1)
            {
                dictionary.TryGetValue(item, out int count);
                dictionary[item] = count + 1;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} occured {item.Value} times");
            }
            
        }
        
}
}
