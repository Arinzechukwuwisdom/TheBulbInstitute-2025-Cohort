using Models;

namespace Functionalities
{
    public class General
    {
        private AccountActions accountActions = new AccountActions();
        public List<Account> GetAllAccounts()
        {
            var accounts = accountActions.GetAccounts();
            return accounts.ToList();
        }
    }
}
