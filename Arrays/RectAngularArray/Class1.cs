using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.RectAngularArray
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 12, 34, 56 }, { 67, 89, 90 } };
            Console.WriteLine("Array elmenets usig foreach");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("By using for loop");

            for (int row = 0; row < array.GetLength(0); row++) // row = 1 1<2-T
            {
                for (int col = 0; col < array.GetLength(1); col++) // col = 2 2<3
                {
                    Console.Write($"{array[row,col]}\t");//12 34 56 67 89 90
                }
                Console.WriteLine("");
            }

        }
    }
}
