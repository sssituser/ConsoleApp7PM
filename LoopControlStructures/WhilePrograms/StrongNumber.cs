using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class StrongNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int copy = num;
            while (copy > 0) // 145>0-T  14>0->t 1>0-T 0>0-F
            {
                int digit = copy % 10; // digit = 145%10 digit = 5 digit = 4 digit = 1
                int start = 1;
                int fact = 1;
                while (start <= digit)
                {
                    fact *= start;
                    start++;
                }
                sum += fact;
                copy /= 10;

            }
            if (num == sum)
            {
                Console.WriteLine($"{num} is a Strong number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Strong number");
            }
        }
    }
}
