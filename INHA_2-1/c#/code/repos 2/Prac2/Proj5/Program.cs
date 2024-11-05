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
            Team team1 = new Team();
            team1.Name = "SSG";
            team1.Coach = "Lee";
            team1.Level = 9;
            team1.Home = "incheon";
            Team team2 = new Team();
            team2.Name = "SAMSUNG";
            team2.Coach = "Park";
            team2.Level = 3;
            team2.Home = "degu";

            Console.WriteLine(team1.Name);
            Console.WriteLine($"{team1.Name} is fall baseball {team1.stt}");
            Console.WriteLine($"{team2.Name} is fall baseball {team2.stt}");
        }
    }
}
