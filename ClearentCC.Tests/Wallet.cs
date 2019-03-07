using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace ClearentCC.Tests
{
    internal class Wallet: IWallet
    {
        public List<ICreditCard> CreditCards { get; }
        public Double SimpleInterest { get; }

        public Wallet(List<ICreditCard> creditCards)
        {
            CreditCards = creditCards;
            SimpleInterest = GetWalletInterest(creditCards);
        }

       
        public double GetWalletInterest(List<ICreditCard> creditCards)
        {
            double interest = 0;
            foreach (CreditCard cc in creditCards)
            {
                interest += cc.GetInterest(cc.Amount,cc.InterestRate);
            }

            return interest;
        }
    }
}