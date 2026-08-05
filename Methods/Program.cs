using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {            //"0123456"
            string s = "welcome";
            Console.WriteLine(s.Length);
            Console.WriteLine($"s = {s} has {s.Length} characters"); // Lower case
            string res = s.ToUpper();
            Console.WriteLine($"s = {s}  res = {res}");// Upper case
            string x = res.ToLower();
            Console.WriteLine($"x = {x}  res = {res}");
            Console.WriteLine(s.Contains("come")); // True
            Console.WriteLine(s.Contains("get")); // False

            Console.WriteLine(s.ElementAt(2));
            Console.WriteLine(s.ElementAt(4));
            Console.WriteLine(s.ElementAt(6));

            Console.WriteLine(s.IndexOf('w'));
            Console.WriteLine(s.IndexOf('e'));
            Console.WriteLine(s.LastIndexOf('e'));
        }
    }
}
