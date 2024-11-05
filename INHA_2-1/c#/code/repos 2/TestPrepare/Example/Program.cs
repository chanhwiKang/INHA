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
            Program pg = new Program();
        }
        void ListTest()
        {
            List<string> strList = new List<string>() { "a", "b", "c"};
            strList.Add("d");
            strList.Insert(1, "A");
            strList.RemoveAt(2);
            foreach(var str in strList)
            {
                Console.Write(str);
            }Console.WriteLine();
            Console.WriteLine(strList.Count);
            
        }
        void ArrTest()
        {
            string[,] strArr = new string[,] { { "1", "2", "3" }, { "a", "b", "c" }, { "Z", "X", "C" } };
            for (int i = 0; i < strArr.GetLength(0); i++)
            {
                for (int j = 0; j < strArr.GetLength(1); j++)
                {
                    Console.Write(strArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
