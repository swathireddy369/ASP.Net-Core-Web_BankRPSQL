using System.Data;
using System.Data.Common;

namespace BankRPSQL_1224871.DataLayer
{
    public interface IDataAccess
    {
        object GetSingleAnswer(string sql, List<DbParameter> PList, DbConnection conn = null, DbTransaction sqtr = null, bool bTransaction = false);
        DataTable GetManyRowsCols(String sql,List<DbParameter> PList,DbConnection conn=null,DbTransaction sqtr=null,bool bTransaction = false);
        int InsertUpdateDelete(String sql, List<DbParameter> PList, DbConnection conn = null, DbTransaction sqtr = null, bool bTransaction = false);
    }
}
