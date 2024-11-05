using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class Meat : Food
    {
        public override void AddStage()
        {
            if (_stage < 50)
                _stage++;

        }
    }
}
