using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            while (start <= num) // 1<= 8-T 2<=8-T 3<=8-T 4<=8 8<=8 9<=8-F
            {
                if (num % start == 0) // 8%1=>0 == 0-T 8%2=>0 == 0-T  8%3=>2==0-F 8%3=>0==0-T 8%8=>0==0-T
                {
                    Console.WriteLine(start);//1 ,2 , 4
                }
                start++;//start = 2 start = 3,start = 4,start = 5,start = 6,start = 7 start = 9
            }
        }
    }
}
