using OOP_contd_.models;

namespace OOP_contd_.Interfaces
{
    public interface IAccountService : ITransaction
    {
        //Method overloading examples
        Account GetAccountDetails(string accountNumber);
        Account GetAccountDetails(int accountId);
        Account GetAccountDetails(string accountNumber, string email);
        int GetAccountDetails(string accountNumber, string email, string phoneNumber);
        string GetAccountDetails(string accountNumber, string email, string phoneNumber, string address);

        void CreateAccount(Account account);
        void Deposit(string accountNumber, decimal amount);
        void Withdraw(string accountNumber, decimal amount);
        List<Account> GetAllAccounts();
    }
}
