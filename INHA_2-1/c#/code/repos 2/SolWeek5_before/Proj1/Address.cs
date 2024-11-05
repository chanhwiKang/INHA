using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
            addrBook1.Name = "김인하";
            addrBook1.Address = "인천 미추홀";
            addrBook1.Phone = "010-1111-1111";
            addrBook1.Group = "";

            AddressBook addrBook2 = new AddressBook();
            addrBook2.Name = "이인하";
            addrBook2.Address = "인천 남미추홀";
            addrBook2.Phone = "010-1111-1112";
            addrBook2.Group = "친구";

            AddressBook[] addressBooks = { addrBook1, addrBook2 };

            for (int i = 0; i < addressBooks.Length; i++)
                Console.WriteLine(addressBooks[i]);
        }

        private static void Test1()
        {
            string name1 = "김인하";
            string addr1 = "인천 미추홀";
            string phone1 = "010-1111-1111";
            string group1 = "";

            string name2 = "이인하";
            string addr2 = "인천 남미추홀";
            string phone2 = "010-2111-1111";
            string group2 = "친구";

            Console.WriteLine(name1);
            Console.WriteLine(addr2);
        }
    }
}
