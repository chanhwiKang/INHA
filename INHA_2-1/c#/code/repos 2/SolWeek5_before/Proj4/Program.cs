using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Member> memDict = new Dictionary<int, Member>();
            // Member mem1 = new Member("김인하", 27, true);
            // Member mem2 = new Member("이인하", 22);
            memDict[1] = new Member("김인하", 27, true);
            memDict[2] = new Member("이인하", 22);

            memDict[1].ChangeGrade();
            memDict[2].ChangeGrade();

            for (int i=1; i<=memDict.Count; i++) 
                Console.WriteLine(memDict[i].Status);

            foreach (var key in memDict.Keys)
                Console.WriteLine(memDict[key].Status);
            foreach (var val in memDict.Values)
                Console.WriteLine(val.Status);
        }
    }
}
