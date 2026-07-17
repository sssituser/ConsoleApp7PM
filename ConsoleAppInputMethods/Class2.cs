using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            string num1 = Console.ReadLine();
            Console.Write("Enter num2: ");
            string num2 = Console.ReadLine();
            Console.WriteLine($"sum : {num1 + num2}");
        }
    }
}
// We don't have any mehtod to read integer
// Type conversion
