using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //1.Reading the details
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Father Name : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Age : ");
            string age = Console.ReadLine();
            Console.Write("Enter Education : ");
            string edu = Console.ReadLine();
            //2.Displaying the Details
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Fahter Name : {fname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Qualification : {edu}");
            
        }
    }
}
