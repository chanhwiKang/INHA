using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    internal class Program
    {
        // static method
        static void Test1() {
            string input = Console.ReadLine();
            // type1:  string 및 double 입력 시 오류발생
            // int number = int.Parse(input);

            // type2 : parse 성공 시 result에 true, out에 값 반환. 실패 시 result에 false, out에 값 반환.
            // result가 true면 number를 이용하면 된다.
            // out 변수는 일종의 call-by-reference를 이용
            // 출력전용변수라 하며, number는 일종의 포인터를 사용하는것과 유사하게 동작.
            //int number;
            //bool result = int.TryParse(input, out number);
            //if(result == false) { return; }

            // type3 : out과 변수사이에 자료형입력 시 따로 변수 선언없이 사용 가능.
            bool result = int.TryParse(input, out int number);
            if (result == false) { return; }

            Console.WriteLine(number * 2);

            if (number > 0) { 
                Console.WriteLine("양수");
                if (number % 100 == 0) { Console.WriteLine("100의 배수"); }
            }
            else if (number < 0) { Console.WriteLine("음수"); }
            else { Console.WriteLine("0"); }
        }
        static void Test2() {
            while (true)
            {
                string input = Console.ReadLine();
                switch (input) {
                    case "y": // 한줄도 없다면 break입력하지 않아도 됨.
                    case "Y":
                        Console.WriteLine("Yes");
                        return;
                    case "n":
                    case "N":
                        Console.WriteLine("No");
                        break;
                    default:
                        Console.WriteLine("Unknown");
                        break;
                }
            }
        }

        // instance method
        void Test3() {
            // all ok
            // int[] arr = new int[3]; // [0, 0, 0]
            // int[] arr = new int[3] { 1, 2, 3 };
            int[] arr = { 1, 2, 3 };
            // string[] arr = { "a", "b", "c" }; 

            for (int i = 0; i < arr.Length; i++) { // string type -> Length() 아님.
                Console.WriteLine(arr[i]);
            }

            foreach (var i in arr) { 
                Console.WriteLine(i);
            }
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());
        }

        void Test4() {
            string test = "    aBc    ";

            Console.WriteLine(test.ToUpper());
            Console.WriteLine(test.ToLower());

            var datas = test.Split(new char[] { 'B' });
            foreach (var data in datas) {
                Console.WriteLine($"foreach:|{data}");
            }
            Console.WriteLine();
            for (int i=0; i < datas.Length; i++) {
                Console.WriteLine($"for [{i}] | [{datas[i]}]");    
            }
            Console.WriteLine("|" + test.Trim() + "|");
            Console.WriteLine(string.Join(",", datas));
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Test3();
        }
    }
}
