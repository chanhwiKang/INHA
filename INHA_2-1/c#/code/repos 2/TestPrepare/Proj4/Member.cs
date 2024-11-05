using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj4
{
    internal class Member
    {
        private string _name;
        public string Name { get; set; }
        private int _age;
        public int Age { get; set; }
        private bool _isRegular;
        public bool IsRegular { get; set; }
        public string Status
        {
            get
            {
                return $"{Name} is {(IsRegular ? "정회원" : "준회원")}";
            }
        }
        public void ChangeGrade()
        {
            IsRegular = !IsRegular;
        }

        public Member(string name, int age)
        {
            Name = name;
            Age = age;
            IsRegular = false;
        }
        public Member(string name, int age, bool isRegular): this(name, age){
            IsRegular = isRegular;
        }
    }
}
