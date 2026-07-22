using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            while (start <= end)
            {
                Console.WriteLine($"{num}  x {start} = {num*start}");
                start++;
            }
        }
    }
}
