using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj8
{
    internal class Bus
    {
        // public static int s_total=0;
        public static int s_total { get; private set; }
        public int Number { get; private set; }
        public DateTime InTime { get; private set; }
        public DateTime OutTime { get ; private set; }
        public double ParkingTime
        {
            get
            {
                /*마지막 또는 현재 차고지에 주차되어 있는 시간을 반환.
                ▪ 차고지에 있는 경우 현재 시간에서 들어온 시간을 뺀다.
                차고지에 나온 경우는 최근 나온 시간에서 최근 들어온 시간을 뺀다.
                ▪ (힌트)DateTime – DateTime => TimeSpan
                ▪ 총 밀리초 : double c = (a – b).TotalMilliseconds;*/

                /*if (IsExist) // 차고지에 있으면 true
                    return (DateTime.Now - InTime).TotalMilliseconds;
                else 
                    return (OutTime - InTime).TotalMilliseconds;
*/
                return IsExist ? (DateTime.Now - InTime).TotalMilliseconds:(OutTime - InTime).TotalMilliseconds;
            }
        }
        public Bus(int number)
        {
            Number = number;
        }
        public void SetInTime()
        {
            InTime = DateTime.Now;
            s_total++;
        }
        public bool IsExist
        {
            // 차고지에 있으면 true
            get { return InTime > OutTime; }
        }
        public void SetOutTime()
        {
            OutTime = DateTime.Now;
            s_total--;
        }

    }
}
