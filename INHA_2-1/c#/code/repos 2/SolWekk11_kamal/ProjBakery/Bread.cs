using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class Bread : Food
    {
        public override void AddStage()
        {
            if(_stage < 30)
                _stage++;
        }
    }
}
