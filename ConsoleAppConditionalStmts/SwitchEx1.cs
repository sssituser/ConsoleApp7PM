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

        Menu1:
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
        Menu2:
            Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\nEnter Your choice : ");
            int choice =int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Sum is :{num1+num2}");
                    goto Menu2;
                case 2:
                    Console.WriteLine($"Sub is :{num1 - num2}");
                    goto Menu2;
                case 3:
                    Console.WriteLine($"Mul is :{num1 * num2}");
                    goto Menu2;
                case 4:
                    Console.WriteLine($"Quo is :{num1 / num2}");
                    goto Menu2;
                default:
                    Console.WriteLine("Invalid choice...");
                    goto Menu1;
            }

        }
    }
}
