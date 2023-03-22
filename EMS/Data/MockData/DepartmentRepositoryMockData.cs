using EMS.Models;

namespace EMS.Data.MockData
{
    public class DepartmentRepositoryMockData : IDepartmentRepository
    {
        public async Task<List<DepartmentModel>> GetData()
        {
            List<DepartmentModel> list = new()
            {
                new()
                {
                    Id=1,
                    DepartmentName="Top Dogz"
                },
                new()
                {
                    Id=2,
                    DepartmentName="Taltællere"
                },
                new()
                {
                    Id=3,
                    DepartmentName="PC-Wizards"
                },
                new()
                {
                    Id=4,
                    DepartmentName="Overtalerne"
                }
            };

            return list;
        }
    }
}
