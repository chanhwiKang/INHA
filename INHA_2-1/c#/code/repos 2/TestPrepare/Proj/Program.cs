using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addrBook1 = new AddressBook();
            addrBook1.Name = "Kim";
            addrBook1.Address = "incheon";
            addrBook1.Phone = "010-1111-1111";
            addrBook1.Group = "";

            AddressBook addrBook2 = new AddressBook();
            addrBook2.Name = "Lee";
            addrBook2.Address = "seocheon";
            addrBook2.Phone = "010-1111-1112";
            addrBook2.Group = "friend";

            Console.WriteLine(addrBook1.Name);
            Console.WriteLine(addrBook2.Name);
            Console.WriteLine(addrBook1);
            Console.WriteLine(addrBook2);
        }
    }
}
