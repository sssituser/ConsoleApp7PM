using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LINQ
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] array = { 11,33,44,11,55,66,77,88,90,89,90,78,11,33,65,};
            
            Console.WriteLine("Array elementns");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing Duplicates from the array");

            var distints = array.Distinct().ToArray();

            foreach (var item in distints)
            {
                Console.WriteLine(item);
            }

            var duplicates = array.GroupBy(x => x).Where(p => p.Count() >= 2).Select(g => g.Key).ToArray();
            Console.WriteLine("Duplicate elments in the array");
            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Unique elements");
            var uniques = array.GroupBy(x => x).Where(p => p.Count() ==1).Select(g => g.Key).ToArray();
            foreach (var item in uniques)
            {
                Console.WriteLine(item);
            }

        }
    }
}
