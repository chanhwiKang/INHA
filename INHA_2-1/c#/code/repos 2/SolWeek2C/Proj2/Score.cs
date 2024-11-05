using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Score
    {
        // field, 클래스 안에 선언한 변수
        public int Kor;
        public int Eng;
        public int Mat;

        // method, 클래스안에 선언하는 기능(행동)
        // public int Average()
        // {
        //     var result = (Kor + Eng + Mat) / 3;
        //     return result;
        // }

        // property(속성)
        // 메소드와 동일한 역활
        // 내부:메소드 외부:변수(필드)
        public int Average
        {
            get
            {
                var result = (Kor + Eng + Mat) / 3;
                return result;
            }

        }
    }
}
