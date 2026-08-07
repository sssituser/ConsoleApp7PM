using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.UserDefinedMethods
{
    /* Adam Number num = 12                     revnum = 21 
     *             numsq = 144                  revnumsq = 441
     *                                          revnumsqrev= 144
     *             
     *  AM : public static   MN : IsAdam  RT : bool   PM : int           
     *             
     */
    internal class Class7
    {
        public static bool IsAdam(int num)// num = 12
        {
            return Square(num) == Reverse(Square(Reverse(num)));
        }

        private static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

        public static int Square(int num)
        {
            return num * num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAdam(12));
            Console.WriteLine(IsAdam(11));
            Console.WriteLine(IsAdam(10));
        }
    }
}
