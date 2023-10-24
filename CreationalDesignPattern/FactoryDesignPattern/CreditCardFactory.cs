﻿using FactoryDesignPattern.ProblemWithOutFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;
            if(cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }else if(cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            return cardDetails;

        }
    }
}
