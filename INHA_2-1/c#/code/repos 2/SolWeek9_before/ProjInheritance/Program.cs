using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInheritance
{
    class Pet
    {
        public string Name;
        public int Age;
        public void sleep()
        {
            Console.WriteLine("Zzzz");
        }
    }
    class Cat : Pet
    {
        public void Meow()
        {
            Console.WriteLine("Nyan!");
        }
    }
    class Dog : Pet
    {
        public void Bark()
        {
            Console.WriteLine("Bark!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Pet cat = new Cat();
            Pet dog = new Dog();

            Cat c1, c2, c3;
            Dog d1, d2, d3;

            if (pet is Cat)
            {
                c1 = (Cat)pet;
            }
            if (cat is Cat){
                c2 = (Cat)cat;
            }
            if (dog is Cat){
                c3 = (Cat)dog;
            }

            d1 = pet as Dog;
            if (d1 != null) { d1.Bark(); }
            d2 = cat as Dog;
            if (d2 != null) { d2.Bark(); }
            d3 = dog as Dog;
            if (d3 != null) { d3.Bark(); }

            // is+as
            if (pet is Cat c4)
            {
                c4.Meow();
            }
            if (cat is Cat c5)
            {
                c5.Meow();
            }
            if (dog is Cat c6)
            {
                c6.Meow();
            }

            //Cat c = (Cat)d3;
            //Dog d = (Dog)c2;
        }
    }
    
            /*class Top
            {
                public int Age;
                public override string ToString()
                {
                    return Age.ToString();
                }
                public Top(int age) : base()
                {
                    Age = age;
                }

            }
            class Bottom : Top
            {
                *//* public int Age;
                 public override string ToString()
                 {
                     return Age.ToString();
                 }*//*
                public string Name;
                public Bottom(int age, string name) : base(age)
                {
                    Name = name;
                }
                public int NextAge {
                    // 셋 다 가능
                    get { return base.Age + 1; }
                    //get { return this.Age + 1; }
                    //get { return Age + 1; }
                }
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    Top top = new Top(20);
                    Bottom bot = new Bottom(20, "Lee");
                    //top.Age = 3;
                    //bot.Age = 4; // Top이 제공하는 Age

                    //top.Name = "Kim";
                    bot.Name = "Lee";
                    //Console.WriteLine(top.NextAge);
                    Console.WriteLine(bot.NextAge);
                    top.Age = 10;
                    bot.Age = 11;

                    Console.WriteLine();
                    Console.WriteLine(top);
                    Console.WriteLine(bot);

                    Console.WriteLine(top is Top);      //T
                    Console.WriteLine(top is Bottom);   //F
                    Console.WriteLine(bot is Top);      //T
                    Console.WriteLine(bot is Bottom);   //T

                    Console.WriteLine(top is object);   //T
                    Console.WriteLine(bot is object);   //T
                }
        }*/
}
