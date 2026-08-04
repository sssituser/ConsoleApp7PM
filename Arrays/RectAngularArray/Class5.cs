using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.RectAngularArray
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            // Jagged Array : Array of arrays is called jagged Array.
            // In jagged rows can be fixed but cols can vary
            // DataType[][] array = new DataType[rows][cols];
            int[][] a = new int[3][];
            a[0] = new int[3] { 1, 2, 3 };
            a[1] = new int[2] { 4, 5 };
            a[2] = new int[4] { 6, 7, 8, 9 };
            Console.WriteLine(a.Length);
            Console.WriteLine("jagged Array element are");
            for(int i = 0; i < a.Length; i++) // 0<3 1<3 2<3-T
            {
                foreach(int k in a[i]) //
                {
                    Console.Write($"{k}\t");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine("jagged Array element are");
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
