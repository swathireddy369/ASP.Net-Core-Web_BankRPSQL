using BankRPSQL_1224871.Models.ViewModels;
using BankRPSQL_1224871.ServicesBusiness;
using BankRPSQL_1224871.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankRPSQL_1224871.Pages
{
    public class TransactionHistoryModel : PageModel
    {
        IBusinessBanking _ibusbank = null;
        public TransactionHistoryModel(IBusinessBanking ibusbank)
        {
            _ibusbank = ibusbank;
        }
        public List<TransactionHistoryVM> TList { get; set; }
        public IActionResult OnGet()
        {
            if (SessionFacade.USERINFO == null)
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            else
            {
                UserInfo uinfo = SessionFacade.USERINFO;
                TList = _ibusbank.GetTransactionHistory(uinfo.CheckingAccountNumber);
                if (TList != null && TList.Any())
                {
                    foreach (var transaction in TList)
                    {
                        Console.WriteLine($"trans: {transaction.SavingAccountNumber}, Amount: {transaction.Amount}, Fee: {transaction.TransactionFee}");
                    }
                }
                else
                {
                    Console.WriteLine("No transactions found or TList is null.");
                }
            }
            return Page();
        }
    }
}
