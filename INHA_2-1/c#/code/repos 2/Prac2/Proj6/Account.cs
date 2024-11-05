using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    internal class Account
    {
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public Account(string number, string owner, decimal balance)
        {
            AccountNumber = number;
            Owner = owner;
            Balance = balance;
        }
        public Account(string number, string owner):this(number, owner, 0) { }
    }
}
