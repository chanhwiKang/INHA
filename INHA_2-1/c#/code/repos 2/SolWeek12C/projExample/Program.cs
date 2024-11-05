using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projExample
{
    class Student
    {
        public int Number;
        public string Name;

        public override string ToString()
        {
            return $"{Number},{Name}";
        }
    }
    internal class Program
    {
        static string path = @"C:\testC";
        static void Main(string[] args)
        {

            var stu1 = new Student() // 생성할때, public field에 값을 바로 넣는다.
            {
                Number = 1,
                Name = "Kim"
            };
            var stu2 = new Student()
            {
                Number = 2,
                Name = "Lee"
            };

            List<Student> students = new List<Student>();
            students.Add(stu1);
            students.Add(stu2);

            CreateIndividual(students);
            CreateAll(students);
        }

        private static void CreateAll(List<Student> students)
        {
            if (students == null) return;
            var filename = Path.Combine(path, "all.txt");
            using (var sw = new StreamWriter(new FileStream(filename, FileMode.Create)))
            {
                foreach(var stu in students){
                    if (stu != null){
                        sw.WriteLine(stu);
                    }
                }
            }
            
        }

        private static void CreateIndividual(List<Student> students)
        {
            if (students == null) return;
            foreach(var stu in students){
                if (stu != null) {
                    var filename = Path.Combine(path, stu.Number + ".txt");
                    using (var sw = new StreamWriter(new FileStream(filename, FileMode.Create))) {
                        sw.WriteLine(stu.Number);
                        sw.WriteLine(stu.Name);
                    }
                    
                }
            }

        }

        static bool ReadIndividual(out List<Student> students)
        {
            //throw new NotImplementedException();
            students = null;
            if (false == Directory.Exists(path)) {
                return false;
            }
            string[] files = Directory.GetFiles(path);
            if (files == null || files.Length == 0) { return false; }
            students = new List<Student>();
            foreach(string file in files) {
                try {
                    using (StreamReader sr = new StreamReader(new FileStream(file, FileMode.Open)))
                    {
                        string read_number = sr.ReadLine();
                        string read_name = sr.ReadLine();
                        if (int.TryParse(read_number, out int number)) {
                            Student st = new Student()
                            {
                                Number = number,
                                Name = read_name.Trim() // 양쪽 끝 공백제거
                            };
                            students.Add(st);
                        }
                    }
                } catch { 
                
                }
            }
            return true;
        }

        static List<Student> ReadAll()
        {
            // throw new NotImplementedException();
            //if (false == Directory.Exists(path)) {
            //    return null;
            //}

            var filename = Path.Combine(path, "all.txt");
            if (false == File.Exists(filename)) {
                return null;
            }

            var students = new List<Student>();
            try { 
                using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
                {
                    while (false == sr.EndOfStream) { 
                        try {
                            string record = sr.ReadLine();
                            string[] fields = record.Split(new char[] { ',' });
                            if (fields.Length == 2)
                            {
                                if (false == int.TryParse(fields[0], out int number)) { continue; }
                                if (true == string.IsNullOrEmpty(fields[1])) { continue; }

                                var name = fields[1].Trim();

                                students.Add(new Student(){
                                    Number = number,
                                    Name = name
                                });
                            }
                        } catch { 
                        
                        }
                    }
                }
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            } return students;
        }
    }
}
