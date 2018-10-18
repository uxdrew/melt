using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Melt.Data
{
    public interface ISqlAccess
    {
        DataSet GetDataSet(string storedProcedureName, List<SqlParameter> parameters);

        DataTable GetDataTable(string storedProcedureName);

        DataTable GetDataTable(string storedProcedureName, List<SqlParameter> parameters);

        T ExecuteScalar<T>(string storedProcedureName, List<SqlParameter> parameters);

        void ExecuteNonQuery(string storedProcedureName, List<SqlParameter> parameters);
    }
}
