using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace MoqPex
{
    public class AccountService
    {
        private Account _myA = null;
        private Account _myB = null;
        public AccountService(Account a, Account b )
        {
            _myA = a;
            _myB = b;
        }

        public void MakeTransfer(Account sourceAccount, Account destinationAccount, decimal amount)
        {
            if (sourceAccount == null)
            {
                throw new Exception("sourceAcc null");
            }

            if (destinationAccount == null)
            {
                throw new Exception("destionationAcc null");
            }

            if (sourceAccount.Balance < amount )
            {
                throw new Exception("not enough money");
            }

            if(amount < 0) 
            {
                throw new Exception("negative money");
            }

            sourceAccount.Balance = sourceAccount.Balance - amount;
            destinationAccount.Balance = destinationAccount.Balance + amount;
        }

        public decimal ComputeInterest(Account account, double annualRate, int months)
        {
            if (account == null)
            {
                throw new Exception("Account is null");
            }

            double yearInterest = Math.Round((double)account.Balance * annualRate);
            double monthInterest = yearInterest / 12;

            return (decimal)(monthInterest * months);

        }


    }
}