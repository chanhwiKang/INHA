using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjGeneric
{
    internal class Money<T>
        where T : struct
    {
        public int MaxCount
        {
            private set; get;
        }
        List<T> _list = new List<T>();
        public int CurrentCount
        {
            get { return _list.Count; }
        }public Money(int maxCount = 5)
        {
            MaxCount = maxCount;
            _list = new List<T>();
        }
        
        public bool Add(T money)
        {
            if (_list.Count < MaxCount)
            {
                _list.Add(money);
                return true;
            }
            else
                return false;
        }

        public T GetType1(int i)
        {
            if (i < _list.Count)
                return _list[i];
            else
                throw new IndexOutOfRangeException();
        }

        public bool GetType2(int i, out T result)
        {
            if (i < _list.Count) {
                result = _list[i];
                return true;
            }
            else {
                result = default(T);
                return false;
            }
        }

        public bool AggregateType1(ref T max, ref T min) {
            Console.WriteLine(max);

            if (_list.Count > 0)
            {
                max = _list.Max();
                min = _list.Min();
                return true;
            }else { return false; }
        }

        public bool AggregateType2(out T max, out T min)
        {
            if (_list.Count > 0)
            {
                max = _list.Max();
                min = _list.Min();
                return true;
            }
            else {
                max = default(T);
                min = default(T);
                return false; 
            }
        }
    }
}
