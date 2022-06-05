using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DataHelper.Facade
{
    public interface IDatabase : IDisposable
    {
        string ConnectionString { get; }
        SqlDependency GetSqlDependency(string commandText);
        void BeginTransaction();
        void CloseConnection();
        void CommitTransaction();
        int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters);
        int ExecuteNonQuery(string commandText, params SqlParameter[] parameters);
        SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters);
        SqlDataReader ExecuteReader(string commandText, params SqlParameter[] parameters);
        object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] parameters);
        object ExecuteScalar(string commandText, params SqlParameter[] parameters);
        SqlCommand GetCommand(string commandText, CommandType commandType, params SqlParameter[] parameters);
        SqlCommand GetCommand(string commandText, params SqlParameter[] parameters);
        SqlConnection GetConnection();
        SqlDataAdapter GetSqlDataAdapter(string commandText, CommandType commandType, params SqlParameter[] parameters);
        SqlDataAdapter GetSqlDataAdapter(string commandText, params SqlParameter[] parameters);
        DataTable GetTable(string commandText, CommandType commandType, params SqlParameter[] parameters);
        DataTable GetTable(string commandText, params SqlParameter[] parameters);
        void OpenConnection();
        void RollBack();
    }
}