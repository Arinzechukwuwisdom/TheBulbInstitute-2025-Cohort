using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_contd_.models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } // "Deposit" or "Withdrawal"
        public Transaction(int transactionId, string accountNumber, decimal amount, DateTime transactionDate, string transactionType)
        {
            TransactionId = transactionId;
            AccountNumber = accountNumber;
            Amount = amount;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
        }
    }
}
