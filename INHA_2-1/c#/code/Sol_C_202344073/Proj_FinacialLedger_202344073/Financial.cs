using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202344073
{
    internal class Financial
    {
        protected Dictionary<DateTime, Info> _incomes = new Dictionary<DateTime, Info>();
        protected Dictionary<DateTime, Info> _expenditures = new Dictionary<DateTime, Info>();
        public IReadOnlyDictionary<DateTime, Info> Incomes { get { return _incomes; } }
        public IReadOnlyDictionary<DateTime, Info> Expenditures { get { return _incomes; } }
        public int TotalIncome
        {
            get
            {
                int sum = 0;
                foreach (var info in _incomes.Values)
                    sum += info.Money;
                
                return sum;
            }
        }
        public int TotalExpenditure
        {
            get
            {
                int sum = 0;
                foreach (var info in _expenditures.Values)
                    sum += info.Money;
                return sum;
            }
        }

        public virtual bool RegIncome(DateTime dt, string content, int money) {
            if (money >= 0){
                _incomes[dt] = new Info(content, money);
                return true;
            }
            return false;
        }
        public virtual bool RegIncome(string content, int money) {
                return RegIncome(DateTime.Now, content, money);
        }
        public virtual bool RegExpenditue(DateTime dt, string content, int money) {
            if (money >= 0) {
                _expenditures[dt] = new Info(content, money);
                return true;
            }
            return false;
        }
        public virtual bool RegExpenditue(string content, int money) {
            return RegExpenditue(DateTime.Now, content, money);
        }
    }
}
