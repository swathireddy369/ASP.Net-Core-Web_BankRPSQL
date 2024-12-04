using BankRPSQL_1224871.DataLayer;
using System.Transactions;

namespace BankRPSQL_1224871.Models.DomainModels
{
    public class TransactionHistory : EntityBase
    {
        public long TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long CheckingAccountNumber { get; set; }
        public long SavingAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal TransactionFee {get;set;}
        public int TransactionTypeId { get; set; }
    
    }
}
