using System;

namespace Proj4
{
    internal class Member
    {
        public string Name;
        public int Age;
        public bool IsRegular;


        public string Status
        {
            get {
                string type = IsRegular ? "정회원" : "준회원";
                return $"{Name} 회원은 {type} 입니다.";
            }
        }

    }
}