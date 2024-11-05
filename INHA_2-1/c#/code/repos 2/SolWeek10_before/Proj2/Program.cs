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
            Dictionary<string, Score> scores = new Dictionary<string, Score>();

            int count = 0;
            int kor, eng, mat;

            while (count < 3) {
                Console.Write("학번:");
                var number = Console.ReadLine();

                if (string.IsNullOrEmpty(number) || number.Length < 5) {
                    continue;
                }

                if (scores.ContainsKey(number)) {
                    continue;
                }                

                while (true) {
                    Console.Write("국어:");
                    if (false == int.TryParse(Console.ReadLine(), out kor)) {
                        continue;
                    } else {
                        break;
                    }
                }

                while (true) {
                    Console.Write("영어:");
                    if (true == int.TryParse(Console.ReadLine(), out eng)) {                        
                        break;
                    }
                }

                while (true) {
                    Console.Write("수학:");
                    if (true == int.TryParse(Console.ReadLine(), out mat)) {
                        break;
                    }
                }

                scores[number] = new Score(kor, eng, mat);

                count++;
            }

            Console.Write("점수를 수정할 학번:");
            var targetNumber = Console.ReadLine();
            if (scores.ContainsKey(targetNumber)) {
                Console.Write("국어");
                int.TryParse(Console.ReadLine(), out kor);
                scores[targetNumber].Kor = kor;
                Console.WriteLine(scores[targetNumber].Kor);
                
                Console.Write("영어");
                int.TryParse(Console.ReadLine(), out eng);
                scores[targetNumber].Eng = eng;
                Console.WriteLine(scores[targetNumber].Eng);
                
                Console.Write("수학");
                int.TryParse(Console.ReadLine(), out mat);
                scores[targetNumber].Mat = mat;
                Console.WriteLine(scores[targetNumber].Mat);
            }

            foreach (var score in scores) {
                Console.WriteLine("학번:{0} 평균:{1}", score.Key, score.Value.Average);
            }
        }
    }
}
