using EMS.Data.MockData;
using EMS.Models;

namespace EMS.Data.DataHandeling
{
    public class DataEmployeeMock
    {
        EmployeeRepositoryMockData employeeRepositoryMockData = new();
        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            return await employeeRepositoryMockData.GetEmployees();
        }

        public EmployeeModel GetEmployee(int Id, List<EmployeeModel> list)
        {
            return list.Find(x => x.Id == Id) ?? throw new Exception("Could not find Employee");
        }

        public void AddNewEmployee(EmployeeModel employee)
        {

        }

        public void UpdateEmployee(EmployeeModel Updatedemployee)
        {

        }

        public void DeleteEmployee(int Id)
        {

        }
    }
}
