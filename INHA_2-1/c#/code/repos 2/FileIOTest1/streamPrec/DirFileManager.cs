using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamPrec
{
    internal class DirFileManager : IDirManager, IFileManager
    {
        private string _dirPath;
        private string _fileName;
        private string _fullName;
        public DirFileManager(string dirPath, string fileName)
        {
            _dirPath = dirPath;
            _fileName = fileName;
            _fullName = Path.Combine(DirPath, FileName);
        }
        public string DirPath { get { return _dirPath; } }
        public string FileName { get { return _fileName; } }
        public string FullName { get { return _fullName; } }
        public void MakeDir()
        {
            if (false == Directory.Exists(DirPath))
            {
                Directory.CreateDirectory(DirPath);
            }
        }

        public void MakeFile()
        {
            if (false == File.Exists(FullName))
            {
                File.CreateText(FullName);
            }
        }

    }
}
