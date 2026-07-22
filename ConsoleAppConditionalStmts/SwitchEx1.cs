using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class SwitchEx1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\nEnter Your choice : ");
            int choice =int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Sum is :{num1+num2}");
                    break;
                case 2:
                    Console.WriteLine($"Sub is :{num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Mul is :{num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Quo is :{num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice...");
                    break;
            }

        }
    }
}
