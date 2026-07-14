using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7PM
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Memory occupied by byte : {sizeof(byte)} byte");
            Console.WriteLine($"Memory occupied by sbyte : {sizeof(sbyte)} byte");
            Console.WriteLine($"Memory occupied by short : {sizeof(short)} bytes");
            Console.WriteLine($"Memory occupied by ushort : {sizeof(ushort)} bytes");
            Console.WriteLine($"Memory occupied by int : {sizeof(int)} bytes");
            Console.WriteLine($"Memory occupied by long : {sizeof(long)} bytes");
            Console.WriteLine($"Memory occupied by decimal : {sizeof(decimal)} bytes");
            Console.WriteLine($"Memory occupied by float : {sizeof(float)} bytes");
            Console.WriteLine($"Memory occupied by double : {sizeof(double)} bytes");
            Console.WriteLine($"Memory occupied by bool : {sizeof(bool)} byte");
            Console.WriteLine($"Memory occupied by char : {sizeof(char)} bytes ");
        }
    }
}
