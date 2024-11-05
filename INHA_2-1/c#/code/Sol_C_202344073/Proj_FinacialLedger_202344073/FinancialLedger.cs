using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202344073
{
    internal class FinancialLedger : Financial
    {
        private int _year;
        private int _targetAmount = 0;
        public int Year { get { return _year; } }
        public int Target { get { return _targetAmount; } }
        public bool IsBlack { get
            {
                if (Target > 0){
                    if (base.TotalIncome > Target)
                        return true;
                    return false;
                }
                else if (Target == 0)
                {
                    if (base.TotalIncome > base.TotalExpenditure)
                        return true;
                    return false;
                }
                else return false;
            } 
        }

        public FinancialLedger(int year) : this(year, 0) { }
        public FinancialLedger(int year, int targetAmount) { 
            _year = year;
            _targetAmount = targetAmount;
        }
        public override bool RegIncome(DateTime dt, string content, int money)
        {
            if (Year == dt.Year)
                return base.RegIncome(dt, content, money);
            else return false;
        }
        public override bool RegIncome(string content, int money)
        {
            return RegIncome(DateTime.Now, content, money);
        }
        public override bool RegExpenditue(DateTime dt, string content, int money)
        {
            if (Year == dt.Year)
                return base.RegExpenditue(dt, content, money);
            else return false;
        }
        public override bool RegExpenditue(string content, int money)
        {
            return RegExpenditue(DateTime.Now, content, money);
        }
    }
}
