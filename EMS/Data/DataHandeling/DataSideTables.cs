using EMS.Data.MockData;
using EMS.Models;

namespace EMS.Data.DataHandeling
{
    public class DataSideTables
    {
        public static async Task<List<DepartmentModel>> GetDataDepartment() 
        {
            DepartmentRepositoryMockData DepartmentMockData = new();
            return await DepartmentMockData.GetData();
        }
        public static async Task<List<JobTitleModel>> GetDataJobTitle()
        {
            JobTitleRepositoryMockData JobTitleMockData = new();
            return await JobTitleMockData.GetData();

        }
    }
}
