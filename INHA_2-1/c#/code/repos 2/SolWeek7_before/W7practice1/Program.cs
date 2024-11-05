using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W7practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# Promgramming", "Kim");
            Thread.Sleep(1000);
            book.ReturnBook();
            Console.WriteLine(book.IsReturn);
            if (book.IsReturn)
                Console.WriteLine("No Return");
            else
                Console.WriteLine("Return Comp");
        }
    }
}
