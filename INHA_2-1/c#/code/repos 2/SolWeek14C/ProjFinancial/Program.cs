using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Financial;


namespace ProjFinancial
{
    internal class Program
    {
        // instance feild
        string path1 = "C:\\testC";
        
        static string path = "C:\\testC";
        static void Main(string[] args)
        {
            // static method에서 instance field사용 불가
            //var i = path1;

            var i = path;
            // ledgers['name', ['year', financial(input dict, output dict)]]
            Dictionary<string, Dictionary<int, FinancialLedger>> ledgers = new Dictionary<string, Dictionary<int, FinancialLedger>>();
            
            if (false == ReadFile(ledgers)) {
                ledgers["kim"] = new Dictionary<int, FinancialLedger>();
                ledgers["kim"][2024] = new FinancialLedger(2024, 10_000_000);
                ledgers["lee"] = new Dictionary<int, FinancialLedger>();
                ledgers["lee"][2024] = new FinancialLedger(2024);

                ledgers["kim"][2024].RegIncome("salay", 3_000_000);
                Thread.Sleep(100);
                ledgers["lee"][2024].RegIncome("salay", 3_000_000);
                Thread.Sleep(100);
                ledgers["lee"][2024].RegExpenditue("snack", 30_000);
                Thread.Sleep(100);
                ledgers["lee"][2024].RegIncome("study", 1_000_000);
            }

            Console.WriteLine("신규 입력을 하시겠습니까? (y, n)");
            var input = Console.ReadLine().ToLower().Trim();

            while (input == "y") {
                Console.WriteLine("1. 신규 가계부 생성");
                Console.WriteLine("2. 기존 가계부 작성");
                Console.WriteLine("3. 기존 가계부 조회");
                Console.WriteLine("9. 종료");

                Console.WriteLine("> ");
                var menu = Console.ReadLine().Trim();

                string name, year;
                int realYear;

                switch (menu) {
                    case "1":
                        Console.Write("Name: ");
                        name = Console.ReadLine().Trim();
                        Console.Write("Year: ");
                        year = Console.ReadLine().Trim();
                        if (int.TryParse(year, out realYear))
                        {
                            if (true == ledgers.ContainsKey(name) && ledgers[name].ContainsKey(realYear)) {
                                Console.WriteLine("해당 가계부 있음");
                            }
                            else {
                                if (false == ledgers.ContainsKey(name)) {
                                    ledgers[name] = new Dictionary<int, FinancialLedger>();
                                    ledgers[name][realYear] = new FinancialLedger(realYear);
                                } else {
                                    ledgers[name][realYear] = new FinancialLedger(realYear);
                                }
                                Console.WriteLine("신규 가계부 생성");
                            }
                        }
                        break;
                    case "2":
                        Console.Write("Name: ");
                        name = Console.ReadLine().Trim();
                        Console.Write("Year: ");
                        year = Console.ReadLine().Trim();
                        if (int.TryParse(year, out realYear))
                        {
                            if (true == ledgers.ContainsKey(name) && ledgers[name].ContainsKey(realYear)) {
                                Console.WriteLine("수입(1), 지출(2): ");
                                var type = Console.ReadLine().Trim();
                                if (type == "1" || type == "2") {
                                    Console.WriteLine("내역: ");
                                    var content = Console.ReadLine().Trim();
                                    Console.WriteLine("금액: ");
                                    var money = Console.ReadLine().Trim();
                                
                                    if (int.TryParse(money, out int realmoney) && realmoney >= 0) { 
                                        if (type == "1") {
                                            ledgers[name][realYear].RegIncome(content, realmoney);
                                        } else { 
                                            ledgers[name][realYear].RegExpenditue(content, realmoney);
                                        }
                                    }
                                }
                            }
                            else {
                                Console.WriteLine("해당 가계부 없음");
                            }
                        }
                        break;
                    case "3":
                        Console.Write("Name: ");
                        name = Console.ReadLine().Trim();
                        Console.Write("Year: ");
                        year = Console.ReadLine().Trim();
                        if (int.TryParse(year, out realYear)) { 
                            if (true == ledgers.ContainsKey(name) && ledgers[name].ContainsKey(realYear)) {
                                // 구현할 것 아래 코드 이용
                                foreach (var person in ledgers)
                                {
                                    Console.WriteLine(person.Key);
                                    foreach (var ledger in person.Value)
                                    {
                                        Console.WriteLine($"Year: {ledger.Key}");
                                        Console.WriteLine($"Total In: {ledger.Value.TotalIncome}");
                                        Console.WriteLine($"Total Out: {ledger.Value.TotalExpenditure}");
                                        var isBlack = ledger.Value.IsBlack ? "Yes" : "No";
                                        Console.WriteLine($"Black: {isBlack}");
                                        Console.WriteLine();
                                    }
                                }
                            } else {
                                Console.WriteLine("해당 가계부 없음");
                            }
                        }
                        break;
                    case "9":
                        input = "n";
                        break;
                }
            }

            foreach (var person in ledgers) {
                Console.WriteLine(person.Key);
                foreach (var ledger in person.Value) {
                    Console.WriteLine($"Year: {ledger.Key}");
                    Console.WriteLine($"Total In: {ledger.Value.TotalIncome}");
                    Console.WriteLine($"Total Out: {ledger.Value.TotalExpenditure}");
                    var isBlack = ledger.Value.IsBlack ? "Yes" : "No";
                    Console.WriteLine($"Black: {isBlack}");
                    Console.WriteLine();
                }
            }
            WriteFile(ledgers);
        }
    
        static bool ReadFile(Dictionary<string, Dictionary<int, FinancialLedger>> list)
        {
            DirectoryInfo dinfo = new DirectoryInfo(path);
            if (false == dinfo.Exists)
                return false;
            FileInfo[] files = dinfo.GetFiles();
            if (files == null || files.Length == 0)
                return false;

            foreach (var file in files) { 
                // kim_2024_in.txt
                // 확장차 체크
                if (false == file.Name.EndsWith(".txt"))  //  if (false == file.FullName.EndsWith(".txt")) {
                    continue;
                
                var fname = Path.GetFileNameWithoutExtension(file.Name); // kim_2024_in
                var split_names = fname.Split(new char[] { '_' }); // ["kim", "2024", "in"]
                if (split_names == null || split_names.Length != 3)
                    continue;

                var name = split_names[0].Trim(); // 0번 인덱스의 체크
                if (string.IsNullOrEmpty(name)) { 
                    continue;
                }

                if (false == int.TryParse(split_names[1], out int year)) { // 1번 인덱스의 int type check
                    continue;
                }

                string type = split_names[2].Trim().ToLower(); // 2번 인덱스의 "in" or "out" check
                if (type != "in" && type != "out") {
                    continue;
                }

                if (false == list.ContainsKey(name)) {
                    list[name] = new Dictionary<int, FinancialLedger>();
                    list[name][year] = new FinancialLedger(year);
                } else if (false == list[name].ContainsKey(year)) { // "kim"의 가계부는 있으나, 연도가 지났을 경우
                    list[name][year] = new FinancialLedger(year);
                }

                var fullFileName = file.FullName;
                using (StreamReader sr = new StreamReader(new FileStream(fullFileName, FileMode.Open))) { 
                    while (false == sr.EndOfStream) {
                        var record = sr.ReadLine();
                        if (string.IsNullOrEmpty(record)) {
                            continue;
                        }

                        // 20240605 105220022, Salary, 3000000 -> ["20240605 105220022", "Salary", "3000000"]
                        var fields = record.Split(new char[] { ',' });

                        if (fields == null || fields.Length != 3) {
                            continue;
                        }

                        // 0번 인덱스를 DateTime type으로 parsing
                        var datetime = DateTime.ParseExact(fields[0],"yyyyMMdd HHmmssfff", CultureInfo.InvariantCulture);

                        string content = fields[1].Trim(); // 1번 인덱스 트림만 하고 끝
                    
                        if (false == int.TryParse(fields[2], out int money)) {// 2번 TryParse로 정상 여부 확인
                            continue;
                        }

                        if (type == "in")
                        {
                            list[name][year].RegIncome(datetime, content, money);
                        } else {
                            list[name][year].RegExpenditue(datetime, content, money);
                        }
                    }
                }
            }
            return true;
        }

        static bool WriteFile(Dictionary<string, Dictionary<int, FinancialLedger>> list)
        {
            if (false == Directory.Exists(path)) 
                Directory.CreateDirectory(path);
            if (list == null || list.Count == 0)
                return false;

            foreach (var person in list) {
                // kim_2024_in.txt
                // kim_2024_out.txt
                var name = person.Key;
                foreach (var ledger in person.Value) {
                    int year = ledger.Key;
                    if(ledger.Value.Incomes.Count > 0) {
                        var filename1 = Path.Combine(path, $"{name}_{year}_in.txt");
                        using (var sw = new StreamWriter(new FileStream(filename1, FileMode.Create)))
                        {
                            foreach (var data in ledger.Value.Incomes)
                            {
                                var date = data.Key.ToString("yyyyMMdd HHmmssfff");
                                var content = data.Value.ToString();
                                sw.WriteLine($"{date},{content}");
                                //20240605 105220022, Salary, 3000000
                            }
                        }
                    }

                    if (ledger.Value.Expenditures.Count > 0)
                    {
                        var filename2 = Path.Combine(path, $"{name}_{year}_out.txt");
                        using (var sw = new StreamWriter(new FileStream(filename2, FileMode.Create)))
                        {
                            foreach (var data in ledger.Value.Expenditures)
                            {
                                var date = data.Key.ToString("yyyyMMdd HHmmssfff");
                                var content = data.Value.ToString();
                                sw.WriteLine($"{date},{content}");
                                //20240605 105220022, Salary, 3000000
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
