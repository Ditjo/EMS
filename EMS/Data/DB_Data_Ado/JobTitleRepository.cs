using EMS.Models;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using EMS.Settings;
using Microsoft.Extensions.Options;

namespace EMS.Data.DB_Data_Ado
{
    public class JobTitleRepository : IJobTitleRepository
    {
        private readonly ConnectionSetting _connection;

        public JobTitleRepository(IOptions<ConnectionSetting> connection)
        {
            _connection = connection.Value;
        }
        public async Task<List<JobTitleModel>> GetData()
        {
            List<JobTitleModel> ListJobTitle = new();
            using (var connect = new SqlConnection(_connection.SQLString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("GetJobTitles", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        ListJobTitle.Add(new JobTitleModel()
                        {
                            Id = reader.GetInt32("JobTitleId"),
                            JobTitleName = reader["JobTitle"].ToString()
                        });

                    }
                }
            }
            return ListJobTitle;
        }
    }
}
