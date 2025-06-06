using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class BankAccount
    {
        public int Balance { get; private set; }

        public int Deposit(int amount)
        {
            Balance += amount;
            return Balance;
        }

        public int Withdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("잔고부족");
            }

            Balance -= amount;
            return Balance;
        }
    }
}
