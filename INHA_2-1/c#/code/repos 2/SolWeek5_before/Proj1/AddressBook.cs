using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    //internal struct AddressBook
    class AddressBook
    {
        public string Name;
        public string Address;
        public string Phone;
        public string Group;

        public AddressBook()
        {

        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("name: ").Append(Name).Append(Environment.NewLine);
            builder.Append("addr: ").Append(Address).Append(Environment.NewLine);
            builder.Append("phone: ").Append(Phone).Append(Environment.NewLine);
            var group = string.IsNullOrEmpty(Group) ? ": None" : ": " + Group;
            builder.Append("group").Append(group).Append(Environment.NewLine);

            return builder.ToString();
        }
    }
    /// <summary>
    /// 아래는 테스트 용
    /// </summary>
    //internal class AddressBook
    //{
    //    string Name;
    //    string Address;
    //    string Phone;
    //    string Group;
    //}
}
