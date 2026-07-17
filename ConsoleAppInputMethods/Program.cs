using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
           Console.Write("Enter Name : ");
           string res = Console.ReadLine();
           Console.WriteLine($"You Have Entered Your Name ==> {res}<====");
        }
    }
}
