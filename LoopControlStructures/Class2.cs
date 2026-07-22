using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class2
    {
        static void Main(string[] args)
        {//1,3,5,7,9
            int num = 10;
            int start = 1;
            int end = num;
          
            while(start <= end)//1<=10 3<=10-T 5<=10 7<=10 9<=10 11<=10-F
            {
                Console.WriteLine(start);//1 3 5 7 9
                start += 2; // start = 3 5 7 9 11

            }





        }
    }
}
