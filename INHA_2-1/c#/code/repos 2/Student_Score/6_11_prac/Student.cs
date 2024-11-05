using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_prac
{
    internal class Student
    {
        private string _name;
        private List<Score> _scores = new List<Score>();
        public string Name { get { return _name; } }
        public double Sum;
        public double Average;

        public Student(string name)
        {
            _name = name;
        }
        public bool RegSubject(string subName)
        {
            foreach(var score in _scores)
            {
                if (score.Subject == subName)
                {
                    return false;
                }
            }
            _scores.Add(new Score(subName));

            return true;
        }
        public bool RegSocre(string subName, double mid, double fin, double att, double hw)
        {
            foreach(var score in _scores)
            {
                if (score.Subject == subName)
                {
                    score.Mid = mid;
                    score.Final = fin;
                    score.Attend = att;
                    score.Homework = hw;
                    Sum += score.Sum();
                    Average = Sum / _scores.Count;
                    return true;
                }
            }
            return false;
        }

        public void ViewScore(string subName)
        {
            foreach (var score in _scores)
            {
                if (score.Subject == subName)
                {
                    Console.WriteLine($"[{score.Subject}]MID: {score.Mid} FIN: {score.Final} ATT: {score.Attend} HW: {score.Homework}");
                }
            }
        }
    }
}
