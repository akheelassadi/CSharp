using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class AddNewValueInArray
    {
        public static void DisplayArrayWithNewValueAdded()
        {
            var arrayList = new ArrayList();
            
            Console.WriteLine($"Input the size of the array");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {sizeOfArray} elements in the array: ");
            
            for (int i = 0; i < sizeOfArray; i++)
            {
                arrayList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"Input the new value to be inserted in the array: ");
            arrayList.Add(Convert.ToInt32(Console.ReadLine()));

            arrayList.Sort();

            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

        }
    }
}
