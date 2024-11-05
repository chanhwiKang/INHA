using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# 프로그래밍", "김인하");
            book.ReturnBook();
            if (book.IsReturn)
                Console.WriteLine("대출중");
            else
                Console.WriteLine("반납완료");
        }
    }
}
