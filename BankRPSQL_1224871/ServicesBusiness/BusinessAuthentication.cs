using BankRPSQL_1224871.DataLayer;
using BankRPSQL_1224871.Models.ViewModels;

namespace BankRPSQL_1224871.ServicesBusiness
{
    namespace BankRPSQL_1218645.ServicesBusiness
    {
        public class BusinessAuthentication : IBusinessAuthentication
        {
            IRepositoryAuthentication _irepauth = null;
            public BusinessAuthentication(IRepositoryAuthentication irepauth)
            {
                _irepauth = irepauth;
            }
            public BusinessAuthentication() : this(new Repository())
            { }
            public UserInfo GetUserInfo(string username)
            {
                return _irepauth.GetUserInfo(username);
            }
        }
    }
}