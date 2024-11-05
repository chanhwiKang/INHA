using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7practice2
{
    internal class Student
    {
        private static int s_count; //현재 학생 총 명수
        public static int s_Count
        {
            get { return s_count; }
            private set { s_count = value; }
        }
        private string _id; //학번
        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        private string _name; //이름
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _major; //전공
        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }
        private int _level; //학년
        public int Level
        {
            get { return _level; }
            private set { _level = value; }
        }
        public Student(string name, int level, string major) {
            Name = name;
            Level = level;
            Major = major;
            s_Count++;
            Id = "S" + s_Count.ToString("00000000");
        }
        public void PrintStudentInfo() {
            Console.WriteLine($"Level : {Level}");
            Console.WriteLine($"Major : {Major}");
            Console.WriteLine($"Id    : {Id}");
            Console.WriteLine($"Name  : {Name}");
        }
        public bool ChangeGrade(int level)
        {
            if (level > 0 && level < 4)
            {
                Level = level;
                return true;
            }
            else return false;
        }
        public void SetMajor(string major)
        {
            Major = major;
        }
    }
}
