using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class DigitsAverage
    {
        static void Main(string[] args)
        {
            int num = 345;
            int copy = num;
            int avg = 0;
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num = num / 10;
            }
            avg = sum / count;
            Console.WriteLine($"Average of the digits of a given number {copy} is {avg}");

        }
    }
}
