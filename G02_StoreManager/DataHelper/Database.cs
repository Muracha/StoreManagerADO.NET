using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataHelper
{
	public class Database
	{
		private readonly bool _useSingletone;
		private SqlConnection _connection;

		public Database(string connectionString, bool useSingletone = false)
		{
			_useSingletone = useSingletone;
			ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
		}

		public string ConnectionString { get; private set; }

		public SqlConnection GetConnection()
		{
			if (_connection == null || !_useSingletone)
			{
				_connection = new SqlConnection(ConnectionString);
			}
			return _connection;
		}

		public void OpenConnection()
		{
			GetConnection().Open();
		}

		public void CloseConnection()
		{
			GetConnection().Close();
		}

		#region GetCommand
		public SqlCommand GetCommand(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = GetConnection();
			command.CommandText = commandText;
			command.CommandType = commandType;
			command.Parameters.AddRange(parameters);
			return command;
		}

		public SqlCommand GetCommand(string commandText, params SqlParameter[] parameters)
		{
			return GetCommand(commandText, CommandType.Text, parameters);
		}
		#endregion

		#region ExecuteNonQuery
		public int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			SqlCommand command = GetCommand(commandText, commandType, parameters);
			try
			{
				command.Connection.Open();
				return command.ExecuteNonQuery();
			}
			finally
			{
				command.Connection.Close();
			}
		}

		public int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteNonQuery(commandText, CommandType.Text, parameters);
		}
		#endregion

		#region ExecuteScalar
		public object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			SqlCommand command = GetCommand(commandText, commandType, parameters);
			try
			{
				command.Connection.Open();
				return command.ExecuteScalar();
			}
			finally
			{
				command.Connection.Close();
			}
		}

		public object ExecuteScalar(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteScalar(commandText, CommandType.Text, parameters);
		}
		#endregion

		#region ExecuteReader
		public SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			SqlCommand command = GetCommand(commandText, commandType, parameters);
			command.Connection.Open();
			return command.ExecuteReader(CommandBehavior.CloseConnection);
		}

		public SqlDataReader ExecuteReader(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteReader(commandText, CommandType.Text, parameters);
		}
		#endregion

		public void Dispose()
		{
			if (_connection != null && _connection.State == ConnectionState.Open)
			{
				_connection.Close();
			}
			GC.SuppressFinalize(this);
		}
	}
}
