using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputMethods
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            int s1 = 50;
            int s2 = 60;
            int s3 = 70;
            Console.WriteLine(s1>34 && s2>34 && s3>34);// TRUE
            s3 = 20;
            Console.WriteLine(s1>34 && s2>34 && s3>34);// FALSE

            int m1 = 30;
            int m2 = 20;
            int m3 = 60;
            Console.WriteLine(m1>34 || m2>34 || m3>34); // TRUE TRUE

            int res = 45;
            Console.WriteLine(!true); //FALSE
            Console.WriteLine(!(res>50)); //TRUE

        }
    }
}
