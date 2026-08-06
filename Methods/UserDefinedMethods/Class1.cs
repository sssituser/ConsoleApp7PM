using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.UserDefinedMethods
{// Write a program to Sum the digits of a give number
    // num = 4567  No digits = 4

    /* AM : public static
     * MN : CountDigits / DigitCount
     * PM : int
     * RT : int
     * 
     * AM : public static
     * MN : DigitSum
     * PM : int
     * RT : int
     */
    internal class Class1
    {
        public static int DigitCount(int num) // num = 678
        {
            int count = 0;
            while (num > 0) 
            {
                count++;
                num = num / 10; 
            }
            return count;
        }

        public static int DigitSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum +=  num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter  a number  : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(DigitCount(num));
            Console.WriteLine(DigitSum(num));
            Console.WriteLine(DigitCount(655));
            Console.WriteLine(DigitSum(655));
        }
    }
}
