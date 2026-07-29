using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size : ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Array  {i+1}  Element : ");
                array[i] = int.Parse(Console.ReadLine()) ;

            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }

            }
            Console.WriteLine("Sorting the elements In Ascending order");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }

            }
            Console.WriteLine("Sorting the elements In desending order");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
