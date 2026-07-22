using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class ElseIfLadderEx
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is Big");
            }else if (num2 > num1)
            {
                Console.WriteLine("num2 is Big");
            }
            else
            {
                Console.WriteLine("Both Are Equal");
            }

        }
    }
}
