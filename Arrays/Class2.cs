using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3] { 34, 56, 78 };
            Console.WriteLine("===================Displaying Array1-Elements Using Index==========");
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

            int[] array2 = new int[] { 11, 22, 33, 44 };
            Console.WriteLine("===================Displaying Array2-Elements Using For Loop==========");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine("===================Displaying Array3-Elements Using Foreach Loop==========");
            int[] array3 = { 10, 20, 30 };
            foreach(int i in array3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
