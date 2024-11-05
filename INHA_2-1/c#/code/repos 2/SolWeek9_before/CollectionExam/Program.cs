using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneDimensionalArray();
            //TwoDimensionalArray();
            //ListExam();
            //DictExam();
            JaggedArray();
        }

        private static void DictExam()
        {
            Dictionary<string, int> dictNumber = new Dictionary<string, int>();

            Console.WriteLine("TEST 1 ==========");
            dictNumber.Add("One", 1);
            dictNumber["Two"] = 1;
            dictNumber["Two"] = 2;

            //순선번호가 없어서 for문 사용 불가

            foreach (var number in dictNumber) {
                Console.Write(dictNumber[number.Key] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("TEST 2 ==========");

            dictNumber.Remove("Three");
            dictNumber.Remove("Two");

            //key존재여부 판단.
            if (dictNumber.ContainsKey("Two")) {
                //key를 기준으로 삭제
                dictNumber.Remove("Two");
            }

            foreach (var number in dictNumber) {
                Console.Write(dictNumber[number.Key] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("TEST 3 ==========");
            dictNumber["Two"] = 2;
            dictNumber["Three"] = 3;

            var keys = dictNumber.Keys.ToArray();
            var values = dictNumber.Values.ToArray();
                        
            foreach (var key in keys) {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            foreach (var val in values) {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            foreach (var key in dictNumber.Keys) {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            foreach (var key in dictNumber.Keys) {
                Console.Write(key + " ");
            }
            Console.WriteLine();


        }

        private static void ListExam()
        {
            List<int> arrNumber = new List<int>();

            Console.WriteLine("TEST 1 ==========");
            arrNumber.Add(1);
            arrNumber.Add(2);
            Console.WriteLine(arrNumber[0]);
            Console.WriteLine(arrNumber[1]);
            //Console.WriteLine(arrNumber[2]);

            Console.WriteLine("TEST 2 ==========");
            arrNumber.Insert(0, 3);
            Console.WriteLine(arrNumber[0]);
            Console.WriteLine(arrNumber[1]);
            for (int i = 0; i < arrNumber.Count; i++) {
                Console.Write(arrNumber[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("TEST 3 ==========");
            arrNumber.Remove(5);
            arrNumber.Remove(1);
            //arrNumber.RemoveAt(5);
            arrNumber.RemoveAt(0);

            foreach (var number in arrNumber) {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void TwoDimensionalArray()
        {
            string[,] arrName = new string[,]
            {
                { "1", "2", "3" },
                { "11", "12", "13" },
                { "21", "22", "23" }
            };

            Console.WriteLine("{0}차원", arrName.Rank);

            Console.WriteLine("TEST 1 ==========");
            Console.WriteLine("불가능");
            //for (int i = 0; i < arrName.Length; i++) {
            //  Console.Write(arrName[i] + " ");
            //}

            Console.WriteLine("TEST 2 ==========");
            foreach (var name in arrName) {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            Console.WriteLine("TEST 3 ==========");
            for (int i = 0; i < arrName.GetLength(0); i++) {
                for (int j = 0; j < arrName.GetLength(1); j++) {
                    Console.Write(arrName[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void OneDimensionalArray()
        {
            string[] arrName = new string[3];

            Console.WriteLine("{0}차원", arrName.Rank);

            Console.WriteLine("TEST 1 ==========");
            for (int i = 0; i < arrName.Length; i++) {
                arrName[i] = (i + 1).ToString(); //입력
            }

            Console.WriteLine("TEST 2 ==========");
            foreach (var name in arrName) {
                Console.Write(name + " "); //출력
            }

            Console.WriteLine("TEST 3 ==========");
            for (int i = 0; i < arrName.GetLength(0); i++) {
                Console.Write(arrName[i] + " "); //출력
            }
        }

        static void JaggedArray()
        {
            string[][] arrName = new string[3][];

#if false
            //arrName[0] = new string[] { "1", "2" };
            //arrName[1] = new string[] { "1", "2", "3" };
            //arrName[2] = new string[] { "1", "2", "3", "4" };    
#else
            for(int i=0; i < arrName.Length; i++) {
                arrName[i] = new string[i + 2];
                for(int j=0; j < arrName[i].Length; j++) {
                    arrName[i][j] = (j + 1).ToString();
                }
            }
#endif

            foreach (var names in arrName) {
                foreach (var name in names) {
                    Console.Write(name + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
