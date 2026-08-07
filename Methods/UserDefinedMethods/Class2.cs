using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.UserDefinedMethods
{
    //Write a program to find the Reverse of a given number
    // num = 123  rev = 321
    /* AM : public static
     * MN : ReverseNum/Reverse
     * PM : int
     * RT : int
     */
    internal class Class2
    {
        public static int  ReverseNum(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNum(123));
        }
    }
}
