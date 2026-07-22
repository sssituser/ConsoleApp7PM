using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    class ElseIfLadderEx2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject-1 Marks : ");
            int num1 = int.Parse(Console.ReadLine());

			Console.Write("Enter Subject-2 Marks : ");
			int num2 = int.Parse(Console.ReadLine());

			Console.Write("Enter Subject-3 Marks : ");
			int num3 = int.Parse(Console.ReadLine());
           
            int total = num1 + num2 + num3;
            int per = total / 3;

            if (num1 < 35 || num2 < 35 || num3 < 35)
            {

                Console.WriteLine("Student failed");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Student Got Passed In First Division");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Student Got Passed In Second Division");
            }
            else
            {
                Console.WriteLine("Student Got Passed In Third Divsion");
            }
		}
    }
}
