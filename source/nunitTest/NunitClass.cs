using NUnit.Framework;

namespace nunitTest
{
    public class Tests
    {
        private TestProject.ClassTest account;

        [SetUp]
        public void Setup()
        {
            account = new TestProject.ClassTest(2000);
        }

        [Test]
        public void Adding_funds_updates_Balance()
        {
            //var account = new bankTest.BankAccount(2000);
            account.Add(200);
            Assert.AreEqual(2000, account.Balance);

        }

        [Test]
        public void Withdrawing_funds_updates_Balance()
        {
            account.Withdraw(200);
            Assert.AreEqual(1800, account.Balance);

        }

        [Test]
        public void Transfering_funds_updates_Balance()
        {

            var accountTransfered = new TestProject.ClassTest(1000);
            account.TransferFundsTo(accountTransfered, 200);
            Assert.AreEqual(1200, accountTransfered.Balance);

        }
    }
}