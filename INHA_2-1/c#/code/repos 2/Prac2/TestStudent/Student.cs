using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStudent
{
    internal class Student
    {
        private static int s_count; //현재 학생 총 명수
        private string _id; //학번
        private string _name; //이름
        private string _major; //전공
        private int _level; //학년

        public Student(string name, int level, string major)
        {
            s_count++;
            _name = name;
            _level = level;
            _major = major;
            _id = "S" + s_count.ToString("00000000");
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Grade: ").Append(_level).Append(Environment.NewLine);
            builder.Append("Major: ").Append(_major).Append(Environment.NewLine);
            builder.Append("Id: ").Append(_id).Append(Environment.NewLine);
            builder.Append("Name: ").Append(_name).Append(Environment.NewLine);
            return builder.ToString();
        }
    }
}
