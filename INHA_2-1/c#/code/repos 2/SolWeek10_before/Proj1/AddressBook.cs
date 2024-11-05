using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    //internal struct AddressBook
    class AddressBook : Object 
    {
        private string _name;
        //Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        //private string _group;
        public string Group
        {
            get;// { return _group; }
            set;// { _group = value; }
        }


        public AddressBook()
        {
         
        }

        public AddressBook(string name, string address, string phone, string group)
        {
            _name = name;
            _address = address;
            _phone = phone; 
            Group = group;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("이름:").Append(_name).Append(Environment.NewLine);
            builder.Append("주소:").Append(_address).Append(Environment.NewLine);
            builder.Append("전화:").Append(_phone).Append(Environment.NewLine);
            var group = string.IsNullOrEmpty(Group) ? "없음" : Group;
            builder.Append("그룹:").Append(group).Append(Environment.NewLine);

            return builder.ToString();
        }
    }
}
