using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // 0
            int start = 1;
            int end = num;

            do
            {
                Console.WriteLine(start); //1
                start += 1;  //start = 2
            } while (start <= end); //1<=0-F


        }
    }
}
