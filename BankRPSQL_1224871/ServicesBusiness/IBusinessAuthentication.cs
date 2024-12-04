using BankRPSQL_1224871.Models.ViewModels;

namespace BankRPSQL_1224871.ServicesBusiness
{
    public interface IBusinessAuthentication
    {
        UserInfo GetUserInfo(string username);
    }
}
