using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : "); // num1 = 5
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : "); // num2 = 2
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1>num2);     // True
            Console.WriteLine(num1>=num2);    // True 
            Console.WriteLine(num1<num2);     // False
            Console.WriteLine(num1<=num2);   // False
            Console.WriteLine(num1==num2);   // False
            Console.WriteLine(num1!=num2);  // True
            Console.WriteLine($"{num1} >  {num2}  : {num1>num2}");
            Console.WriteLine($"{num1} >= {num2}  : {num1>=num2}");
            Console.WriteLine($"{num1} <  {num2}  : {num1<num2}");
            Console.WriteLine($"{num1} <= {num2}  : {num1<=num2}");
            Console.WriteLine($"{num1} == {num2}  : {num1==num2}");
            Console.WriteLine($"{num1} != {num2}  : {num1!=num2}");
        }
    }
}
