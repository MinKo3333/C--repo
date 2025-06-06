using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    internal class BankAccountTest
    {
        [Test]
        public void Test()
        {
            var account = new BankAccount();
            

            Assert.Throws<InvalidOperationException>(() =>
                {
                    account.Deposit(10);
                    account.Withdraw(12);
                }
            );
        }
    }
}
