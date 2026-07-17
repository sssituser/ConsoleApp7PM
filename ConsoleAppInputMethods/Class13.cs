using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            Console.WriteLine($"num1 : {num1}\tnum2 : {num2}");// num1 : 5 num2 : 2
            num1 += num2; // num1 = num1+num2
            Console.WriteLine($"num1 : {num1}"); // 7
            num1 -= num2;// num1 = num1-num2
            Console.WriteLine($"num1 : {num1}"); // 5 
            num1 *= num2;// num1 = num1*num2
            Console.WriteLine($"num1 : {num1}"); // 10
            num1 /= num2;// num1 = num1/num2
            Console.WriteLine($"num1 : {num1}"); // 5
            num1 %= num2;// num1 = num1%num2 
            Console.WriteLine($"num1 : {num1}"); // 1
                                                 // 
        }
    }
}
