using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClearentCC.Tests
{
    [TestClass]
    public class WalletFixture
    {
        [TestMethod]
        public void WalletInterest()
        {
            //arrange
            
            List<ICreditCard> creditCards = new List<ICreditCard>();
            ICreditCard visa= new CreditCard(100.00D,.1D);
            ICreditCard mc=new CreditCard(100.00D,.05D);
            ICreditCard discover = new CreditCard(100.00D,.01D);
            creditCards.Add(visa);
            creditCards.Add(mc);
            creditCards.Add(discover);

            Wallet wallet = new Wallet(creditCards);
            double expected = 16.00D;
            //act
            
            double actual = wallet.SimpleInterest;

            //assert
            Assert.AreEqual<double>(expected,actual,"Wrong amount for Wallet Interest");
        }
    }
}
