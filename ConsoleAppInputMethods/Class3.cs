using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Integer : ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter Float value : ");
            float f = float.Parse(Console.ReadLine());

            Console.Write("Enter double value : ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Enter Boolean : ");
            bool b = bool.Parse(Console.ReadLine());

            Console.Write("Enter byte value : ");
            byte bt = byte.Parse(Console.ReadLine());

            Console.Write("Enter short value : ");
            short s = short.Parse(Console.ReadLine());


            Console.WriteLine($"{num}   {f}   {d}  {b}  {bt}  {s}");



        }
    }
}
