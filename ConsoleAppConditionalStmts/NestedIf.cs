using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class NestedIf
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Temprature : "); // 26
            int temp = int.Parse(Console.ReadLine());
            if (temp > 20)
            {
                if (temp < 26)
                {
                    Console.WriteLine("Room Temparature");
                }
                else
                {
                    Console.WriteLine("Hot");
                }
            }
            else
            {
                Console.WriteLine("COLD");
            }
        }
    }
}
