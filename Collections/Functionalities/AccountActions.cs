using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionalities
{
    internal class AccountActions
    {
        private readonly List<Account> _accounts;

        public AccountActions()
        {
            _accounts = new List<Account>();
        }

        public Account CreateAccount(string firstname, string lastname, string accountType)
        {
            var accountNumber = GenerateAccountNumber();
            var acccount = new Account
            {
                AccountName = $"{firstname} {lastname}",
                AccountType = accountType,
                AccountNumber = accountNumber,
            };

            _accounts.Add(acccount);
            return acccount;
        }


        private string GenerateAccountNumber()
        {
            Random random = new Random();
            string accountNumber = "";

            for(int i = 0; i < 10; i++)
            {
                accountNumber += random.Next(0, 9);
            }
            return accountNumber;
        }
    }
}
