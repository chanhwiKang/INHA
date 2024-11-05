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
            Team[] team = new Team[10];
            Team team1 = new Team("SSG", "인천");
            team1.Coach = "이숭용";
            team1.Level = 9;
            team[0] = team1;

            Team team2 = new Team("삼성","박진만",3,"대구");
            team[1] = team2;

            team1.IncreaseLevel(2);
            team1.DecreaseLevel(2);

            // Console.WriteLine(team1.Name);
            // Console.WriteLine(team1.CurrentStatus);

            for (int i=0; i<team.Length; i++)
            {
                if (team[i] != null)
                {
                    Console.WriteLine(team[i].Name);
                    Console.WriteLine(team[i].CurrentStatus);
                }
            }
            foreach (var t in team)
            {
                if (t != null)
                {
                    Console.WriteLine(t.Name);
                    Console.WriteLine(t.CurrentStatus);
                }
            }
        }
    }
}
