using EMS.Models;

namespace EMS.Services
{
    public interface IDepartmentServices
    {
        public Task<List<DepartmentModel>> ShowDepartments();
    }
}
