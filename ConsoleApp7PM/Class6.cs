using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7PM
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            string name = "kiran";
            int age = 23;
            string qual = "B.Tech";
            double per = 8.6;
            char bloodgroup = 'A';

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(qual);
            Console.WriteLine(per);
            Console.WriteLine(bloodgroup);

            Console.WriteLine($"{name} {age} {qual}  {per}  {bloodgroup}");

            Console.Write($"Name : {name} Age : {age} Qualification : {qual}  Percentage : {per} Blood Group : {bloodgroup}");
        }
    }
}
