using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj4
{
    internal class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsRegular { get; set; }

        public Member(string name, int age) {
            Name = name;
            Age = age;
            IsRegular = false;
        }
        public Member(string name, int age, bool isRegular) : this(name, age)
        {
            IsRegular = isRegular;
        }
    }
}
