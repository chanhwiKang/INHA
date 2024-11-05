using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    internal class Address
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
        }

        private static void Test2()
        {
            AddressBook addrBook1 = new AddressBook();
            addrBook1.Name = "aaa";
            addrBook1.Address = "addrA";
            addrBook1.Phone = "010-1111-1111";
            addrBook1.Group = "";

            AddressBook addrBook2 = new AddressBook();
            addrBook1.Name = "bbb";
            addrBook1.Address = "addrB";
            addrBook1.Phone = "010-2111-2111";
            addrBook1.Group = "freind";
        }

        private static void Test1()
        {
            string name1 = "kiminha";
            string addr1 = "micu";
            string phone1 = "010-1111-1111";
            string group1 = "";

            string name2 = "yeeinha";
            string addr2 = "aicu";
            string phone2 = "010-2111-2111";
            string group2 = "freind";

            Console.WriteLine(name1);
            Console.WriteLine(addr2);
        }
    }
}
