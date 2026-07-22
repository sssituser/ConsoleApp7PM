using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class SimpleIf
    {
        static void Main(string[] args)
        {

            Console.Write("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine()); // age = 19
            if (age < 18) //19<18--->False
            {
                Console.WriteLine("Your a Minor");
                Console.WriteLine("You can't Vote");
            }

            if (age > 17) // 19>17-T
            {
                Console.WriteLine("Your a Major");
                Console.WriteLine("You can vote");
            }
        }
    }
}
