using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LINQ
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 33, 44, 11, 55, 66, 77, 88, 90, 89, 90, 78, 11, 33, 65, };

            Console.WriteLine("Arrayy elements are");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================");
            var dict = array.GroupBy(x => x).ToDictionary(p => p.Key,p=>p.Count());
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

        }
    }
}
