using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.WhilePrograms
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {
            int num = 12221;
            int rev = 0;
            int copy = num;
            while (num > 0) // 123>0-T 12>0-T 1>0-T 0>0
            {
                int digit = num % 10; // d = 123%10 d = 3 di = 12%10  d = 2 d = 1%10 d = 1
                rev = rev * 10 + digit; // rev = 3 rev = 32 rev = 321
                num= num / 10;// num = 123/10 num = 12/10 num = 1/10 num = 0
            }
            if (copy == rev)
            {
                Console.WriteLine($"{copy} is a Palindrome number");
            }
            else
            {
                Console.WriteLine($"{copy} is not a Palirome number");
            }

        }
    }
}
