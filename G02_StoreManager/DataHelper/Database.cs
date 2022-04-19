using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataHelper
{
	public class Database : IDisposable
	{
		private readonly bool _useSingletone;
		private SqlConnection _connection;
		private SqlTransaction _transaction;

		public Database(string connectionString, bool useSingletone = false)
		{
			_useSingletone = useSingletone;
			ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
		}

		public string ConnectionString { get; private set; }

		#region Connection
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

		#endregion

		#region GetCommand
		public SqlCommand GetCommand(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = GetConnection();
			command.CommandText = commandText;
			command.CommandType = commandType;
			command.Transaction = _transaction;
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
				if (command.Connection.State != ConnectionState.Open)
				{
					command.Connection.Open();
				}
				return command.ExecuteNonQuery();
			}
			finally
			{
				if (_transaction == null)
				{
					command.Connection.Close();
				}
			}
		}

		public int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteNonQuery(commandText, CommandType.Text, parameters);
		}
		#endregion

		#region ExecuteScalar
		public object ExecuteScalar(string commandText, CommandType commandType, bool transaction, params SqlParameter[] parameters)
		{
			SqlCommand command = GetCommand(commandText, commandType, parameters);
			if (transaction == false)
			{
				return ExecuteScalar(commandText, commandType, parameters);
			}
			else
			{
				command.Connection.Open();
				return command.ExecuteScalar();
			}
		}

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

		#region GetTable
		//todo: დაასრულეთ ეს მეთოდი!
		public DataTable GetTable(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			SqlDataReader reader = ExecuteReader(commandText, commandType, parameters);
			DataTable table = new DataTable();
			table.Load(reader);
			return table;
		}

		public DataTable GetTable(string commandText, params SqlParameter[] parameters)
		{
			return GetTable(commandText, CommandType.Text, parameters);
		}
		#endregion

		#region Transaction

		public void BeginTransaction()
		{
			if (!_useSingletone)
			{
				throw new NotSupportedException("Singletone is not enabled.");
			}
			var connection = GetConnection();
			if (connection.State != ConnectionState.Open)
			{
				connection.Open();
			}
			_transaction = connection.BeginTransaction();
		}

		public void CommitTransaction()
		{
			if (_transaction == null)
			{
				throw new Exception("Transaction hasn't started");
			}
			_transaction.Commit();
			_transaction = null;
		}

		public void RollBack()
		{
			if (_transaction == null)
			{
				throw new Exception("Transaction hasn't started");
			}
			_transaction.Rollback();
			_transaction = null;
		}

		#endregion

		#region IDisposable
		public void Dispose()
		{
			if (_connection != null && _connection.State == ConnectionState.Open)
			{
				_connection.Close();
			}
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
