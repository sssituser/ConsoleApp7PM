using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class ElseIfLadderEx3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Entered Number is ZERO");
            }else if (num == 1)
            {
                Console.WriteLine("Entered Number is ONE");
            }else if (num == 2)
            {
                Console.WriteLine("Entered Number is Two");
            }
            else
            {
                Console.WriteLine("Entered Number is Other than 0,1,2");
            }
        }
    }
}
