using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConditionalStmts
{
    internal class IfElseLogin
    {
        static void Main(string[] args)
        {
            Console.Write("Enter User Name : ");
            string uname = Console.ReadLine();
            Console.Write("Enter Password : ");
            string paswd = Console.ReadLine();
            if (uname == "admin" && paswd == "admin")
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
