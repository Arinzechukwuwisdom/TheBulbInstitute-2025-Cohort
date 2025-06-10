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
        private static readonly List<Account> _accounts = new List<Account>();
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

        public List<Account> GetAllSomethingSomethingAccounts() 
        { 
            return _accounts.ToList(); 
        }

        public Account GetAccount(string accountNumber)
        {
            return _accounts.SingleOrDefault(x => x.AccountNumber == accountNumber);
        }

        public double CheckAccountBalance(string accountNumber)
        {
            var account = _accounts.SingleOrDefault(x => x.AccountNumber == accountNumber);
            return account.AccountBalance;
        }

        public double Deposit(string accNum, double amount)
        {
            var account = _accounts.SingleOrDefault(x => x.AccountNumber == accNum);
            account.AccountBalance += amount;
            return account.AccountBalance;
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
