using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            /*
                Conversion 
                1$   ---- Rs.100
                500$ ---- Rs.5000Rs

                Rs.20000   ---> $200

             */

            Console.Write("Enter Dollars : ");
            int dollars = int.Parse(Console.ReadLine());
            Console.WriteLine($"{dollars}$ In Rs.{100*dollars}");


            // convert kgs into gms  and gms to kgs
        }
    }
}
