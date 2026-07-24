using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int num = 371;
            int count = 0;
            int sum = 0;
            int copy = num;
            // Counting
            while (num > 0) // 153>0-T 15>0-T 1>0 0>0-F
            {
                int digit = num % 10;// digit = 3 digit = 5 digit = 1
                count++; // count = 1,count=2 count = 3
                num /= 10; // num = 153/10 num = 15/10 num = 1 num = 0
            }
            num = copy;
            while (num > 0) // 153>-T 15>0-T 1>0-T 0>0-F
            {
                int digit = num % 10; // digit = 153%10 digit = 3 digit = 15%10 digit = 5 digit = 1%10   digit = 1
                int pval = 1; // pval = 1
                int start = 1; // start = 1
                // Fiding Power Values
                while (start <= count) // 1<=3-T 2<=3-T 3<=3-T 4<=3-F
                {
                    pval = pval * digit; // pval = 1*1 pval = 1 pval = 1 pval = 1
                    start++;// start = 2 start = 3 start = 4
                }
                sum = sum + pval; // sum = 27 sum = 27+125 => sum = 152+1 sum = 153
                num = num / 10; // num = 153/10 num = 15/10 num = 1/10 num = 0

            }
            if (copy == sum)
            {
                Console.WriteLine($"{copy} is An Armstrong number");
            }
            else
            {
                Console.WriteLine($"{copy} is not An Armstrong number");
            }


        }
    }
}
