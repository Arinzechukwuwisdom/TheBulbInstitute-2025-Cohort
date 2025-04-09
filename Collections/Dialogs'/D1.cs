
using Functionalities;
using Models;

namespace Dialogs_
{
    public class D1
    {
        private CustomerActions customerActions = new CustomerActions();
        private General generalActions = new General();
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
            string choice;
            int parsedChoice;
            bool isRightNumber = false;
            do
            {
                Console.WriteLine("Please make a selection to proceed");
                Console.WriteLine("1: Create Account");
                Console.WriteLine("2: Check Balance");
                Console.WriteLine("3: Deposit");
                Console.WriteLine("4: Transfer");
                Console.WriteLine("5: Withdraw");
                Console.WriteLine("6: Close Account");
                Console.WriteLine("7: Get Account Details");
                Console.WriteLine("8: Get All accounts");
                Console.WriteLine("9: Exit Application");

                choice = Console.ReadLine();

                var isCorrectChoice = int.TryParse(choice, out parsedChoice);

                if (isCorrectChoice)
                {
                    if(parsedChoice >=1 || parsedChoice <= 9)
                    {
                        isRightNumber = true;
                        HandleUserChoice(parsedChoice);
                    }
                    else
                    {
                        Console.Write("You dey gba. Pick correct number");
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an invalid character");
                }
            } while (!isRightNumber);
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
                    Thread.Sleep(1000);
                    Console.Write("Enter your Lastname:");
                    var lastname = Console.ReadLine();
                    Thread.Sleep(1000);
                    Console.Write("Enter your Phonenumber:");
                    var phonenumber = Console.ReadLine();
                    Thread.Sleep(1000);
                    
                    Console.Write("What type of account would you like to open:");
                    var accountType = Console.ReadLine() ;
                    var accTypeVal = string.IsNullOrEmpty(accountType) ? default : accountType;
                    Thread.Sleep(1000);

                    var customer = new Customer
                    {
                        Email = email,
                        Firstname = firstname,
                        Lastname = lastname,
                        Phonenumber = phonenumber
                    };
                    var customerAccount = customerActions.CreateCustomerAccount(customer, accTypeVal);
                    Console.WriteLine("You have successfully created your account");
                    Console.WriteLine("Account Details");
                    Console.WriteLine($"Account Number: {customerAccount.Account.AccountNumber}");
                    Console.WriteLine($"Account Type: {customerAccount.Account.AccountType}"); 
                        
                    Thread.Sleep(5000);
                    Console.WriteLine("Would you like to carry out another operation");
                        
                    
                    bool isRightNumber = false;
                    do
                    {
                        Console.WriteLine("Enter 1 to do something else or 2 to exit the application ");

                        var choice2 = Console.ReadLine();
                        int parsedChoice;

                        bool isCorrect = int.TryParse(choice2, out parsedChoice);
                        if (isCorrect)
                        {
                            if (parsedChoice == 1)
                            {
                                isRightNumber = true;
                                EntryDialog2();
                            }
                            else if (parsedChoice == 2)
                            {
                                isRightNumber = true;
                                Console.WriteLine("Thank you for banking with us");
                            }
                            else
                            {
                                Console.Write("You have entered a wrong choice");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid character");
                        }

                    } while (isRightNumber == false);
                                        
                break;
                case 8:
                    var accounts = generalActions.GetAllAccounts();
                    foreach ( var account in accounts )
                    {
                        Console.WriteLine("\n\nAccount Details");
                        Console.WriteLine($"{account.AccountNumber}");
                        Console.WriteLine($"{account.AccountName}");
                        Console.WriteLine($"{account.AccountType}\n\n\n");
                    }
                break;
            }
        }
    }
}
