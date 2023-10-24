using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
        /*What is the Problem with the above Code Implementation?
         
          The above code implementation introduces the following problems

            First, the Tight Coupling between the client class (Program) and Product Classes (MoneyBack, Titanium, and Platinum).
            So, when we make changes in one class, we must also make changes in the other classes.
            Secondly, suppose we add a new Credit Card.
            In that case, we also need to modify the client code, i.e., the main method of the Program class, by adding an extra IF-ELSE Condition,
            which not only overheads the development but also the testing process.
         */
    }
}
