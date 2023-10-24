using FactoryDesignPattern.ProblemWithOutFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your Card Type here: ");
            string cardType = Console.ReadLine();
            CreditCard cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }else if(cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid card Type");
            }
            Console.WriteLine("***********Now Using Factory Design Pattern***********");
            Console.WriteLine("Please Enter your credit card type here: ");
            string card = Console.ReadLine();
            CreditCard cardDetail = CreditCardFactory.GetCreditCard(card);

            if (cardDetail != null)
            {
                Console.WriteLine("CardType : " + cardDetail.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetail.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetail.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
