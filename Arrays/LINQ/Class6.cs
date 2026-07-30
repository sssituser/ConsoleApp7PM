using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LINQ
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 33, 44, 11, 55, 66, 77, 88, 90, 89, 90, 78, 11, 33, 65, };
            Console.WriteLine("Array elements are");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            var duplictes = array.GroupBy(x => x).ToDictionary(x=>x.Key,x=>x.Count());
            Console.WriteLine("=========Duplcates are=============");
            foreach (var item in duplictes)
            {
                if (item.Value >= 2)
                {
                    Console.WriteLine($"{item.Key}    {item.Value}");
                }
            }
            Console.WriteLine("=========uniques are=============");
            foreach (var item in duplictes)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"{item.Key}    {item.Value}");
                }
            }
        }
    }
}
