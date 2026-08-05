using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "bcd";
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s1));
            Console.WriteLine(s1.CompareTo("abc"));

            


        }
    }
}
