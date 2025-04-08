namespace Models
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; } = 0.00;
        public string AccountName { get; set; }
        public string AccountType { get; set; }
    }
}
