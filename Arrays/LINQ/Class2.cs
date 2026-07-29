using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LINQ
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] array = { 45, 67, 89, 23, 12, 44, 65 };
            Console.WriteLine("Array elements are");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========Even numbers==========");
            var evens = array.Where(x => x % 2 == 0).ToArray();

            foreach (var item in evens)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("===============OddNums===============");
            var odds = array.Where(x=>x%2!=0).ToArray();
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }
        }
    }
}
