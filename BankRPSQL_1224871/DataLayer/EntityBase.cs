using System.Data;
using System.Reflection;
using System.Text.Json.Serialization;

namespace BankRPSQL_1224871.DataLayer
{
    [Serializable]
    public class EntityBase : IEntity
    {
        public void setFields(DataRow dr)
        {
            Type tp=this.GetType();
            foreach(PropertyInfo pi in tp.GetProperties())
            {
                if(null != pi && pi.CanWrite)
                {
                    string nm=pi.PropertyType.Name.ToUpper();
                    string nmfull = pi.PropertyType.FullName.ToUpper();
                    if (nm.IndexOf("Entity") >= 0)
                        break;
                    if (nmfull.IndexOf("System") < 0)
                        break;
                    if(pi.PropertyType.Name.ToUpper() != "BINARY")
                        pi.SetValue(this, dr[pi.Name],null);

                }
            }
        }
    }
}
