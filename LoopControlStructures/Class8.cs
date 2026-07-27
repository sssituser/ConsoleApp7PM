using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class8
    {
        static void Main(string[] args) // num = 5
        {
            int num = 5;
            for(int i=1;i<=num;i++) // i = 1  1<=5-T
            {
             
                for(int j = 1; j <= 10; j++) // j = 1 
                {
                    Console.WriteLine($"{i} x {j} = {i*j}  ");
                }
                Console.WriteLine("========");
            }
            
        }
    }
}
