using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 5 1 2 3 4 5
            int start = 1;
            int end = num;

            while(start <= end)
            {
                Console.WriteLine(start);
                start += 1;
            }




        }
    }
}
