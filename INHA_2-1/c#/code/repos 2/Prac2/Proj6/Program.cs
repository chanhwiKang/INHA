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
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("111 - 1111 - 1", "김인하"));

            for (int i =0; i<accounts.Count; i++)
            {
                Console.WriteLine(accounts[i].Owner);
            }
            accounts[0].Balance += 100_000;
            Console.WriteLine(accounts[0].Balance);
        }
    }
}
