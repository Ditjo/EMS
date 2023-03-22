using EMS.Data.MockData;
using EMS.Models;

namespace EMS.Data
{
    public interface IJobTitle
    {
        Task<List<JobTitleModel>> GetData();
    }

    public interface IDepartment
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
