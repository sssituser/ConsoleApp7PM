using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class MinDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number  : ");
            int num = int.Parse(Console.ReadLine());
            int min = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit < min)
                {
                    min = digit;
                }
                num /= 10;
            }
            Console.WriteLine($"Min Digit is : {min}");
        }
    }
}
