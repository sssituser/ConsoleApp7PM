using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class NestedIfEx1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            if (age > 17)
            {
                if (age < 21)
                {
                    Console.WriteLine("You are Major You Can Vote");
                }
                else
                {
                    Console.WriteLine("You are Major You Can Vote and Mary");
                }
            }
            else
            {
                Console.WriteLine("You are Minor");
            }
        }
    }
}
