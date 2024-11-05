using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Bread : Product, IFreshable
    {
        private DateTime _expirationDate;
        public DateTime ExpirationDate { get { return _expirationDate; } }
        public Bread(string name, int price, DateTime dt) : base(name, price)
        {
            _expirationDate = dt;
        }

        public Bread(string name, int price, int quantity, DateTime dt) : base(name, price, quantity)
        {
            _expirationDate = dt;
        }
        public override string ToString()
        {
            return $"{Name},{Price}, {Quantity}, {ExpirationDate}";
        }

    }
}
