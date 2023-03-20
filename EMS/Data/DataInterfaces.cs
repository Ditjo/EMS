using EMS.Data.MockData;
using EMS.Models;

namespace EMS.Data
{
    public interface IEmployee
    {
        Task<List<EmployeeModel>> GetEmployees();
    }

    public interface IJobTitle
    {
        Task<List<JobTitleModel>> GetData();
    }

    public interface IDepartment
    {
        Task<List<DepartmentModel>> GetData();
    }

    public interface IDataHandling
    {
        public Task<List<EmployeeModel>> GetAllEmployees();

        public EmployeeModel GetEmployee(int Id);

        public void AddNewEmployee(EmployeeModel employee);

        public void UpdateEmployee(EmployeeModel Updatedemployee);

        public void DeleteEmployee(int Id);

    }
}
