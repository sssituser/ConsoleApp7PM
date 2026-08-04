using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.RectAngularArray
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[,] a = { {1,2,3 },{ 4, 5, 6 } };
            int[,] b = { { 1 }, { 2 }, { 3 } };
            Console.WriteLine("=========A matrix================");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("=========B matrix================");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            int[,] c = new int[2, 1];
            for(int i =0;i<a.GetLength(0); i++)
            {
                for(int j =0; j < b.GetLength(1); j++)
                {
                    for(int k = 0; k < a.GetLength(1); k++)
                    {
                        c[i,j] = a[i, k] * b[k, j] + c[i,j];
                    }
                }
            }
            Console.WriteLine("Matrix Multiplication is");
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j=0;j<c.GetLength(1); j++)
                {
                    Console.Write($"{c[i,j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
