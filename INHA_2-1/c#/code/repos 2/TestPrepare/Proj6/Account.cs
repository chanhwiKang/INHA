using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    internal class Account
    {
        private string _number;
        public string Number { get; set; }
        private string _owner;
        public string Owner { get; set; }
        private decimal _balance;
        public decimal Balance { get; set; }
        
        public bool AddBalance(decimal money){
            Balance += money;
            return true;
        }

        public bool SubBalance(decimal money)
        {
            if (Balance - money < 0) return false;
            Balance -= money;
            return true;
        }

        public Account(string number, string owner, decimal balance)
        {
            Number = number;
            Owner = owner;
            Balance = balance;
        }
        public Account(string number, string owner) : this(number, owner, 0)
        {
        }
    }
}
