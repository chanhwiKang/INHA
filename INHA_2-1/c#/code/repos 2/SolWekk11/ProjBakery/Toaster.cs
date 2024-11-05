using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class Toaster : ICookable
    {
        private Bread[] _breads; //toaster slot count
        public Toaster(int count)
        {
            // make _breads array
            _breads = new Bread[count];
        }
        public bool InsertBread(Bread bread)
        {
            // 토스터로 빵을 하나 투입
            // 비어있는 슬롯에만 빵을 투입
            // 비어있지 않다면 false return
            for (int i = 0; i < _breads.Length; i++)
            {
                if (_breads[i] == null){
                    _breads[i] = bread;
                    return true;
                }
            }
            return false;
        }
        public Bread GetBread(int index)
        {
            // 토스터에 빵이 있는데
            // 해당 슬롯의 빵을 토출
            // 해당 슬롯에 빵이 없으면 null
            // 빵이 있으면 해당 bread istance return, null 처리까지
            if (_breads[index] != null)
            {
                Bread tmp = _breads[index];
                _breads[index] = null;
                return tmp;
            }
             else 
                return null;
        }

        public void Roast(int stage)
        {
            // stage = 굽기 정도
            // stage에 따라 Bread의 AddStage()를 반복 호출
            for (int i=0; i < stage; i++)
            {
                for (int j=0; j<_breads.Length; j++){
                    if (_breads[j] != null)
                        _breads[j].AddStage();
                }
            }
        }
    }
}
