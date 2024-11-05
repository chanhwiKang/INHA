using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.Number = "111 - 1111 - 1";
            acc1.Owner = "김인하";
            acc1.Balance = 10_000_000;

            Account acc2 = new Account();
            acc2.Number = "111 - 1111 - 2";
            acc2.Owner = "김인하";
            acc2.Balance = 10_000_000;

            acc1.AddBalance(10000);
            Console.WriteLine(acc1.Balance);
        }
    }
}
