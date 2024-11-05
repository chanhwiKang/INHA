using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Score
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
    }
}
