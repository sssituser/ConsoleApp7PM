using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.RectAngularArray
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 12, 34, 56 }, { 67, 89, 90 }, {11,22,33 } };
            Console.WriteLine("Array elements in rows and cols");
            for(int row = 0; row < array.GetLength(0); row++)
            {
                for(int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write($"{array[row, col]}\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Diagonal Array elements ");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        Console.Write($"{array[row, col]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Diagonal Array elements ");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (row+col==2)
                    {
                        Console.Write($"{array[row, col]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Diagonal Array elements ");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (row + col == 2 || row==col)
                    {
                       
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write($"{array[row, col]}\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
