using Kitchen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class BakeryTest
    {
        static void Main(string[] args)
        {
            Bread[] breads = new Bread[4];
            for(int i=0; i < breads.Length; i++) {
                breads[i] = new Bread();
            }

            // 빵을 최대 3개까지 넣을 수 있는…
            Toaster toaster = new Toaster(3);

            toaster.InsertBread(breads[0]);
            toaster.InsertBread(breads[1]);
            toaster.Roast(3); //0번 빵 3단계, 1번 빵 3단계

            toaster.InsertBread(breads[2]);
            toaster.Roast(4); //0번 빵 7단계, 1번 빵 7단계, 2번 빵 4단계

            toaster.InsertBread(breads[3]); // can not insert
            toaster.Roast(5); //0번 빵 12단계, 1번 빵 12단계, 2번 빵 9단계

            toaster.GetBread(1);
            toaster.Roast(3); //0번 빵 15단계, 1번 빵 12단계, 2번 빵 12단계, 3번 빵 0단계
        
            foreach(var bread in breads)
            {
                Console.WriteLine(bread.Stage);
            }

            Meat meat1 = new Meat();
            Meat meat2 = new Meat();
            Grill grill = new Grill();
            grill.InsertMeat(meat1);
            grill.Roast(2);
            grill.GetMeat();

            grill.InsertMeat(meat2);
            grill.Roast(3);
            grill.GetMeat();

            grill.InsertMeat(meat1);
            grill.Roast(4);
            Console.WriteLine($"meat1 : {meat1.Stage}");
            Console.WriteLine($"meat2 : {meat2.Stage}");
        }
    }
}
