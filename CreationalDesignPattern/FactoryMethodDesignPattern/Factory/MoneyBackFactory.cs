using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            // This way the Creator can stay independent of concrete product classes.
            CreditCard product = new MoneyBack();
            return product;
        }
    }
}
