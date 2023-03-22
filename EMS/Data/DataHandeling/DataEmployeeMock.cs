using EMS.Data.MockData;
using EMS.Models;

namespace EMS.Data.DataHandeling
{
    //public class DataEmployeeMock : IEmployeeRepository
    //{
    //    EmployeeRepositoryMockData employeeRepositoryMockData = new();

    //    private List<EmployeeModel> listEmployees;

    //    public async Task<List<EmployeeModel>> GetAllEmployees()
    //    {
    //        //return await employeeRepositoryMockData.GetEmployees();
    //        listEmployees = await employeeRepositoryMockData.GetEmployees();
    //        return listEmployees;
    //    }

    //    public EmployeeModel GetEmployee(int Id/*, List<EmployeeModel> list*/)
    //    {
    //        return listEmployees.Find(x => x.Id == Id) ?? throw new Exception("Could not find Employee");
    //    }

    //    public void AddNewEmployee(EmployeeModel employee)
    //    {
    //        employee.Id = listEmployees.Max(x => x.Id) + 1;
    //        listEmployees.Add(employee);
    //    }

    //    public void UpdateEmployee(EmployeeModel Updatedemployee)
    //    {

    //    }

    //    public void DeleteEmployee(int Id)
    //    {

    //    }
    //}
}
