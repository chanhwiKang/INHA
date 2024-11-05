#define TEST1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjInheritance
{
#if TEST1

    class Top
    {
        public int Age;
        public override string ToString()
        {
            return Age.ToString();
        }
    }

    class Bottom : Top
    {
        //public int Age;
        //public override string ToString()
        //{
        //    return Age.ToString();
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top();
            Bottom bottom = new Bottom();
            top.Age = 20;
            bottom.Age = 21;

            Console.WriteLine(top);
            Console.WriteLine(bottom);
        }
    }
#elif TEST2
//생성자, 종료자
    class Top
    {
        public Top()
        {
            Console.WriteLine("Top 생성자");
        }

        ~Top()
        {
            Console.WriteLine("Top 종료자");
        }
    }

    class Bottom : Top
    {
        public Bottom()
        {
            Console.WriteLine("Bottom 생성자");
        }

        ~Bottom()
        {
            Console.WriteLine("Bottom 종료자");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bottom bottom = new Bottom();
        }
    }
    

#elif TEST3

    class Top : Object
    {
        public int Age;
        public override string ToString()
        {
            return Age.ToString();
        }
    }

    class Bottom : Top
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top();
            Bottom bottom = new Bottom();
            top.Age = 20;
            bottom.Age = 21;

            Console.WriteLine(top);
            Console.WriteLine(bottom);

            Console.WriteLine(top is Top);      //True
            Console.WriteLine(top is Bottom);   //False
            Console.WriteLine(bottom is Top);   //True
            Console.WriteLine(bottom is Bottom);//True

            Console.WriteLine(top is Object);     //True
            Console.WriteLine(bottom is Object);  //True
        }
    }
#elif TEST4
 class Top : Object
    {
        public int Age;
        public override string ToString()
        {
            return Age.ToString();
        }
    }

    class Bottom : Top
    {
        public string Name;
        public int NextAge
        {
            get { return base.Age + 1; }
            //get { return this.Age + 1; }
            //get { return Age + 1; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top();
            Bottom bottom = new Bottom();
            top.Age = 20;
            bottom.Age = 21;//Top이 제공하는 Age

            Console.WriteLine(top);
            Console.WriteLine(bottom);

            Console.WriteLine(top is Top);      //True
            Console.WriteLine(top is Bottom);   //False
            Console.WriteLine(bottom is Top);   //True
            Console.WriteLine(bottom is Bottom);//True

            Console.WriteLine(top is Object);     //True
            Console.WriteLine(bottom is Object);  //True
        }
    }
#elif TEST5

    class Top : Object
    {
        public Top() : base()
        {

        }

        public int Age;
        public override string ToString()
        {
            return Age.ToString();
        }
    }

    class Bottom : Top
    {
        public Bottom() : base()
        {

        }

        public string Name;
        public int NextAge
        {
            get { return base.Age + 1; }
            //get { return this.Age + 1; }
            //get { return Age + 1; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top();
            Bottom bottom = new Bottom();
            top.Age = 20;
            bottom.Age = 21;

            Console.WriteLine(top);
            Console.WriteLine(bottom);

            Console.WriteLine(top is Top);      //True
            Console.WriteLine(top is Bottom);   //False
            Console.WriteLine(bottom is Top);   //True
            Console.WriteLine(bottom is Bottom);//True

            Console.WriteLine(top is Object);     //True
            Console.WriteLine(bottom is Object);  //True
        }
    }
#elif TEST6

    class Top : Object
    {
        public Top(int age) : base()
        {
            Age = age;
        }
        public int Age;
        public override string ToString()
        {
            return Age.ToString();
        }
    }

    class Bottom : Top
    {
        public Bottom(int age, string name)
            : base(age)
        {
            Name = name;
        }

        public string Name;
        public int NextAge
        {
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
            Bottom bottom = new Bottom(21, "ggg");
            //top.Age = 20;
            //bottom.Age = 21;//Top이 제공하는 Age

            top.Name = "김바닥";
            bottom.Name = "이바닥";

            Console.WriteLine(top.NextAge);
            Console.WriteLine(bottom.NextAge);

            top.Age = 10;
            bottom.Age = 11;

            Console.WriteLine(top);
            Console.WriteLine(bottom);

            Console.WriteLine(top is Top);      //True
            Console.WriteLine(top is Bottom);   //False
            Console.WriteLine(bottom is Top);   //True
            Console.WriteLine(bottom is Bottom);//True

            Console.WriteLine(top is Object);     //True
            Console.WriteLine(bottom is Object);  //True
        }
    }
#elif TEST7

    class Pet
    {
        public string Name;
        public int Age;
        public void Sleep()
        {
            Console.WriteLine("Zzzz");
        }
    }

    class Dog : Pet
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Pet
    {
        public void Meow()
        {
            Console.WriteLine("냐옹");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Pet cat = new Cat();
            Pet dog = new Dog();

            var c1 = (Cat)pet;
            var c2 = (Cat)cat;
            var c3 = (Cat)dog;
            //var c4 = (Cat)((Pet)c2);

            var d1 = (Dog)pet;
            var d2 = (Dog)cat;
            var d3 = (Dog)dog;

            Cat c = (Cat)d3;
            Dog d = (Dog)c2;
        }
    }
#elif TEST8

    class Pet
    {
        public string Name;
        public int Age;
        public void Sleep()
        {
            Console.WriteLine("Zzzz");
        }
    }

    class Dog : Pet
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Pet
    {
        public void Meow()
        {
            Console.WriteLine("냐옹");
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

            if (pet is Cat) {
                c1 = (Cat)pet;
            }
            if (cat is Cat) {
                c2 = (Cat)cat;
            }
            if (dog is Cat) {
                c3 = (Cat)dog;
            }

            d1 = pet as Dog;
            if (d1 != null) {
                d1.Bark();
            }
            d2 = cat as Dog;
            if (d2 != null) {
                d2.Bark();
            }
            d3 = dog as Dog;
            if (d3 != null) {
                d3.Bark();
            }

            //변수선언+is+as 혼합형태
            if (pet is Cat c4) {
                c4.Meow();
            }
            if (cat is Cat c5) {
                c5.Meow();
            }
            if (dog is Cat c6) {
                c6.Meow();
            }
        }
    }
#elif TEST9

    class A
    {
        private int _a;
        protected int _b;
        public int C;
        public void PrintA()
        {
            Console.WriteLine(this._a);
            Console.WriteLine(this._b);
            Console.WriteLine(this.C);
        }
    }

    class B : A
    {
        public void PrintB()
        {
            Console.WriteLine(base._a);
            Console.WriteLine(base._b);
            Console.WriteLine(base.C);
        }
    }

    class C
    {
        public void PrintC()
        {
            B b = new B();
            Console.WriteLine(b._a);
            Console.WriteLine(b._b);
            Console.WriteLine(b.C);
        }
    }
#elif TEST10
    class Pet
    {
        private string _name;
        protected string Name
        {
            get {
                return _name;
            }
        }
        protected int _age;
        public int Age
        {
            get { return _age; }
        }

        public Pet(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzz");
        }
    }

    class Cat : Pet
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }
        public void Meow()
        {
            //Console.WriteLine(_name);//private field
            Console.WriteLine(Name);//protected property

            Console.WriteLine(_age);
            Console.WriteLine("냐옹");
        }
    }


    class Dog : Pet
    {
        public Dog(string name, int age)
            : base(name, age)
        {

        }

        public void Bark()
        {
            Console.WriteLine(Name);
            Console.WriteLine(_age);
            Console.WriteLine("멍멍");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet("김펫", 2);
            Pet cat = new Cat("김냥", 3);
            Pet dog = new Dog("김멍", 5);

            cat.Meow();
            ((Cat)cat).Meow();
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);

            dog.Bark();
            ((Dog)dog).Bark();
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Age);
        }
    }
#endif
}