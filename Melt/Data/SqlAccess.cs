using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Melt.Data
{
    public class SqlAccess
    {
        private string _connectionString;

        public SqlAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Money2020Db");
        }

        #region ISqlAccess Implementation

        public DataSet GetDataSet(string storedProcedureName, List<SqlParameter> parameters)
        {
            var results = new DataSet();

            try
            {
                using (var cnx = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand(storedProcedureName, cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        using (var adp = new SqlDataAdapter(cmd))
                        {
                            cnx.Open();
                            adp.Fill(results);
                            cnx.Close();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return results;
        }
        
        public DataTable GetDataTable(string storedProcedureName)
        {
            return GetDataTable(storedProcedureName, null);
        }

        public DataTable GetDataTable(string storedProcedureName, List<SqlParameter> parameters)
        {
            var results = new DataTable();

            try
            {
                using (var cnx = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand(storedProcedureName, cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        using (var adp = new SqlDataAdapter(cmd))
                        {
                            cnx.Open();
                            adp.Fill(results);
                            cnx.Close();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return results;
        }

        public T ExecuteScalar<T>(string storedProcedureName, List<SqlParameter> parameters)
        {
            T results;
            try
            {
                using (var cnx = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand(storedProcedureName, cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        cnx.Open();

                        var sqlResults = cmd.ExecuteScalar();

                        if (sqlResults == null)
                            results = Activator.CreateInstance<T>();
                        else
                            results = (T)sqlResults;

                        cnx.Close();

                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return results;
        }

        public void ExecuteNonQuery(string storedProcedureName, List<SqlParameter> parameters)
        {
            try
            {
                using (var cnx = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand(storedProcedureName, cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        cnx.Open();

                        cmd.ExecuteNonQuery();

                        cnx.Close();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        #endregion
    }
}
