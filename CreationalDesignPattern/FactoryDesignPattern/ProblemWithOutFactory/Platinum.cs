using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ProblemWithOutFactory
{
    public class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 499;
        }

        public string GetCardType()
        {
            return "Platinum Card";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
