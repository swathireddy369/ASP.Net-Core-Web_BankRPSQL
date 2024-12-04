using BankRPSQL_1224871.DataLayer;
using BankRPSQL_1224871.Models.DomainModels;

namespace BankRPSQL_1224871.Models.ViewModels
{
    public class TransactionHistoryVM : EntityBase
    
        {
            public long CheckingAccountNumber { get; set; }
            public long SavingAccountNumber { get; set; }
            public decimal Amount { get; set; }
            public decimal TransactionFee { get; set; }
            public DateTime TransactionDate { get; set; }
            public string TransactionTypeName { get; set; }
        }

    
}
