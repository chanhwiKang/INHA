using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBook
{
    internal class Book
    {
        private string _title;
        public string Title { get { return _title; } }
        private DateTime _rentTime;
        private DateTime _returnTime;
        private string _name;

        public Book(string title, string name)
        {
            _title = title;
            _name = name;
            _rentTime = DateTime.Now;
        }
        public void ReturnBook()
        {
            _returnTime = DateTime.Now;
        }
        public bool IsReturn
        {
            get
            {
                return !(_returnTime > _rentTime);
            }
        }
    }
}
