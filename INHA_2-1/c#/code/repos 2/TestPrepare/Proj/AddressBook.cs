using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal class AddressBook
    {
        private string _name;
        public string Name { get; set; }
        private string _address;
        public string Address { get; set; }
        private string _phone;
        public string Phone { get; set; }
        private string _group;
        public string Group { get; set; }

        public AddressBook(){
            
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("name : ").Append(Name).Append(Environment.NewLine);
            builder.Append("address : ").Append(Address).Append(Environment.NewLine);
            builder.Append("phone : ").Append(Phone).Append(Environment.NewLine);
            var group = string.IsNullOrEmpty(Group) ? "nobody" : Group;
            builder.Append("group : ").Append(group).Append(Environment.NewLine);
            return builder.ToString();
        }

    }
}
