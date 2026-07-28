using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures.forloop
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num = 5;
            int k = 1;
            int res = 64;
            for(int i = 1; i <= num; i++)
            {
                
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)(res+k)}\t");
                    k++;
                }
                Console.WriteLine();
            }
            for (int i = num-1; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)(res+k)}\t");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
