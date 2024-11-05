using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7practice1
{
    internal class Book
    {
        private string _title; //책 이름
        public string Title {
            get { return _title; }
            set { _title = value; }
        }
        private DateTime _rentTime; //대여일
        public DateTime RentTime {
            get { return _rentTime; }
            set { _rentTime = value; }
        }
        private DateTime _returnTime; //반납일
        public DateTime ReturnTime {
            get { return _returnTime; }
            set { _returnTime = value; }
        }
        private string _name; //대여자
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public Book(string title, string name) {
            Title = title;
            Name = name;
        }
        public void ReturnBook() {
            ReturnTime = DateTime.Now;
        }
        public bool IsReturn {
            get {
                return RentTime > ReturnTime;
            }
        }
    }
}
