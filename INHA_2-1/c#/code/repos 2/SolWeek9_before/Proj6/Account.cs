using System;

namespace Proj6
{
    class Account
    {
        public string Number { get; private set; }
        public string Owner { get; set; }

        private decimal _balance;
        public decimal Balance { 
            get { return _balance; }
            set {
                if(value >= 0) {
                    _balance = value;
                }
            }
        }

        public bool AddBalance(decimal money)
        {
            if (money <= 0) {
                return false;
            }

            Balance += money;
            return true;
        }

        public bool SubBalance(decimal money)
        {
            if (Balance - money >= 0) {
                Balance -= money;
                return true;
            } else {
                return false;
            }
        }

#if false
        public Account(string number, string owner)
            : this(number, owner, 0)
        {
            
        }

        public Account(string number, string owner, decimal balance)
        {
            Number = number;
            Owner = owner;
            Balance = balance;
        }
#else
        public Account(string number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public Account(string number, string owner, decimal balance)
            : this(number, owner)
        {
            Balance = balance;
        }
#endif
    }
}