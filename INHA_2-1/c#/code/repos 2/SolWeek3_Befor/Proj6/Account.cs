using System;

namespace Proj6
{
    internal class Account
    {
        public string Number;
        public string Owner;
        public decimal Balance;

        public bool AddBalance(decimal money)
        {
            if (money < 0) {
                return false;
            }
            Balance += money;
            return true;
        }
    }
}