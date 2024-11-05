using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCommon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // same
            // var targetPath = "c:\\testC";
            var targetPath = @"c:\testC";
#if false
            // make dir1
            DirectoryInfo di = new DirectoryInfo(targetPath);
            if(false == di.Exists){
                di.Create();
            }
#else
            // make dir2
            if (false == Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            else
            {
                //same
                //var secondPath = targetPath + "\\a";
                //var secondPath = targetPath + @"\a";
                var secondPath = Path.Combine(targetPath, "a"); // d^^b!. c:\tectC\a
                if(false == Directory.Exists(secondPath)) {
                    Directory.CreateDirectory(secondPath);
                }
            }
#endif
            var filename1 = "class_c.txt";
            var fullfilename1 = Path.Combine(targetPath, filename1);

            var filename2 = "class_c.bin";
            var fullfilename2 = Path.Combine(targetPath, filename2);

            if (false == File.Exists(fullfilename2)) {
                var fs = File.Create(fullfilename2);
                var datas = BitConverter.GetBytes(1);
                fs.Write(datas, 0, datas.Length);
                fs.Close(); // FileStream.Close()
            }

            if (false == File.Exists(fullfilename1)) {
                // same
                // var fs = File.CreateText(fullfilename1);
                // fs.WriteLine(1);
                // fs.Close(); // StreamWriter.Close()
                using (var fs = File.CreateText(fullfilename1)) {
                    fs.WriteLine(1);
                }
            }

            double value = 1234.56789069;
            byte[] wbytes = BitConverter.GetBytes(value);
            Stream outstream = new FileStream("t.dat", FileMode.Create);
            outstream.Write(wbytes, 0, wbytes.Length);
            outstream.Close();

            byte[] rbytes = new byte[8];
            Stream instream = new FileStream("t.dat", FileMode.Open);
            instream.Read(rbytes, 0, rbytes.Length);
            instream.Close();

            double cnvvalue = BitConverter.ToDouble(rbytes, 0);
            // double cnvvalue = BitConverter.ToSingle(rytes, 0);
            Console.WriteLine(cnvvalue);
        }
    }
}
