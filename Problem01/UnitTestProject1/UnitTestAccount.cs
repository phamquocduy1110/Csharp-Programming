using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem01;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }

        [TestMethod]
        public void TestMethodDeposit()
        {
            Account acc = new Account(400000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(400000, acc.Balance());
        }
    }
}
