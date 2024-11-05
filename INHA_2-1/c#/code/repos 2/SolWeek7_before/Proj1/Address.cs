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
            AddressBook addrBook1 = new AddressBook("김인하", "인천 미추홀","010-1111-1111", "");
            AddressBook addrBook2 = new AddressBook("이인하", "인천 남미추홀", "010-1111-1112", "친구");
            addrBook1.Name = "김땡땡";
            Console.WriteLine(addrBook1.Name);


            AddressBook[] addressBooks = { addrBook1, addrBook2 };

#if true
            for (int i = 0; i < addressBooks.Length; i++) {
                Console.WriteLine(addressBooks[i].ToString());
            }
#else
            for (int i = 0; i < addressBooks.Length; i++) {
                Console.WriteLine(addressBooks[i]);
            }
#endif
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
