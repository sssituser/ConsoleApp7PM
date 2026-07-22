using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine()); // 10
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine()); // 20
            if (num1 > num2) // 10>20
            {
                Console.WriteLine("num1 is big");
            }
            else
            {
                Console.WriteLine("num2 is big");
            }
        }
    }
}
