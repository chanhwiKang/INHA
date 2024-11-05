using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Product
    {
        private string _name;
        private int _price;
        private int _quantity;

        public string Name { get { return _name; } }
        public int Price { get { return _price; } }
        public int Quantity { get { return _quantity; } }

        public Product(string name, int price) : this(name, price, 0)
        {

        }
        public Product(string name, int price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name},{Price},{Quantity}";
        }
    }
}
