using DataHelper;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
	public class UserRepository
	{
		private readonly string _connectionString;


		public UserRepository()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
		}

        public User Get(int id)
        {
            var user = new User();
            using (var database = new Database(_connectionString))
            {
                var reader = database.ExecuteReader("SelectUser_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                foreach (IDataRecord record in reader)
                {
                    user.ID = record.GetInt32(0);
                    user.Username = record.GetString(1);
                    user.Password = record.GetString(2);
                    user.CreateDate = record.GetDateTime(3);
                    user.IsActive = record.GetBoolean(4);
                    user.IsDeleted = record.GetBoolean(5);
                }
            }
            return user;
        }

        public IEnumerable<User> Select()
		{
			using (var database = new Database(_connectionString))
			{
				var reader = database.ExecuteReader("SelectUsers_SP", CommandType.StoredProcedure);
				foreach (IDataRecord record in reader)
				{
					yield return new User
					{
						ID = record.GetInt32(0),
						Username = record.GetString(1),
						Password = record.GetString(2),
						CreateDate = record.GetDateTime(3),
						IsActive = record.GetBoolean(4),
						IsDeleted = record.GetBoolean(5)
					};
				}
			}
		}

		public int Insert(User record)
		{
			using (var database = new Database(_connectionString, true))
			{
				try
				{
					database.BeginTransaction();
					database.ExecuteNonQuery("InsertUser_SP", CommandType.StoredProcedure,
						new SqlParameter("@ID", record.ID),
						new SqlParameter("@Username", record.Username),
						new SqlParameter("@Password", record.Password)
					);
					database.CommitTransaction();
				}
				catch
				{
					database.RollBack();
					throw;
				}
				return record.ID;
			}
		}

		public void Update(User record)
		{
			using (var database = new Database(_connectionString, true))
			{
				try
				{
					database.BeginTransaction();
					database.ExecuteNonQuery("UpdateUser_SP", CommandType.StoredProcedure,
						new SqlParameter("@ID", record.ID),
						new SqlParameter("@Username", record.Username),
						new SqlParameter("@IsActive", record.IsActive)
					);
					database.CommitTransaction();
				}
				catch
				{
					database.RollBack();
					throw;
				}
			}
		}

		public void Delete(int id)
		{
			using (var database = new Database(_connectionString, true))
			{
				try
				{
					database.BeginTransaction();
					database.ExecuteNonQuery("DeleteUser_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
					database.CommitTransaction();
				}
				catch
				{
					database.RollBack();
					throw;
				}
			}
		}
	}
}
