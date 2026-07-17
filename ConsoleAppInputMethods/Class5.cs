using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Character : ");
            int res = Console.Read(); //
            Console.WriteLine($"ASCII Value of the about Character is : {res}");
            Console.ReadKey();
        }
    }
}
