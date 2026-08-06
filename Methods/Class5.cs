using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            string s = "abc";

            Console.WriteLine(string.IsNullOrEmpty(s));
            s = "";
            Console.WriteLine(string.IsNullOrEmpty(s));
            s = " ";
            Console.WriteLine(string.IsNullOrWhiteSpace(s));

            string s1 = "ab";
            string s2 = "bc";
            Console.WriteLine(string.Compare(s1,s2));
            Console.WriteLine(string.Compare("zx","ab"));
            Console.WriteLine(string.Compare("bc","bd"));

            
        }
    }
}
