using DevOpsProject.Controllers;
using NUnit.Framework;

namespace test
{
    public class Test
    {
        private DevOpsProject.Controllers.classTest account;

        [SetUp]
        public void Setup()
        {
            account = new DevOpsProject.Controllers.classTest(2000);
        }

        [Test]
        public void Adding_funds_updates_Balance()
        {
            //var account = new bankTest.BankAccount(2000);
            account.Add(200);
            Assert.AreEqual(2200, account.Balance);

        }

        [Test]
        public void Withdrawing_funds_updates_Balance()
        {
            account.Withdraw(200);
            Assert.AreEqual(1000, account.Balance);

        }

        [Test]
        public void Transfering_funds_updates_Balance()
        {

            var accountTransfered = new DevOpsProject.Controllers.classTest(1000);
            account.TransferFundsTo(accountTransfered, 200);
            Assert.AreEqual(1200, accountTransfered.Balance);

        }
    }
}
