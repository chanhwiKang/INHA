using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPolymorphism
{
    class Pet
    {
        public void Sleep()
        {
            Console.WriteLine("Zzzz");
        }
        public virtual void Eat()
        {
            Console.WriteLine("우걱");
        }
    }
    class Cat : Pet
    {
        public new void Sleep()
        {
            Console.WriteLine("골골");
        }
        public override void Eat()
        {
            Console.WriteLine("뇸뇸");
        }
    }
    class Dog : Pet
    {
        public new void Sleep()
        {
            Console.WriteLine("드르렁");
        }
        public new bool Eat()
        {
            Console.WriteLine("냠냠");
            return true;
        }
    }
    class Super
    {
        public int Number = 100;

    }
    class Sub : Super
    {
        public new double Number = 200.2;
        public void Print()
        {
            // this.Number를 shadowing
            decimal Number = 300.3M;
            
            Console.WriteLine(base.Number); // Base class's field
            Console.WriteLine(this.Number); // Derived class's field
            Console.WriteLine(Number); // Method's field

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub();
            Console.WriteLine(sub.Number);
            Console.WriteLine("-------------");

            Super super = (Super)sub;
            Console.WriteLine(super.Number);
            Console.WriteLine("-------------"); 
            sub.Print();

            Pet c = new Cat();
            Pet d = new Dog();
            Console.WriteLine("-------------");
            c.Sleep();
            c.Eat();
            Console.WriteLine("-------------");
            d.Sleep();
            d.Eat();
            Console.WriteLine("-------------");
            ((Cat)c).Sleep();
            ((Cat)c).Eat();
            Console.WriteLine("-------------");
            ((Dog)d).Sleep();
            ((Dog)d).Eat();
        }
    }
}
