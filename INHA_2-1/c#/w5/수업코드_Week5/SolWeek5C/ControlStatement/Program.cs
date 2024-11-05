using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlStatement
{
    internal class Program
    {
        static void Test1()
        {
            string input = Console.ReadLine();

            // type1
            int number = int.Parse(input);

            // type2
            //int number;
            //bool result = int.TryParse(input, out number);
            //if (result == false) { 
            //    return;//메소드 종료. 호출한 곳(CLR)으로 돌아감.
            //}

            // type3
            //bool result = int.TryParse(input, out int number);
            //if (result == false) { 
            //    return;//메소드 종료. 호출한 곳(CLR)으로 돌아감.
            //}

            Console.WriteLine(number);

            //if
            if (number > 0) {
                Console.WriteLine("양수1");
            }
            //if-else
            if (number > 0) {
                Console.WriteLine("양수2");
            } else {
                Console.WriteLine("양수가 아님2");
            }

            //if-else if -else
            if (number > 0) {
                Console.WriteLine("양수3");
            } else if (number < 0) {
                Console.WriteLine("음수3");
            } else {
                Console.WriteLine("영3");
            }

            //중첩if (nested if)
            if (number > 0) {
                Console.WriteLine("양수4");
                if (number % 2 == 0) {
                    Console.Write("짝수");
                }
            } else if (number < 0) {
                Console.WriteLine("음수4");
            } else {
                Console.WriteLine("영4");
            }
        }

        static void Test2()
        {
            while (true) { //무한루프
                string input = Console.ReadLine();
                switch (input) {
                    case "Y":
                    case "y":
                        Console.WriteLine("Yes");
                        break;
                    case "N":
                    case "n":
                        Console.WriteLine("No");
                        return;
                    default:
                        Console.WriteLine("Unknown");
                        break;
                }
            }
        }

        void Test3()
        {
            int[] arr;
            arr = new int[4]; //int[] arr = new int[4];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("for:" + arr[i]);
            }

            //조회용 for문 대신 사용할 수 있는 foreach
            foreach (int data in arr) {
                Console.WriteLine("foreach:" + data);
            }

            string[] names = new string[3] { "김", "인", "하" };
            foreach (var data in names) {
                Console.WriteLine("foreach:" + data);
            }

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Average());

            Console.WriteLine("++++++문자열 메소드 활용++++++");
            string test = "  aBc  ";

            Console.WriteLine(test.ToUpper());
            Console.WriteLine(test.ToLower());

            var datas = test.Split(new char[] { 'B' });
            foreach (var data in datas) {
                Console.WriteLine($"foreach:|{data}|");
            }
            for (int i = 0; i < datas.Length; i++) {
                Console.WriteLine($"for [{i}] |{datas[i]}|");
            }

            Console.WriteLine("|" + test.Trim() + "|");

            Console.WriteLine(string.Join(",", datas));
        }

        static void Main(string[] args)
        {
            Program.Test1();
            Program.Test2();

            //Program.Test3();
#if false
            //인스턴스 == 값
            var prog = new Program();
            prog.Test3();
            prog.Test3();
            prog.Test3();
#else
            (new Program()).Test3();
            (new Program()).Test3();
            (new Program()).Test3();
#endif
        }
    }
}
