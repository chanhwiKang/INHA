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
            Dictionary<int, Member> members = new Dictionary<int, Member>();
            members[1] = new Member("김인하", 27, true);
            members.Add(2, new Member("이인하", 22));
                        
            members[1].ChangeGrade();
            members[2].ChangeGrade();

#if false
            foreach (var member in members) {
                Console.WriteLine("등록번호:{0} {1}", member.Key, member.Value.Status);
            }
#else
            foreach (var key in members.Keys) {
                Console.WriteLine("등록번호:{0} {1}", key, members[key].Status);
            }
#endif
        }
    }
}
