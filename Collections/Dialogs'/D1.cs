
using Functionalities;
using Models;

namespace Dialogs_
{
    public class D1
    {
        public void EntryDialog()
        {
            Console.WriteLine("Welcome to Jaiye Jaiye Bank");
            Thread.Sleep(3000);
            Console.WriteLine("We launder money here");
            Thread.Sleep(3000);
            Console.WriteLine("Bank with us at your own risk");
            Thread.Sleep(3000);
        }

        public void EntryDialog2()
        {
            Console.WriteLine("Please make a selection to proceed");
            Console.WriteLine("1: Create Account");
            Console.WriteLine("2: Check Balance");
            Console.WriteLine("3: Deposit");
            Console.WriteLine("4: Transfer");
            Console.WriteLine("5: Withdraw");
            Console.WriteLine("6: Close Account");
            Console.WriteLine("7: Exit Application");

            var choice = Convert.ToInt32 (Console.ReadLine());

        }

        public void HandleUserChoice(int choice)
        {
            switch(choice)
            {
                case 1:
                    Console.Write("Enter your Email:");
                    var email = Console.ReadLine();
                    Thread.Sleep(1000);
                    Console.Write("Enter your Firstname:");
                    var firstname = Console.ReadLine();
                    Console.Write("Enter your Lastname:");
                    var lastname = Console.ReadLine();
                    Console.Write("Enter your Phonenumber:");

                    var phonenumber = Console.ReadLine();
                    var customer = new Customer
                    {
                        Email = email,
                        Firstname = firstname,
                        Lastname = lastname,
                        Phonenumber = phonenumber
                    };
                    var customerAccount = CustomerActions.CreateCustomerAccount(customer);
                    Console.WriteLine("Your account number is :" + customerAccount.Account.AccountNumber);
                break;

            }
        }
    }
}
