using System.Data;

namespace BankRPSQL_1224871.DataLayer
{
    public interface IEntity
    {
        void setFields(DataRow dr);
    }
}
