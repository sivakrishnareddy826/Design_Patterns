using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ProblemWithOutFactory
{
    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 349;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
