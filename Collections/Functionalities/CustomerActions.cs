using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Functionalities
{
    public class CustomerActions
    {
        private readonly List<Customer> customers;
        private AccountActions accountActions = new AccountActions();
        public CustomerActions()
        {
            this.customers = new List<Customer>();
        }
        public Customer CreateCustomerAccount(Customer customer, string accountType = "Savings")
        {
            var newCustomer = new Customer
            {
                Email = customer.Email,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Phonenumber = customer.Phonenumber,
            };

            var account = accountActions.CreateAccount( newCustomer.Firstname, newCustomer.Lastname, accountType);
            newCustomer.Account = account;
            customers.Add(newCustomer);
            return newCustomer;
        }
        public List<Account> GetAllAccounts() 
        {
            return accountActions.GetAllSomethingSomethingAccounts();
           
        }

        public List<Account> GetAllAccountss() => accountActions.GetAllSomethingSomethingAccounts();
    }
}
