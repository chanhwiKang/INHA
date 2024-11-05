using System;

namespace Proj4
{
    class Member
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

        public void ChangeGrade()
        {
            IsRegular = !IsRegular;
        }

        #region 생성자 1단계
        //public Member(string name, int age, bool isRegualr = false)
        //{
        //    Name = name;
        //    Age = age;
        //    IsRegular = isRegualr;
        //}
        #endregion

        #region 생성자 2단계
        //public Member(string name, int age, bool isRegualr)
        //{
        //    Name = name;
        //    Age = age;
        //    IsRegular = isRegualr;
        //}
        //
        //public Member(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //    IsRegular = false;
        //}
        #endregion

        #region 생성자 3단계 - type 1
        //public Member(string name, int age, bool isRegualr)
        //{
        //    Name = name;
        //    Age = age;
        //    IsRegular = isRegualr;
        //}
        //
        //public Member(string name, int age)
        //    : this(name, age, false)
        //{
        //    
        //}
        #endregion

        #region 생성자 3단계 - type 2
        public Member(string name, int age, bool isRegualr)
            : this(name, age)
        {
            IsRegular = isRegualr;
        }
        
        public Member(string name, int age)
        {
            Name = name;
            Age = age;
            //IsRegular = false; //원래 IsRegular의 기본값이 false임
        }
        #endregion

    }
}