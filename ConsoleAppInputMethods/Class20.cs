using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject - 1 Marks  : ");
            int sub1 = int.Parse(Console.ReadLine()); // sub1 = 40

            Console.Write("Enter Subject - 2 Marks  : ");
            int sub2 = int.Parse(Console.ReadLine()); // sub2 = 50


            Console.Write("Enter Subject - 3 Marks  : ");
            int sub3 = int.Parse(Console.ReadLine()); // sub3 = 60

            Console.WriteLine(sub1>34 && sub2>34 && sub3>34? "Passed":"Failed");
        }
    }
}
