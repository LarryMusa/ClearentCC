using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClearentCC.Tests
{
    [TestClass]
    public class CreditCardFixture
    {
        [TestMethod]
        public void SimpleInterest()
        {
            //arrange
            double expected = 10.00F;
            CreditCard cc = new CreditCard(100.0, .1);

            //act
            double actual = cc.SimpleInterest;

            //assert
            Assert.AreEqual<double>(expected, actual,"Wrong amount for Credit Card Interest");
        }
    }
}
