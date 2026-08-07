using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.UserDefinedMethods
{
    // Check Given number is Armstrong or Not  // 153 = 1cube+5cube+3cube  1634 =1pow4+6pow4+3pow4+4pow4
    // AM : public static
    // MN : IsArmstrong
    // PM : int
    // RT : bool
  

   

    internal class Class6
    {
        public static bool IsArmstrong(int num)
        {
            int sum = 0;
            int copy = num;
            int pow = DigitCount(num); 
            while (num > 0) 
            {
                int digit = num % 10; 
                sum = sum + Power(digit, pow);
                num /= 10;
            }
            return copy == sum;
        }

        private static int Power(int digit, int pow) 
        {
            int res = 1;
            for (int i = 1; i <= pow; i++)
            {
                res = res * digit;
            }
            return res;
        }

        public static int DigitCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(153));
            Console.WriteLine(IsArmstrong(1634));
            Console.WriteLine(IsArmstrong(1635));
        }
    }
}
