using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LINQ
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] array = {45,67,89,23,12,44,65 };

            var sortedarray = array.OrderBy(p => p).ToArray();

            Console.WriteLine("Array elements before sorting");
          
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Array element after sorting");
            
            foreach (var item in sortedarray)
            {
                Console.WriteLine(item);
            }
           
            var descarray = array.OrderByDescending(p => p).ToArray();
            Console.WriteLine("Array elements After sorting");
            foreach (var item in descarray)
            {
                Console.WriteLine(item);
            }


        }
    }
}
