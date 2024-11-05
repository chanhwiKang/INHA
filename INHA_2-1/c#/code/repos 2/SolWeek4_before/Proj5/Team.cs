using System;

namespace Proj5
{
    internal class Team
    {
        public string Name;
        public string Coach;
        public int Level;
        public string Home;

        public Team(string name, string home) {
            Name = name;
            Home = home;
        }
        //public Team(string name, string coach, int level, string home):this(name, home)
        public Team(string name, string coach, int level, string home)
        {
            Name = name;
            Home = home;
            Coach = coach;
            Level = level;
        }
        public string CurrentStatus
        {
            get {
                string stt;
                if (Level <= 5) {
                    stt = "가능";
                } else {
                    stt = "불가능";
                }
                return $"{Name}은 현재 가을야구 {stt}";
            }
        }

        public void IncreaseLevel(int value)
        {
            if (Level - value < 1) {
                Level = 1; //강제로 1등
            } else {
                Level -= value;
            }
        }

        //public int LowerLevel = 10;//인스턴스 필드
        public static int LowerLevel = 10;//정적 필드

        public void DecreaseLevel(int value)
        {
            if (Level + value > LowerLevel) {
                Level = LowerLevel;
            } else {
                Level += value;
            }
        }
    }
}