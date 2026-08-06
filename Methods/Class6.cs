using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class6
    {
        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            int res = Sum(5, 2);
            Console.WriteLine($"Result is : {res}");
            Console.WriteLine($"Result is : {Sum(4,5)}");

        }
    }
}
