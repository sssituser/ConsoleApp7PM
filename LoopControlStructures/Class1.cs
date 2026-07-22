using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());// num = 10 2 4 6 8 10
            int start = 2;
            int end = num;

            while(start <= end) // 2<=10-T 4<=10 6<=10 8<=10 10<=10-T 12<=10-F
            {
                Console.WriteLine(start);//2  4 6 8 10
                start += 2; // start =4,6,8,10,12
            }
           
        }
    }
}
