using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryTest2nd
{
    class Test
    {
        public static int sTest; //초기화 하지 않으면?
        public int ITest; //초기화 하지 않으면?
        public void LTest()
        {
            int localTest; //초기화 하지 않으면?
            Console.WriteLine(localTest);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.sTest);

            Test t = new Test();
            Console.WriteLine(t.ITest);

            t.LTest();
        }
    }
}
