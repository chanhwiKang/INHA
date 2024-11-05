using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proj8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bus[] buses = new Bus[3];
            for (int i = 0; i < buses.Length; i++)
            {
                buses[i] = new Bus(i);
            }
            Console.WriteLine("차고지 버스 대수:{0}대", Bus.s_total);
            buses[0].SetInTime();
            buses[1].SetInTime();
            buses[2].SetInTime();
            buses[2].SetOutTime();
            Console.WriteLine("차고지 버스 대수:{0}대", Bus.s_total);
            Console.WriteLine(buses[0].IsExist);
            Console.WriteLine(buses[2].IsExist);*/

            Bus[] buses = new Bus[3];
            for (int i = 0; i < buses.Length; i++)
            {
                buses[i] = new Bus(i);
            }
            Console.WriteLine("차고지 버스 대수:{0}대", Bus.s_total);
            buses[0].SetInTime();
            Thread.Sleep(100);
            buses[1].SetInTime();
            Thread.Sleep(200);
            buses[2].SetInTime();
            Thread.Sleep(300);
            buses[2].SetOutTime();
            for (int i = 0; i < buses.Length; i++)
            {
                if (buses[i] != null)
                {
                    var result = buses[i].IsExist ? "있음" : "없음";
                    Console.WriteLine($"{i}번: 차고지에 {result}");
                    var term = buses[i].ParkingTime;
                    Console.WriteLine($"recet parking time: {term :0.00}");
                }
            }
            Console.WriteLine("차고지 버스 대수:{0}대", Bus.s_total);
        }
    }
}
