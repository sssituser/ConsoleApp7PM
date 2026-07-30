using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.LINQ
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            string s = "kirankumar";

            var res = s.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
            
        }
    }
}
