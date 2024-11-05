using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Score
    {
        //필드(field) : class안에 선언한 변수
        public int Kor;
        public int Eng;
        public int Mat;

        // 기본 생성자
        public Score () {
            
        }
        public Score(int k, int e, int m)
        {
            Kor = k;
            Eng = e;
            Mat = m;
        }


        //메소드(method): class안에 선언한 기능(행동)
        //메소드 == 함수(function)
        //public int Average()
        //{
        //    var result = (Kor + Eng + Mat) / 3;
        //    return result;
        //}

        //프로퍼티(속성)
        //내부:메소드 외부:변수
        public int Average
        {
            get {
                return (Kor + Eng + Mat) / 3;
            }
        }
    }
}
