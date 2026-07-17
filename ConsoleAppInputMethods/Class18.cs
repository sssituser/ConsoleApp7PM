using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1 : ");
            int num1=int.Parse(Console.ReadLine());

            Console.Write("Enter Number2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1>num2 ? "num1 is Big":"num2 is Big");

        }
    }
}
