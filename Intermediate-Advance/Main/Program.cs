using Algorithms;
//Bank<string> bank = new Bank<string>();

//var bankOperation = bank.CreateAccount(bank.Id = "12345",
//                  bank.AccountNumber = "987654321",
//                  bank.Balance = 100.00);


//var bank2 = new Bank<int>();

//var bankOperation2 = bank2.CreateAccount(1, 123456789, 100);
//if (bankOperation2.IsSuccessful)
//{
//    Console.WriteLine($"Account created successfully: {bankOperation2.Message}\n{bankOperation2.StatusCode}\n{bankOperation2.Data.Balance}");
//}
//else
//{
//    Console.WriteLine($"Failed to create account: {bankOperation2.StatusCode}");
//}

//var collection = new CollectionTypes();
//collection.GenericCollections();

Console.WriteLine("Enter your deadfish commands");
var value = Console.ReadLine();

var res = Deadfish.Parser(value);
foreach (var item in res)
{
    Console.WriteLine(item);

}