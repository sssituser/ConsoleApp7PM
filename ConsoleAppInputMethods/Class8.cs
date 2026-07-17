using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Sum is : {num1+num2}\nSub is : {num1-num2}");
            Console.ReadKey();


        }
    }
}
