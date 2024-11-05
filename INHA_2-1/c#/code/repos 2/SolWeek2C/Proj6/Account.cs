using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    internal class Account
    {
        public string Number;
        public string Owner;
        public decimal Balance;

        public void AddBalance(decimal money)
        {
            Balance += money;
        }
    }
}
