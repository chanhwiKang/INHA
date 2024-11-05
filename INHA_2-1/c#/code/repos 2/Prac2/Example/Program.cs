using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] datas = new string[,] { 
                { "0", "1", "2" }, 
                { "3", "4", "5" } 
            };
            Console.WriteLine(datas.Rank);
            Array.Sort(datas[0]);
            foreach(var name in datas)
            {
                Console.WriteLine(name);
            }

        }
    }
}
