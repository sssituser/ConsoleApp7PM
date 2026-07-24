using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class MaxDigit
    {
        static void Main(string[] args)
        {
            
            
                Console.Write("Enter a number : ");
                int num = int.Parse(Console.ReadLine());
                int max = num % 10; // max = 1
                while (num > 0) // num = 321>0-T 32>0-T 3>0-T 0>0-F
                {
                    int digit = num % 10; // digit = 321%10 digit = 1 digit = 32%10 digit = 2 digit = 3%10 digit = 3
                    if (digit > max) // 1>1-F 2>1-T 3>2 -T
                    {
                        max = digit; // max = 2 max = 3
                    }
                    num = num / 10; // num =321/10 num = 32/10 num = 3/10 num = 0
                }

                Console.WriteLine($"Max Digit is : {max}");
            
        }
    }
}
