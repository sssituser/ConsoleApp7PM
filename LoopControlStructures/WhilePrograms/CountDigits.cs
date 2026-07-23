using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class CountDigits
    {
        static void Main(string[] args)
        {
            int num = 567894;
            int count = 0;
            while (num > 0) // 234>0-T 23>0-T 2>0-T 0>0
            {
                int digit = num % 10; // digit = 234%10 digit = 4 digit = 23%10 digit = 3 digit = 2%10 digit = 2
                count++; // count = 1 count = 2 count = 3
                num = num / 10;// num = 234/10 num = 23/10 num = 2/10 num = 0

            }

            Console.WriteLine($"Digits Count is :{count} ");
        }
    }
}
