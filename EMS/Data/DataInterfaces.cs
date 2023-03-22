using EMS.Data.MockData;
using EMS.Models;

namespace EMS.Data
{
    public interface IJobTitleRepository
    {
        Task<List<JobTitleModel>> GetData();
    }

    public interface IDepartmentRepository
    {
        Task<List<DepartmentModel>> GetData();
    }

    public interface IEmployeeRepository
    {
        public Task<List<EmployeeModel>> GetAllEmployees();

        public EmployeeModel GetEmployee(int Id);

        public void AddNewEmployee(EmployeeModel employee);

        public void UpdateEmployee(EmployeeModel Updatedemployee);

        public void DeleteEmployee(int Id);

    }
}
