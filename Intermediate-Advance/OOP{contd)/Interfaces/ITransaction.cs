using OOP_contd_.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_contd_.Interfaces
{
    public interface ITransaction
    {
        List<Transaction> GetTransactionHistory(string accountNumber);
        void AddTransaction(Transaction transaction);
        void DeleteTransaction(int transactionId);
        Transaction GetTransactionDetails(int transactionId);
    }
}
