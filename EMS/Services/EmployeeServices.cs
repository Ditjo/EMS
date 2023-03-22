using EMS.Data;
using EMS.Models;

namespace EMS.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeServices(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public void AddEmployee(EmployeeModel employee)
        {
            _repository.AddNewEmployee(employee);
        }

        public void DeleteEmployee(int Id)
        {
            _repository.DeleteEmployee(Id);
        }

        public EmployeeModel EditEmployee(int Id)
        {
            EmployeeModel employee = _repository.GetEmployee(Id);
            return employee;
        }

        public async Task<List<EmployeeModel>> ShowEmployees()
        {
            List<EmployeeModel> Listemployees = new List<EmployeeModel>();
            Listemployees = await _repository.GetAllEmployees();
            return Listemployees;
        }

        public void UpdateEmployee(EmployeeModel Updatedemployee)
        {
            _repository.UpdateEmployee(Updatedemployee);
        }
    }
}
