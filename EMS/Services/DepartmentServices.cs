using EMS.Data;
using EMS.Models;

namespace EMS.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentServices(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<DepartmentModel>> ShowDepartments()
        {
            List<DepartmentModel> ListDepartment = new();
            ListDepartment = await _repository.GetData();
            return ListDepartment;
        }
    }
}
