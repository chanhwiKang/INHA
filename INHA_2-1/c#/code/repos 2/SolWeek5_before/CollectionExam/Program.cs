using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JaggedArray();
        }

        static void OneDimensionalArray()
        {
            string[] arrName = new string[3];
            Console.WriteLine("{0}Dimension", arrName.Rank);
            Console.WriteLine("Test1===========");
            for (int i=0; i<arrName.Length; i++) {
                arrName[i] = (i + 1).ToString();
            }
            Console.WriteLine("Test2===========");
            foreach (var name in arrName) {
                Console.WriteLine(name + " ");
            }
            Console.WriteLine("Test3===========");
            for (int i = 0; i < arrName.GetLength(0); i++) {
                Console.WriteLine(arrName[i] + " ");
            }
        }
        static void TwoDimensionalArray() {
            string[,] arrName = new string[,]
            {
                {"1", "2", "3"},
                {"11", "12", "13"}
            };
            Console.WriteLine("{0}Dimension", arrName.Rank);
            Console.WriteLine("Test1============");
            foreach (var name in arrName) {
                Console.WriteLine(name + " ");
            }
            Console.WriteLine("Test2============");
            for (int i=0; i<arrName.GetLength(0); i++) {
                for (int j = 0; j < arrName.GetLength(1); j++) {
                    Console.WriteLine(arrName[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        static void ListExam()
        {
            List<int> arrNumber = new List<int>();
            arrNumber.Add(1);
            arrNumber.Add(2);
            arrNumber.Add(3);
            Console.WriteLine(arrNumber[0]);
            //Console.WriteLine(arrNumber[10]);
            Console.WriteLine(arrNumber[arrNumber.Count-1]);

            arrNumber.Insert(0, 0);

            arrNumber.Remove(0); // val remove
            arrNumber.RemoveAt(0);// index remove
            foreach (var number in arrNumber) {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();
        }

        static void DictExam()
        {
            Dictionary<string, int> dictNumbers = new Dictionary<string, int>();

            dictNumbers.Add("One", 1);
            dictNumbers["Two"] = 1;
            dictNumbers["Two"] = 2;

            foreach (var num in dictNumbers) {
                Console.WriteLine(num);

                Console.WriteLine(num.Key);
                Console.WriteLine(num.Value);
                Console.WriteLine(dictNumbers[num.Key]);
            }

            foreach (var key in dictNumbers.Keys) {
                Console.WriteLine(dictNumbers[key]);
            }

            foreach (var val in dictNumbers.Values)
            {
                Console.WriteLine(val);
            }

            dictNumbers.Remove("Two");

            if (dictNumbers.ContainsKey("Two")){
                dictNumbers.Remove("Two");
            }
        }

        static void JaggedArray()
        {
            string[][] arrName = new string[3][];

            /*arrName[0] = new string[] { "1", "2" };
            arrName[1] = new string[] { "1", "2", "3" };
            arrName[2] = new string[] { "1", "2", "3", "4" };*/

            /*arrName[0] = new string[2];
            arrName[1] = new string[3];
            arrName[2] = new string[4];*/

            Console.WriteLine(arrName.Length);
            Console.WriteLine(arrName.GetLength(0));

            for (int i = 0; i < arrName.GetLength(0) ; i++)
            {
                arrName[i] = new string[i + 2]; // 동관이꺼 훔쳐쓰기
                for (int j = 0; j < arrName[i].Length; j++)
                    arrName[i][j] = (j + 1).ToString();
            }
            foreach (var names in arrName)
            {
                foreach (var name in names)
                    Console.Write(name+" ");
                Console.WriteLine();
            }
        }
    }
}
