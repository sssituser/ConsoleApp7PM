using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num1 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum :{num1+num2}\tSub : {num1-num2}\tMul : {num1*num2}\tQuo  : {num1/num2}\tRem : {num1%num2}");
        }
    }
}
