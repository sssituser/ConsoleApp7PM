using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class ReverseNum
    {
        static void Main(string[] args)
        {
            int num = 123;
            int copy = num;
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            num = copy;
            Console.WriteLine($"Reverse of a given number {num} is {rev}");
        }
    }
}
