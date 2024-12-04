using BankRPSQL_1224871.Models.ViewModels;

namespace BankRPSQL_1224871.DataLayer
{
    public interface IRepositoryBanking
    {
       decimal GetCheckingBalance(long checkingAccountNum);
        decimal GetSavingBalance(long savingAccountNum);
        long GetCheckingAccountNumForUser(string userName);
        long GetSavingAccountNumForUser(string userName);
        bool TransferCheckingToSaving(long checkingAccountnum, long savingAccountNum, decimal amount, decimal transactionFee);
        bool TransferSavingToChecking(long checkingAccountnum, long savingAccountNum, decimal amount, decimal transactionFee);
        List<TransactionHistoryVM> GetTransactionHistory(long checkingAccountnum);

    }
}
