using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3] {34,56,78 };
            Console.WriteLine("===================array1-elements==========");
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

            int[] array2 = new int[] { 11, 22, 33, 44 };
            Console.WriteLine("===================array2-elements==========");
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);
            Console.WriteLine("===================array3-elements==========");
            int[] array3 = {10,20,30 };
            Console.WriteLine(array3[0]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array3[2]);
        }
    }
}
