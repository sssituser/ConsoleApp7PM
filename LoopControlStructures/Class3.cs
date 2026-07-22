using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int num = 40;
            int start = num;
            int end = 1;
            while(start>=end)
            {
                Console.WriteLine(start);//5
                start -= 1;
            }
        }
    }
}
