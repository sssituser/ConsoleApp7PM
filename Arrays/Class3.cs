using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size of the Array : ");
            int size = int.Parse(Console.ReadLine());
           
            int[] array = new int[size];
            
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"Enter {index + 1} Element : ");
                array[index]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array elment are :  ");
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
           

        }
    }
}
