using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class Grill : ICookable
    {
        private Meat _meat;
        public bool InsertMeat(Meat meat)
        {
            if (_meat == null){
                _meat = meat;
                return true;
            }
            else
                return false;
        }

        public Meat GetMeat()
        {
            //_meat에 Meat instance가 없으면 null
            //있으면 해당 인스턴스 return
            //기존 _meat는 초기화시켜야 한다
            if (_meat == null)
                return null;
            else {
                Meat tmp = _meat;
                _meat = null;
                return tmp;
            }
        }

        public void Roast(int stage)
        {
            for (int i = 0; i < stage; i++)
            {
                _meat.AddStage();
            }

        }
    }
}
