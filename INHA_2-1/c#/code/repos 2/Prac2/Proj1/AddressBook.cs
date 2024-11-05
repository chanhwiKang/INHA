using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    public class AddressBook
    {
        public double Sale = 0.9;
        public int Price = 100;
        public string Name { get; set; }
        public string Address{ get; set; }
        public string Phone { get; set; }
        public string Group { get; set; }

        public AddressBook()
        {

        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Name: ").Append(Name).Append(Environment.NewLine);
            var group = string.IsNullOrEmpty(Group) ? "None" : Group;
            builder.Append("Group: ").Append(Group).Append(Environment.NewLine);

            return builder.ToString();
        }
        public int ads(int num)
        {
            return (int)(num * Price * Sale);
        }
    }
}
