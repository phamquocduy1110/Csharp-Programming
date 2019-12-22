using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Account
    {
        private int myAmount = 5000;
        public Account(int amount)
        {
            myAmount = amount;
        }

        public void Deposit(int amount)
        {
            myAmount += amount;
            Console.Write("\nYour Initial Balance Has All Been: " + myAmount);
        }

        public void Withdraw(int amount)
        {
            myAmount = myAmount - amount;
            Console.Write("\nThe Current Balance That You Currently Have: " + myAmount);
        }

        public int Balance()
        {
            Console.Write("\nYour Total Balance Is: " + myAmount);
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
