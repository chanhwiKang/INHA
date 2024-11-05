using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202344073
{
    internal class Program
    {
        static string path = "C:\\testC";
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, FinancialLedger>> ledgers
                = new Dictionary<string, Dictionary<int, FinancialLedger>>();
            ledgers["kim"] = new Dictionary<int, FinancialLedger>();
            ledgers["kim"][2024] = new FinancialLedger(2024, 10_000_000);
            ledgers["kim"][2023] = new FinancialLedger(2023);
            ledgers["lee"] = new Dictionary<int, FinancialLedger>();
            ledgers["lee"][2024] = new FinancialLedger(2024);

            ledgers["kim"][2024].RegIncome(DateTime.Now.AddYears(0),"Salary", 3_000_000);
            ledgers["lee"][2024].RegIncome("Salary", 3_000_000);
            ledgers["lee"][2024].RegExpenditue("Snack", 3_000_000);

            foreach (var person in ledgers) {
                Console.WriteLine(person.Key);
                Console.WriteLine("-----------------------");
                foreach (var ledger in person.Value) {
                    Console.WriteLine($"Year\t\t: {ledger.Key}");
                    Console.WriteLine($"Target\t\t: {ledger.Value.Target}");
                    Console.WriteLine($"Total IN\t: {ledger.Value.TotalIncome}");
                    Console.WriteLine($"Total OUT\t: {ledger.Value.TotalExpenditure}");
                    var isBlack = ledger.Value.IsBlack ? "Yes" : "No";
                    Console.WriteLine($"isBlack\t\t: {isBlack}");
                    Console.WriteLine(ledger.Value.ToString());
                    Console.WriteLine("=======================");
                    foreach (var k in ledger.Value.Incomes){
                        Console.WriteLine(k.Key);
                        Console.WriteLine(k.Value);
                    }
                    foreach (var k in ledger.Value.Expenditures)
                    {
                        Console.WriteLine(k.Key);
                        Console.WriteLine(k.Value);
                    }
                }
            }Console.WriteLine();
            WriteFile(ledgers);
        }

        static bool WriteFile(Dictionary<string, Dictionary<int, FinancialLedger>> list) {
            if (false == Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            if (list == null || list.Count == 0) {
                return false;
            }

            foreach (var person in list) {
                var name = person.Key;
                foreach (var ledger in person.Value) {
                    int year = ledger.Key;
                    if (ledger.Value.Incomes.Count > 0) {
                        var filename1 = Path.Combine(path, $"{name}_{year}_in.txt");
                        using (var sw = new StreamWriter(new FileStream(filename1, FileMode.Create))) { 
                            foreach (var data in ledger.Value.Incomes) {
                                var date = data.Key.ToString("yyyyMMdd HHmmssfff");
                                var content = data.Value.ToString();
                                sw.WriteLine($"{date},{content}");
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
