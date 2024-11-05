using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamPrec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirFileManager dfm = new DirFileManager("C:\\testA", "aa.txt");
            dfm.MakeDir();
            dfm.MakeFile();
        }
    }
}
