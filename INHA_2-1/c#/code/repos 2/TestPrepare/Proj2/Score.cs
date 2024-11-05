using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Score
    {
        private int _kor;
        public int Kor {
            get
            {
                return _kor;
            }
            set {
                if (value > 100) _kor = 100;
                else if (value < 0) _kor = 0;
                else _kor = value;
            }
        }
        private int _eng;
        public int Eng
        {
            get
            {
                return _eng;
            }
            set
            {
                if (value > 100) _eng = 100;
                else if (value < 0) _eng = 0;
                else _eng = value;
            }
        }
        private int _mat;
        public int Mat
        {
            get
            {
                return _mat;
            }
            set
            {
                if (value > 100) _mat = 100;
                else if (value < 0) _mat = 0;
                else _mat = value;
            }
        }

        public double Average{
            get
            {
                return (Mat + Eng + Kor) / 3;
            }    
        }

        public Score() { }
        public Score(int kor, int mat, int eng)
        {
            Kor = kor;
            Mat = mat;
            Eng = eng;
        }
    }
}
