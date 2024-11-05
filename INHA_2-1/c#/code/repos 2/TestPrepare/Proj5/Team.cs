using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5
{
    internal class Team
    {
        private string _teamName;
        public string TeamName { get; set; }
        private string _coach;
        public string Coach { get; set; }
        private int _level;
        public int Level { get; set; }
        private string _home;
        public string Home { get; set; }

        public string CurrentStatus
        {
            get
            {
                var result = $"{TeamName} is fall baseball {(Level<5?"ok":"no")}";
                return result;
            }
        }

        public void IncreaseLevel(int lvl)
        {
            if (Level - lvl < 0) Level = 1;
            else Level -= lvl;
        }
        public void DecreaseLevel(int lvl)
        {
            if (Level - lvl > 10) Level = 10;
            else Level -= lvl;
        }

        public Team(string teamName, string home)
        {
            TeamName = teamName;
            Home = home;
        }
        public Team(string teamName, string coach, int level, string home):this(teamName, home)
        {
            Coach = coach;
            Level = level;
        }
    }
}
