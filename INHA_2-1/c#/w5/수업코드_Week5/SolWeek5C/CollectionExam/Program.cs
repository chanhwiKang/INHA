using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictExam();
        }

        static void OneDimensionalArray()
        {
            string[] arrName = new string[3];
            Console.WriteLine("{0}차원", arrName.Rank);

            Console.WriteLine("TEST 1 ==========");
            for (int i = 0; i < arrName.Length; i++) {
                arrName[i] = (i + 1).ToString();
            }

            Console.WriteLine("TEST 2 ==========");
            foreach (var name in arrName) {
                Console.Write(name + " ");
            }

            Console.WriteLine("TEST 3 ==========");
            for (int i = 0; i < arrName.GetLength(0); i++) {
                Console.Write(arrName[i] + " ");
            }
        }
        static void TwoDimensionalArray()
        {
            string[,] arrName = new string[,]
            {
                { "1", "2", "3" },
                { "11", "12", "13" }
            };
            Console.WriteLine("{0}차원", arrName.Rank);
            Console.WriteLine("TEST 1 ==========");
            foreach (var name in arrName) {
                Console.Write(name + " ");
            }
            Console.WriteLine("TEST 2 ==========");
            for (int i = 0; i < arrName.GetLength(0); i++) {
                for (int j = 0; j < arrName.GetLength(1); j++) {
                    Console.Write(arrName[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ListExam()
        {
            List<int> arrNumber = new List<int>();
            //추가
            arrNumber.Add(1);//[0]
            arrNumber.Add(2);//[1]
            arrNumber.Add(3);//[2]

            Console.WriteLine(arrNumber[0]);
            //Console.WriteLine(arrNumber[10]);
            Console.WriteLine(arrNumber[arrNumber.Count - 1]);

            //arrNumber.Add(0); //[3]
            //삽입
            arrNumber.Insert(0, 0); //[0]

            //삭제
            arrNumber.RemoveAt(0);//0번 인덱스 요소 삭제
            arrNumber.Remove(0);//0값을 갖는 요소 삭제

            foreach (var number in arrNumber) {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void DictExam()
        {
            Dictionary<string, int> dictNumbers =
               new Dictionary<string, int>();

            //추가
            //리스트 index(순서번호)
            //딕셔너리는 논리적 순서 없음.
            dictNumbers.Add("One", 1);
            dictNumbers["Two"] = 1;
            //값 수정
            dictNumbers["Two"] = 2;

            //for문을 사용할 수 없음.
            //순서번호로 제어하는 for문 사용 불가
            foreach (var num in dictNumbers) {
                Console.WriteLine(num);   //["Two",2]
                Console.WriteLine(num.Key);
                Console.WriteLine(num.Value);
                Console.WriteLine(dictNumbers[num.Key]);
            }

            foreach (var key in dictNumbers.Keys) {
                Console.WriteLine(dictNumbers[key]);
            }

            foreach (var val in dictNumbers.Values) {
                Console.WriteLine(val);
            }

            //key존재여부 판단.
            if (dictNumbers.ContainsKey("Two")) {
                dictNumbers.Remove("Two");
            }

        }

        static void JaggedArray()
        {
            string[][] arrName = new string[3][];

            //숙제 아래 초기화 세 문장을 for문으로 만드는 것을 연습해보세요.
            arrName[0] = new string[] { "1", "2" };
            arrName[1] = new string[] { "1", "2", "3" };
            arrName[2] = new string[] { "1", "2", "3", "4" };
            //Console.WriteLine(arrName.GetLength(1));
            foreach (var names in arrName) {
                foreach (var name in names) {
                    Console.Write(name + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
