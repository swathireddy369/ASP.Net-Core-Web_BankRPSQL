
namespace BankRPSQL_1224871.Utils
{
    public class HttpContextHelper
    {
        static IHttpContextAccessor _ihttpCtxAccessor = null;
        public static void Configure(IHttpContextAccessor accessor)
        {
            _ihttpCtxAccessor = accessor;
        }
        public static HttpContext HttpCtx
        {
            get { return _ihttpCtxAccessor.HttpContext; }
        }

    }
}
