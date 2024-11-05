using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5
{
    internal class Team
    {
        public string Name;
        public string Coach;
        public int Level;
        public string Home;

        public string CurrentStatus
        {
            get
            {
                var result = $"{Name}은 현재 가을야구 {((Level <= 5) ? "가능" : "불가능")}";
                return result;
            }
        }
    }
}
