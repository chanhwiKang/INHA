using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5
{
    internal class Team
    {
        public string Name { get; set; }
        public string Coach { get; set; }
        public int Level { get; set; }
        public string Home { get; set; }

        public string stt {
            get {
                return $"{(Level<5 ? "go":"no")}";
            }
        }

        public Team(string name, string home)
        {
            Name = name;
            Home = home;
        }
        public Team(string name, string coach, int level, string home):this(name, home)
        {
            Coach = coach;
            Level = level;
        }
    }
}
