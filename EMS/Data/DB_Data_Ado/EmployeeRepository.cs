using EMS.Models;
using EMS.Settings;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
namespace EMS.Data.DB_Data_Ado
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionSetting _connection;

        List<EmployeeModel> ListEmployee;
        public EmployeeRepository(IOptions<ConnectionSetting> connection)
        {
            _connection = connection.Value;
        }
        //----------------------------------------------------
        public void AddNewEmployee(EmployeeModel employee)
        {
            using (var connect = new SqlConnection(_connection.SQLString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("InsertNewEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add($"@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                cmd.Parameters.Add($"@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                cmd.Parameters.Add($"@JobTitleId", SqlDbType.Int).Value = employee.JobTitel;
                cmd.Parameters.Add($"@DepartmentId", SqlDbType.Int).Value = employee.Department;
                cmd.Parameters.Add($"@Salary", SqlDbType.Decimal).Value = employee.Salary;
                cmd.Parameters.Add($"@Deleted", SqlDbType.Bit).Value = employee.Deleted;
                cmd.Parameters.Add($"@Username", SqlDbType.NVarChar).Value = employee.Username;
                cmd.Parameters.Add($"@UserPassword", SqlDbType.NVarChar).Value = employee.Password;

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int Id)
        {
            using (var connect = new SqlConnection(_connection.SQLString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("DeleteEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add($"@EmployeeId", SqlDbType.Int).Value = Id;

                cmd.ExecuteNonQuery();
            }
        }

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            ListEmployee = new();
            using (var connect = new SqlConnection(_connection.SQLString))
            {
                
                connect.Open();
                SqlCommand cmd = new SqlCommand("GetAllEmployees", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        ListEmployee.Add(new EmployeeModel()
                        {
                            Id = reader.GetInt32("EmployeeId"),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            JobTitel = reader.GetInt32("JobTitleId"),
                            Department = reader.GetInt32("DepartmentId"),
                            Salary = reader.GetDecimal("Salary"),
                            Deleted = reader.GetBoolean("Deleted"),
                            Username = reader["Username"].ToString(),
                            Password = reader["UserPassword"].ToString(),

                        });
                           
                    }
                }
            }
            return ListEmployee;
        }

        public EmployeeModel GetEmployee(int Id)
        {
            return ListEmployee.Find(employee => employee.Id == Id) ?? throw new Exception("Could not find Employee");
        }

        public void UpdateEmployee(EmployeeModel Updatedemployee)
        {
            using (var connect = new SqlConnection(_connection.SQLString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UpdateEmployee", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add($"@EmployeeId", SqlDbType.Int).Value = Updatedemployee.Id;
                cmd.Parameters.Add($"@FirstName", SqlDbType.NVarChar).Value = Updatedemployee.FirstName;
                cmd.Parameters.Add($"@LastName", SqlDbType.NVarChar).Value = Updatedemployee.LastName;
                cmd.Parameters.Add($"@JobTitleId", SqlDbType.Int).Value = Updatedemployee.JobTitel;
                cmd.Parameters.Add($"@DepartmentId", SqlDbType.Int).Value = Updatedemployee.Department;
                cmd.Parameters.Add($"@Salary", SqlDbType.Decimal).Value = Updatedemployee.Salary;
                cmd.Parameters.Add($"@Deleted", SqlDbType.Bit).Value = Updatedemployee.Deleted;
                cmd.Parameters.Add($"@Username", SqlDbType.NVarChar).Value = Updatedemployee.Username;
                cmd.Parameters.Add($"@UserPassword", SqlDbType.NVarChar).Value = Updatedemployee.Password;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
