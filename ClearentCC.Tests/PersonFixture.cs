using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ClearentCC.Tests
{
    [TestClass]
    public class PersonFixture
    {
        
        [TestMethod]
        public void Person1Wallet3Cards()
        {
            //arrange 
            CreditCard v1=new CreditCard(100.00D,.1D);
            CreditCard mc1 = new CreditCard(100.00D, .05D);
            CreditCard d1 = new CreditCard(100.00D, .01D);
            List<ICreditCard> cards1 = new List<ICreditCard>
            {
                v1,
                mc1,
                d1
            };
            Wallet wallet1 = new Wallet(cards1);

            List<IWallet> walletList1= new List<IWallet>();
            walletList1.Add(wallet1);

            Person person = new Person(walletList1);

            double expected = 16.00D;
            double expectedCard1 = 10.00D;
            double expectedCard2 = 5.00D;
            double expectedCard3 = 1.00D;
            //act
            double actual = person.SimpleInterest;
            double actualCard1 = v1.SimpleInterest;
            double actualCard2 = mc1.SimpleInterest;
            double actualCard3 = d1.SimpleInterest;
            //assert
            Assert.AreEqual<double>(expected,actual, "Wrong amount for Person1Wallet3Cards Interest");
            Assert.AreEqual<double>(expectedCard1, actualCard1, "Wrong amount for Person1Wallet3Cards Card1 Interest");
            Assert.AreEqual<double>(expectedCard2, actualCard2, "Wrong amount for Person1Wallet3Cards Card2 Interest");
            Assert.AreEqual<double>(expectedCard3, actualCard3, "Wrong amount for Person1Wallet3Cards Card3 Interest");
        }


        [TestMethod]
        public void Person2Wallets()
        {
            //arrange 
            CreditCard visa = new CreditCard(100.00D, .1D);
            CreditCard discover = new CreditCard(100.00D, .01D);
            List<ICreditCard> cards1 = new List<ICreditCard>
            {
                visa,
                discover
            };
            Wallet wallet1 = new Wallet(cards1);


            CreditCard mc = new CreditCard(100.00D,0.05D);
            List<ICreditCard> cards2 = new List<ICreditCard>
            {
                mc
            };
            Wallet wallet2 = new Wallet(cards2);

            List<IWallet> walletList = new List<IWallet>();
            walletList.Add(wallet1);
            walletList.Add(wallet2);

            Person person = new Person(walletList);

            double expectedPersonSimpleInterest = 16.00D;
            double expectedWallet1SimpleInterest = 11.00D;
            double expectedWallet2SimpleInterst = 5.00D;
            //act
            double actual = person.SimpleInterest;
            double actualWallet1 = wallet1.SimpleInterest;
            double actualWallet2 = wallet2.SimpleInterest;
            //assert
            Assert.AreEqual<double>(expectedPersonSimpleInterest, actual, "Wrong amount for Person2Wallets Interest");
            Assert.AreEqual<double>(expectedWallet1SimpleInterest,actualWallet1, "Wrong amount for Person2Wallets Wallet1");
            Assert.AreEqual<double>(expectedWallet2SimpleInterst, actualWallet2, "Wrong amount for Person2Wallets Wallet2");
        }

        [TestMethod]
        public void TwoPeopleWithOneWalletEach()
        {
            //arrange the first person
            CreditCard mc1 = new CreditCard(100.00D, .05D);
            CreditCard mc2 = new CreditCard(100.00D, .05D);
            CreditCard visa1 = new CreditCard(100.00D, .1D);
            List<ICreditCard> cards1 = new List<ICreditCard>
            {
                mc1,
                mc2,
                visa1
            };
            Wallet wallet1 = new Wallet(cards1);
            List<IWallet> walletList1 = new List<IWallet>
            {
                wallet1
            };
            Person person1 = new Person(walletList1);
            double expectedPerson1Interest = 20.00D;
            double expectedWallet1Interest = 20.00D;

            //arrange the second person

            CreditCard mc3 = new CreditCard(100.00D, .05D);
            CreditCard visa2 = new CreditCard(100.00D, .1D);
            List<ICreditCard> cards2 = new List<ICreditCard>
            {
                mc3,
                visa2
            };
            Wallet wallet2 = new Wallet(cards2);
            List<IWallet> walletList2 = new List<IWallet>
            {
                wallet2
            };
            Person person2 = new Person(walletList2);
            double expectedPerson2Interest = 15.00D;
            double expectedWallet2Interest = 15.00D;


            //act
            double actualPerson1Interest = person1.SimpleInterest;
            double actualPerson2Interest = person2.SimpleInterest;

            double actualWallet1Interest = wallet1.SimpleInterest;
            double actualWallet2Interest = wallet2.SimpleInterest;

            //assert
            Assert.AreEqual<double>(expectedPerson1Interest, actualPerson1Interest,"Wrong amount for Person1 Interest");
            Assert.AreEqual<double>(expectedWallet1Interest, actualWallet1Interest, "Wrong amount for Wallet1 Interest");

            Assert.AreEqual<double>(expectedPerson2Interest, actualPerson2Interest, "Wrong amount for Person2 Interest");
            Assert.AreEqual<double>(expectedWallet2Interest, actualWallet2Interest, "Wrong amount for Wallet2 Interest");
        }
    }
}
