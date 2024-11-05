using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryTest2nd
{
    internal class Test
    {
        public static int sTest; //초기화를 하지 않으면? -> 0
        public int ITest; //초기화를 하지 않으면? -> 0

        public void LTest()
        {
            int localTest=0; // 초기화를 하지 않으면? -> err, why? = local var
            Console.WriteLine(localTest);

            if (true) {
                int q = 0;
                q++;
            }
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
