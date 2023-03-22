using EMS.Models;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using EMS.Settings;
using Microsoft.Extensions.Options;

namespace EMS.Data.DB_Data_Ado
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ConnectionSetting _connection;

        public DepartmentRepository(IOptions<ConnectionSetting> connection)
        {
            _connection = connection.Value;
        }

        public async Task<List<DepartmentModel>> GetData()
        {
            List<DepartmentModel> ListDepartment = new();
            using (var connect = new SqlConnection(_connection.SQLString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("GetDepartments", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        ListDepartment.Add(new DepartmentModel()
                        {
                            Id = reader.GetInt32("DepartmentId"),
                            DepartmentName = reader["Department"].ToString()
                        });

                    }
                }
            }
            return ListDepartment;
        }
    }
}
