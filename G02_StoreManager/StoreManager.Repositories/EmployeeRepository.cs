using DataHelper;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StoreManager.Repositories
{
    public class EmployeeRepository
    {
        public Employee Get(int id)
        {
            using (Database _database = new Database(@"server = DESKTOP-GGJH7CA; database = G02_Store; integrated security = true"))
            {
                try
                {
                    Employee employee = new Employee();
                    var reader = _database.ExecuteReader("SelectEmployee_SP", CommandType.StoredProcedure, new SqlParameter("@Id", id));
                    foreach (IDataRecord record in reader)
                    {
                        employee.ID = record.GetInt32(0);
                        employee.FirstName = record.GetString(1);
                        employee.LastName = record.GetString(2);
                        employee.BirthDate = record.GetDateTime(3).ToString("dd/MM/yyyy");
                        employee.HireDate = record.GetDateTime(4).ToString();
                        employee.CreateDate = record.GetString(5);
                    }
                    return employee;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Employee> Select()
        {
            using (Database _database = new Database(@"server = DESKTOP-GGJH7CA; database = G02_Store; integrated security = true"))
            {
                var reader = _database.ExecuteReader("SelectEmployees_SP", CommandType.StoredProcedure);
                foreach (IDataRecord record in reader)
                {
                    Employee employee = new Employee();
                    employee.ID = record.GetInt32(0);
                    employee.FirstName = record.GetString(1);
                    employee.LastName = record.GetString(2);
                    employee.BirthDate = record.GetDateTime(3).ToString("dd/MM/yyyy");
                    employee.HireDate = record.GetDateTime(4).ToString();
                    employee.CreateDate = record.GetString(5);
                    yield return employee;
                }
            }
        }

        public int Insert(Employee record)
        {
            using (Database _database = new Database(@"server = DESKTOP-GGJH7CA; database = G02_Store; integrated security = true", true))
            {
                int outPutID=0;
                try
                {
                    _database.BeginTransaction();

                    IList<SqlParameter> list = new List<SqlParameter>();
                    list.Add(new SqlParameter("@FirstName", record.FirstName));
                    list.Add(new SqlParameter("@LastName", record.LastName));
                    list.Add(new SqlParameter("@BirthDate", record.BirthDate));
                    list.Add(new SqlParameter("@HireDate", record.HireDate));

                    var outParn = new SqlParameter("@Iddentity", SqlDbType.Int);
                    outParn.Direction = ParameterDirection.Output;
                    list.Add(outParn);
                    _database.ExecuteNonQuery("InsertEmployee_SP", CommandType.StoredProcedure, list.ToArray());
                   
                    _database.CommitTransaction();
                    outPutID = (int)outParn.Value;
                }
                catch (Exception ex)
                {
                    _database.RollBack();
                    throw ex;
                }
                return outPutID;
            }
        }

        public void Update(Employee record)
        {
            using (Database _database = new Database(@"server = DESKTOP-GGJH7CA; database = G02_Store; integrated security = true", true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("UpdateEmployee_SP", CommandType.StoredProcedure,
                                           new SqlParameter("@ID", record.ID),
                                           new SqlParameter("@FirstName", record.FirstName),
                                           new SqlParameter("@LastName", record.LastName),
                                           new SqlParameter("@BirthDate", record.BirthDate),
                                           new SqlParameter("@HireDate", record.HireDate)
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
            using (Database _database = new Database(@"server = DESKTOP-GGJH7CA; database = G02_Store; integrated security = true", true))
            {
                try
                {
                    _database.BeginTransaction();
                    _database.ExecuteNonQuery("DeleteEmployee_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
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
