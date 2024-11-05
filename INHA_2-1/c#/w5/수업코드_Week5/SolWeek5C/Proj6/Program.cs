using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("111 - 1111 - 1", "김인하");
            Account acc2 = new Account("111 - 1111 - 2", "김인하", 10000000);

            acc1.AddBalance(10000);
            acc2.SubBalance(100);
            Console.WriteLine(acc1.Balance);
        }
    }
}
