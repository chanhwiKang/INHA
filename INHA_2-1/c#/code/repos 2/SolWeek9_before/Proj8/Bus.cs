using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj8
{
    class Bus
    {
        public static int s_total
        {
            get;
            private set;
        }

        public int Number
        {
            get;
            private set;
        }

        public DateTime InTime
        {
            get;
            private set;
        }

        public DateTime OutTime
        {
            get;
            private set;
        }

        public Bus(int number)
        {
            this.Number = number;
        }

        public void SetInTime()
        {
            this.InTime = DateTime.Now;
            Bus.s_total++;
        }

        public void SetOutTime()
        {
            this.OutTime = DateTime.Now;
            Bus.s_total--;
        }

        public bool IsExist
        {
            get {
                return this.InTime > this.OutTime;
            }
        }

    public double ParkingTime
    {
        get {
            if (IsExist) {
                return (DateTime.Now - this.InTime).TotalMilliseconds;
            } else {
                return (OutTime - InTime).TotalMilliseconds;
            }
        }
    }
    }
}