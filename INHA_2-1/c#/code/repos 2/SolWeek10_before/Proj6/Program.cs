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
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("111 - 1111 - 1", "김인하"));
            accounts.Add(new Account("111 - 1111 - 2", "김인하", 10000000));

            accounts[0].AddBalance(10000);
            accounts[1].SubBalance(100);

#if false
            for (int i = 0; i < accounts.Count; i++) {
                Console.WriteLine("{0}:{1}원", accounts[i].Number, accounts[i].Balance);

            }
#else
            foreach(var account in accounts) {
                Console.WriteLine("{0}:{1}원", account.Number, account.Balance);

            }
#endif
        }
    }
}
