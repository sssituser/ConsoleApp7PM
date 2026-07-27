using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int count = 0;
            while (start <= num)
            {
                if (num % start == 0)
                {
                    Console.WriteLine(start);
                    count++;
                }
                start++;
            }
            Console.WriteLine($"{num} has {count} factors");
        }
    }
}
