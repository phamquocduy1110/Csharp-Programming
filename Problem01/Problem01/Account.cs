using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Account
    {
        private int myAmount;
        public Account(int amount)
        {
            myAmount = amount;
        }

        public void Deposit(int amount)
        {
            myAmount += amount;
        }

        public void Withdraw(int amount)
        {
            myAmount = myAmount - amount;
        }

        public int Balance()
        {
            if (myAmount > 0)
            {
                return myAmount;
            }
            else
            {
                return 0;
            }
        }
    }
}
