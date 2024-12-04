using System.Data;

namespace BankRPSQL_1224871.DataLayer
{
    public class DBList
    {
        public static List<T> ToList<T>(DataTable dt)
            where T : IEntity, new()
        {
            List<T> TList = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T tp=new T();
                tp.setFields(dr);
                TList.Add(tp);

            }
            return TList;
        }
        public static List<T> GetListValueType<T>(DataTable dt,string colname)
            where T: IConvertible
        {
            List<T> TList = new List<T>();
            foreach (DataRow dr in dt.Rows)
            
                TList.Add((T)dr[colname]);
            return TList;

            }
    }
}
