using BankRPSQL_1224871.DataLayer;
using BankRPSQL_1224871.Models.ViewModels;

namespace BankRPSQL_1224871.ServicesBusiness
{
    public interface IBusinessBanking
    {
        decimal GetCheckingBalance(long checkingAccountNum);
        decimal GetSavingBalance(long savingAccountNum);
        long GetCheckingAccountNumForUser(string username);
        long GetSavingAccountNumForUser(string username);
        bool TransferCheckingToSaving(long checkingAccountNum, long savingAccountNum, decimal amount);
        bool TransferSavingToChecking(long checkingAccountNum, long savingAccountNum, decimal amount);
        List<TransactionHistoryVM> GetTransactionHistory(long checkingAccountNum);

    }

}
