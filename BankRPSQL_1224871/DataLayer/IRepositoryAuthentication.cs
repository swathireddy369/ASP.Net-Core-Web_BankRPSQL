using BankRPSQL_1224871.Models.ViewModels;

namespace BankRPSQL_1224871.DataLayer
{
    public interface IRepositoryAuthentication
    {
        UserInfo GetUserInfo(string username);
    }
}
