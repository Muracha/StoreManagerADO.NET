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
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public User Get(int id)
        {
            using (Database _database = new Database(_connectionString))
            {
                try
                {
                    User user = new User();
                    var reader = _database.ExecuteReader("SelectUser_SP", CommandType.StoredProcedure, new SqlParameter("@id", id));
                    foreach (IDataRecord record in reader)
                    {
                        user.ID = record.GetInt32(0);
                        user.Username = record.GetString(1);
                        user.Password = record.GetString(2);
                        user.CreateDate = record.GetDateTime(3).ToString(); 
                        user.IsActive = record.GetBoolean(4);
                        user.IsDeleted = record.GetBoolean(5);
                    }
                    return user;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<User> Select()
        {
            using (Database _database = new Database(_connectionString))
            {
                var reader = _database.ExecuteReader("SelectUsers_SP", CommandType.StoredProcedure);
                foreach (IDataRecord record in reader)
                {
                    User user = new User();
                    user.ID = record.GetInt32(0);
                    user.Username = record.GetString(1);
                    user.Password = record.GetString(2);
                    user.CreateDate = record.GetDateTime(3).ToString(); //record.GetDateTime(3).ToString("dd/MM/yyyy")
                    user.IsActive = record.GetBoolean(4);
                    user.IsDeleted = record.GetBoolean(5);
                    yield return user;
                }
            }
        }

        public int Insert(User record)
        {
            using (Database _database = new Database(_connectionString, true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("InsertUser_SP", CommandType.StoredProcedure,
                                           new SqlParameter("@ID", record.ID),
                                           new SqlParameter("@Username", record.Username),
                                           new SqlParameter("@Password", record.Password)
                                           );
                    _database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    _database.RollBack();
                    throw ex;
                }
                return record.ID;
            }
        }

        public void Update(User record)
        {
            using (Database _database = new Database(_connectionString, true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("UpdateUser_SP", CommandType.StoredProcedure,
                                           new SqlParameter("@ID", record.ID),
                                           new SqlParameter("@Username", record.Username),
                                           new SqlParameter("@IsActive", record.IsActive)
                                           );
                    _database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    _database.RollBack();
                    throw ex;
                }
            }
        }

        public void Delete(int id)
        {
            using (Database _database = new Database(_connectionString, true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("DeleteUser_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                    _database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    _database.RollBack();
                    throw ex;
                }
            }
        }
    }
}
