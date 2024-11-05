using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAbstract
{
    
    abstract class Animal
    {
        private int Age { get; set; }// 자동구현 프로퍼티 
        public abstract void Sleep();

        protected int _level;
        public abstract int Level { get; set; }// 추상 프로퍼티
    }
    class Human : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Human Sleep");
        }
        public override int Level
        {
            get { return _level; }
            set
            {
                if (value + _level < 100)
                {
                    _level += value;
                } else
                {
                    _level = 100;
                }
            }
        }
    }
    class Dog : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Dog Sleep");
        }
        public override int Level
        {
            get { return _level; }
            set
            {
                if (value/50 + _level < 100)
                {
                    _level += value;
                }
                else
                {
                    _level = 100;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal human = new Human();
            Animal dog = new Dog();
            human.Sleep();
            dog.Sleep();
        }
    }
}
