using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Integer  value : ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Byte value : ");
            byte bt = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Double value : ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Float value : ");
            float f = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter long value : ");
            long l = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter boolean value : ");
            bool b = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"{i}   {bt}  {d}  {f}  {l}  {b}");


        }
    }
}

//float - 4  bytes    double - 8bytes    decimal data type  16
