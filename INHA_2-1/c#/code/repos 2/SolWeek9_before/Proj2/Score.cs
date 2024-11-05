using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    class Score
    {
        private static int s_min = 0;
        private static int s_max = 100;

        private int _kor;
        private int _eng;
        private int _mat;

        public int Kor
        {
            get { return _kor; }
            set {
                _kor = ValidScore(value);
            }
        }

        public int Eng
        {
            get { return _eng; }
            set {
                _eng = ValidScore(value);
            }
        }

        public int Mat
        {
            get { return _mat; }
            set {
                _mat = ValidScore(value);
            }
        }
        
        public int ValidScore(int score)
        {
            int result = score;
            if (score < s_min) {
                result = s_min;
            } else if (score > s_max) {
                result = s_max;
            }
            return result;                
        }

        public int Average
        {
            get {
                return (_kor + _eng + _mat) / 3;
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
