using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team[] teams = new Team[10];
            teams[0] = new Team("SSG", "인천");
            teams[0].Coach = "이숭용";
            teams[0].Level = 9;

            teams[1] = new Team("삼성", "박진만", 3, "대구");

            teams[0].IncreaseLevel(2);
            teams[1].DecreaseLevel(2);

#if false
            for (int i = 0; i < teams.Length; i++) {
                if (teams[i] != null) {
                    Console.WriteLine("{0}-{1}", teams[i].Name, teams[1].CurrentStatus);
                }
            }
#else
            foreach (var team in teams) {
                if (team != null) {
                    Console.WriteLine("{0}-{1}", team.Name, team.CurrentStatus);
                }
            }
#endif
        }
    }
}
