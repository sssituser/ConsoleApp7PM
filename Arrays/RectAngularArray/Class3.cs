using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.RectAngularArray
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("=====================Array A=============");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================Array B=============");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=====================Sum of A Array and B Array=============");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j] + b[i,j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=====================Sub of A Array and B Array=============");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j] - b[i, j]}\t");
                }
                Console.WriteLine();
            }

            // logic
            int[,] c = new int[2, 2];
            for(int i = 0;i < a.GetLength(0); i++) // i = 0 0<2-T i = 1 1<2-T
            {
                for(int j=0;j< b.GetLength(1); j++)// j = 0 0<2-T j = 1
                {
                    for(int k = 0; k < 2; k++)// k = 0 0<2 k = 1 1<2 2<2-T
                    {
                        c[i, j] = a[i, k] * b[k, j] + c[i, j]; 
                      //c[0,0] = a[0,0]*b[0,0]+c[0,0]
                      //c[0,0] = 1*5+0 => c[0,0] = 5
                      //c[0,0] = a[0,1]*b[1,0]+5
                      //c[0,0] = 2*7+5=> c[0,0] = 19

                      //c[0,1] = a[0,0]*b[0,1]+c[0,1]
                      //c[0,1] = 1*6+0 c[0,1]=>6
                      //c[0,1] = a[0,1]*b[1,1]+c[0,1]
                      //c[0,1] = 2*8+6 => c[0,1] = 22

                    // c[1,0] = a[1,0]*b[0,0]+c[1,0]
                    // c[1,0]=  3*5+0=> 15
                    // c[1,0] = a[1,1]*b[1,0]+c[1,0]
                    // c[1,0] = 4*7+15 => 43


                    }
                }
            }

            Console.WriteLine("=====================Mul of A Array and B Array=============");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{c[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
