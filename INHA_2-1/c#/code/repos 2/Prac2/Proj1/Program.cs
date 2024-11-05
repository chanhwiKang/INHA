using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addrBook1 = new AddressBook();
            addrBook1.Name = "김인하";
            addrBook1.Address = "인천 미추홀구 용현동";
            addrBook1.Phone = "010 - 1111 - 2221";
            addrBook1.Group = " ";

            AddressBook addrBook2 = new AddressBook();
            addrBook2.Name = "이인하";
            addrBook2.Address = "인천 연수구 동춘동";
            addrBook2.Phone = "010 - 1111 - 2223";
            addrBook2.Group = "친구";

            AddressBook[] addressBooks = { addrBook1, addrBook2 };
            Console.WriteLine(addressBooks[0].Name);
            Console.WriteLine(addressBooks[1].Name);
            Console.WriteLine(addressBooks[0]);
        }
    }
}
