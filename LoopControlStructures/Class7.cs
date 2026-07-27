using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            for(int start = 1,i = 1,j=2 ; start <= 10; start += 1,i+=2,j+=2) // start = 1<=5   start = 2<=5-T start = 3<=5-T start = 4<=5
            {                                          // 5<=5-T  6<=5-F
                Console.WriteLine($"{start}  {i}   {j}");//1 2 3 4 5
            }
        }
    }
}
