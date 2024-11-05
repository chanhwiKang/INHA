using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Score score1 = new Score(10, 20, 30);
            Score score2 = new Score(10, 20, 30);

            Console.WriteLine(score1.Average);
            Console.WriteLine(score2.Average);*/
            //Console.WriteLine(score1.Average());
            //Console.WriteLine(score2.Average());
            
            Dictionary<string, Score> scores = new Dictionary<string, Score>();
            int cnt = 0;
            while (cnt < 3) {
                Console.Write("Student Number: ");
                var number = Console.ReadLine();

                // 입력받은 내용이 비어있거나, 5자 미만이면
                if (string.IsNullOrEmpty(number) || number.Length < 5) 
                    continue;
                
                // 입력받은 내용이 기존의 학번과 중복될 경우
                if (scores.ContainsKey(number))
                    continue;

                Console.Write("kor Score: ");
                // 파싱 시도 ? (int) kor : false
                //if (false == int.TryParse(Console.ReadLine(), out int kor))
                if (!int.TryParse(Console.ReadLine(), out int kor))
                    continue;

                Console.Write("eng Score: ");
                if (!int.TryParse(Console.ReadLine(), out int eng))
                    continue;

                Console.Write("mat Score: ");
                if (!int.TryParse(Console.ReadLine(), out int mat))
                    continue;

                scores[number] = new Score(kor, eng, mat);
                cnt++;
            }
            foreach (var score in scores)
            {
                Console.WriteLine("Student num: {0}, Avg: {1}", score.Key, score.Value.Average);
            }
            Console.WriteLine(scores["11111111"]);
        }
    }
}
