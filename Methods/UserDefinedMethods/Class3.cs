using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.UserDefinedMethods
{
    /* Write program to check give number is Plainrome or No
     * AM : public static
     * MN : IsPalinrome
     * RT : boolean
     * PM : int
     */
    internal class Class3
    {
        public static bool IsPalindrome(int num)// 121
        {
            
            return num == Reverse(num);// 121 == 12

        }

        public static int Reverse(int num)
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
            Console.WriteLine(IsPalindrome(123));
            Console.WriteLine(IsPalindrome(121));
        }
    }
}
