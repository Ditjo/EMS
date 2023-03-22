using EMS.Models;

namespace EMS.Services
{
    public interface IEmployeeServices
    {
        public Task<List<EmployeeModel>> ShowEmployees();

        public EmployeeModel EditEmployee(int Id);

        public void AddEmployee(EmployeeModel employee);

        public void UpdateEmployee(EmployeeModel Updatedemployee);

        public void DeleteEmployee(int Id);

    }
}
