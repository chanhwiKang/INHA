using System;

namespace Proj4
{
    internal class Member
    {
        public string Name;
        public int Age;
        public bool IsRegular;
        //public Member (string name, int age, bool isRegular = false)
        //{
         //   Name = name;
         //   Age = age;
         //   IsRegular = isRegular;
        //}

        public Member(string name, int age, bool isRegular):this(name, age) 
            => IsRegular = isRegular;
        public Member(string name, int age) {
            Name = name;
            Age = age;
            IsRegular = false;
        }
        public string Status
        {
            get {
                string type = IsRegular ? "정회원" : "준회원";
                return $"{Name} 회원은 {type} 입니다.";
            }
        }

        public void ChangeGrade()
        {
            IsRegular = !IsRegular;
        }
    }
}