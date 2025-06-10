using OOP_contd_.Interfaces;
using OOP_contd_.models;

namespace OOP_contd_.Repository
{
    public class AccountService : IAccountService
    {
        public void AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(int transactionId)
        {
            throw new NotImplementedException();
        }

        public void Deposit(string accountNumber, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountDetails(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountDetails(int accountId)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountDetails(string accountNumber, string email)
        {
            throw new NotImplementedException();
        }

        public int GetAccountDetails(string accountNumber, string email, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionDetails(int transactionId)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetTransactionHistory(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(string accountNumber, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
