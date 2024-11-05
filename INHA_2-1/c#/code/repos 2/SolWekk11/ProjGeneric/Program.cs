using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var moneies = new Money<string>();
            var moneies1 = new Money<int>();
            var moneies2 = new Money<double>(8);
            var moneies3 = new Money<decimal>(12);
        
            for(int i=0; i<10; i++)
            {
                moneies1.Add(i);
                moneies2.Add(i);
                moneies3.Add(i);
            }
            Console.WriteLine(moneies1.CurrentCount);
            Console.WriteLine(moneies2.CurrentCount);
            Console.WriteLine(moneies3.CurrentCount);

            
            try {
                Console.WriteLine("--try1--------------");
                Console.WriteLine(moneies1.GetType1(7));
                Console.WriteLine(moneies2.GetType1(7));
                Console.WriteLine(moneies3.GetType1(7)); 
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                Console.WriteLine("--try2--------------");
                Console.WriteLine(moneies1.GetType1(7));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("--try3--------------");
                Console.WriteLine(moneies2.GetType1(7));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("--try4--------------");
                Console.WriteLine(moneies3.GetType1(7));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int max1=0, min1=0;
            double max2=0.0, min2=0.0;
            if (moneies1.AggregateType1(ref max1, ref min1)) {
                Console.WriteLine($"max1:{max1} min1:{min1}");
            }

            if (moneies2.AggregateType1(ref max2, ref min2)) {
                Console.WriteLine($"max2:{max2} min2:{min2}");
            }
#if false
            decimal max3, min3;
            if (moneies3.AggregateType2(out max3, out min3)) {
                Console.WriteLine($"max3:{max3} min3:{min3}");
            }
#else
            if (moneies3.AggregateType2(out decimal max3, out decimal min3))
            {
                Console.WriteLine($"max3:{max3} min3:{min3}");
            }
#endif

            if (moneies1.GetType2(6, out int result1)) { 
                Console.WriteLine($"result1:{result1}");
            }
            if (moneies2.GetType2(6, out double result2)) {
                Console.WriteLine($"result2:{result2}");
            }
            if (moneies3.GetType2(6, out decimal result3)) {
                Console.WriteLine($"result3:{result3}");
            }
        }
    }
}
