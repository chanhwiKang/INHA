using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal abstract class Food
    {
        // 굽기 정도
        protected int _stage;
        public int Stage { get { return _stage; } }
        public abstract void AddStage();
        
    }
}
