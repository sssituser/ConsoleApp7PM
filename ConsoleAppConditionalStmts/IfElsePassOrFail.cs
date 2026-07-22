using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class IfElsePassOrFail
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject-1 Marks : ");
            int sub1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject-2 Marks : ");
            int sub2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject-3 Marks : ");
            int sub3 = int.Parse(Console.ReadLine());

            if (sub1 < 35 || sub2 < 35 || sub3 < 35)
            {
                Console.WriteLine("Student Failed");
            }else
            {
                Console.WriteLine("Student Passed");
            }
        }
    }
}
