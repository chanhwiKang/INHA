using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Product1
    {
        public string Name;
        public int Price;
        public int Quantity;

        public Product1 (string name, int price)
        {
            Name = name;
            Price = price;
            Quantity = 0;
        }
        public Product1 (string name, int price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name},{Price},{Quantity}";
        }
    }
}
