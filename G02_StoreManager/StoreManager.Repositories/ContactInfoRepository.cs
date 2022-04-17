using DataHelper;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
    public class ContactInfoRepository
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConectionString"].ToString();
        public void Insert(ContactInfo record)
        {
            using (Database _database = new Database(_connectionString, true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("InsertContactInfo_SP", CommandType.StoredProcedure,
                        new SqlParameter("@EmployeeID", record.EmployeeID),
                        new SqlParameter("@ContactType", record.ContactType),
                        new SqlParameter("@ContactData", record.ContactData),
                        new SqlParameter("@IsPrimary", record.IsPrimary));

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
                    _database.ExecuteNonQuery("InsertContactInfo_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));

                    _database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    _database.RollBack();
                    throw ex;
                }
            }
        }

        public IEnumerable<ContactInfo> Select()
        {
            using (Database _database = new Database(_connectionString))
            {
                var reader = _database.ExecuteReader("SelectContactInfo_SP", CommandType.StoredProcedure);
                foreach (IDataRecord record in reader)
                {
                    ContactInfo contactInfo = new ContactInfo();
                    contactInfo.ID = record.GetInt32(0);
                    contactInfo.EmployeeID = record.GetInt32(1);
                    contactInfo.ContactType = record.GetInt32(2);
                    contactInfo.ContactData = record.GetDateTime(3).ToString("dd/MM/yyyy");
                    contactInfo.IsPrimary = record.GetBoolean(4);
                    contactInfo.CreateDate = record.GetDateTime(5).ToString("dd/MM/yyyy");
                    contactInfo.IsDeleted = record.GetBoolean(6);
                    yield return contactInfo;
                }
            }
        }

        public void Update(ContactInfo record)
        {
            using (Database _database = new Database(_connectionString, true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("UpdateContactInfo_SP", CommandType.StoredProcedure,
                                           new SqlParameter("@ID", record.ID),
                                           new SqlParameter("@EmployeeID ", record.EmployeeID),
                                           new SqlParameter("@ContactType ", record.ContactType),
                                           new SqlParameter("@ContactData", record.ContactData),
                                           new SqlParameter("@IsPrimary", record.IsPrimary)
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
    }
}
