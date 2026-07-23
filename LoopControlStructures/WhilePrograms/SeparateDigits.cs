using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class SeparateDigits
    {
        static void Main(string[] args)
        {
            int num = 345;
            while (num > 0) // 345>0-T 34>0-T 3>0-T 0>0-F
            {
                int digit = num % 10; //digit = 345%10  digit = 5  digit = 34%10 digit = 4 digit = 3%10 digit = 3
                Console.WriteLine(digit); // 5 4 3
                num = num / 10;// num = 345/10 num = 34/10 num = 3/10 num = 0
            }

        }
    }
}
