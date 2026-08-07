using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.UserDefinedMethods
{
    /*Write  a program to find sum of N numbers ?
     * num = 5      sum = 1+2+3+4+5 => 15
     * AM : public static
     * RT : int
     * PM : int
     * MN : SumOfN
     */
    internal class Class5
    {
        public static int SumOfN(int num)
        {
            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfN(5));
            Console.WriteLine(SumOfN(10));
        }
    }
}
// Write a program to find the factorial of a given number ?
// num = 5  num = 120(1*2*3*4*5)
