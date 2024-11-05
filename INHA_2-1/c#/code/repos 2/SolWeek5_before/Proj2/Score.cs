using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    class Score
    {
        public int Kor;
        public int Eng;
        public int Mat;

        public int Average
        {
            get {
                return (Kor + Eng + Mat) / 3;
            }
        }

        public Score()
        {

        }

        public Score(int kor, int eng, int mat)
        {
            Kor = kor;
            Eng = eng;
            Mat = mat;
        }
    }
}
