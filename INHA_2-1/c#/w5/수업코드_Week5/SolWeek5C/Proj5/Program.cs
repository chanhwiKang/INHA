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
            Team team1 = new Team("SSG", "인천");
            team1.Coach = "이숭용";
            team1.Level = 9;

            Team team2 = new Team("삼성","박진만",3,"대구");

            team1.IncreaseLevel(2);
            team1.DecreaseLevel(2);

            Console.WriteLine(team1.Name);
            Console.WriteLine(team1.CurrentStatus);

        }
    }
}
