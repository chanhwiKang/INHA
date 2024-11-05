using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("kang");
            Console.WriteLine(stu.RegSubject("Kor"));
            Console.WriteLine(stu.RegSubject("Eng"));
            Console.WriteLine(stu.RegSubject("Kor"));
            //stu.RegSocre("Kor", mid = 35, fin = 35, att = 15, hw = 15);
            stu.RegSocre("Kor", mid : 35, fin : 35, att : 15, hw : 15);
            stu.RegSocre("Eng", 30, 30, 15, 15);
            Console.WriteLine(stu.Name);
            stu.ViewScore("Kor");
            stu.ViewScore("Eng");
            Console.WriteLine(stu.Sum);
            Console.WriteLine(stu.Average);
        }
    }
}
