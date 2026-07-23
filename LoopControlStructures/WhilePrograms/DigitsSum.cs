using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class DigitsSum
    {
        static void Main(string[] args)
        {
            int num = 456;    // 
            int copy = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine($"Sum of the Digits  of {copy} is : {sum}");
        }
    }
}
