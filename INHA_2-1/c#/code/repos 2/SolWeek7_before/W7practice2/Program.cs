using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("김인하", 1, "컴퓨터정보");
            s.PrintStudentInfo();
            s.ChangeGrade(2);
            s.PrintStudentInfo();
            Console.WriteLine("총 인원수:{0}", Student.s_Count);
            s.SetMajor("정보통신");
            Console.WriteLine("{0}의 학과는{1} 입니다.", s.Name, s.Major);
        }
    }
}
