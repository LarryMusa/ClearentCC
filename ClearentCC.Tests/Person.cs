using System;
using System.Collections.Generic;

namespace ClearentCC.Tests
{
    public class Person : IPerson
    {
        public List<IWallet> Wallets { get; }
        public double SimpleInterest { get; internal set; }

        public Person(List<IWallet> wallets)
        {
            Wallets = wallets;
            SimpleInterest = GetPersonInterest(wallets);
        }

        public double GetPersonInterest(List<IWallet> walletList)
        {
            double interest = 0;

            foreach (Wallet wallet in walletList)
            {
                interest += wallet.SimpleInterest;
            }

            return interest;
        }
    }
}