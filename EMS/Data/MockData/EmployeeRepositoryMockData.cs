using EMS.Models;

namespace EMS.Data.MockData
{
    public class EmployeeRepositoryMockData : IEmployeeRepository
    {

        List<EmployeeModel> EmployeeList;

        public void AddNewEmployee(EmployeeModel employee)
        {
            employee.Id = EmployeeList.Max(x => x.Id) + 1;
            EmployeeList.Add(employee);
        }

        public void DeleteEmployee(int Id)
        {
            EmployeeModel employee = GetEmployee(Id);
            EmployeeList.Remove(employee);
        }

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            if (EmployeeList is null)
            {
                EmployeeList = new()
                {
                    new()
                    {
                        Id = 1,
                        FirstName = "Mads",
                        LastName = "Nielsen",
                        JobTitel = 1,
                        Department = 3,
                        Salary = 11,
                        Deleted = false,
                        Username = "mads",
                        Password = "passw0rd"
                    },
                    new()
                    {
                        Id = 2,
                        FirstName = "Hans",
                        LastName = "Hansen",
                        JobTitel = 2,
                        Department = 1,
                        Salary = 45,
                        Deleted = false,
                        Username = "hans",
                        Password = "Passw0rd"
                    },
                    new()
                    {
                        Id = 3,
                        FirstName = "Jack",
                        LastName = "Jackson",
                        JobTitel = 4,
                        Department = 2,
                        Salary = 25,
                        Deleted = false,
                        Username = "jack",
                        Password = "Passw0rd"
                    }
                };
            }
            return EmployeeList;
        }

        public EmployeeModel GetEmployee(int Id)
        {
            return EmployeeList.Find(employee => employee.Id == Id) ?? throw new Exception("Could not find Employee");
        }

        public void UpdateEmployee(EmployeeModel updatedemployee)
        {
            EmployeeModel existingEmployee = GetEmployee(updatedemployee.Id);
            existingEmployee.FirstName = updatedemployee.FirstName;
            existingEmployee.LastName = updatedemployee.LastName;
            existingEmployee.JobTitel = updatedemployee.JobTitel;
            existingEmployee.Department = updatedemployee.Department;
            existingEmployee.Salary = updatedemployee.Salary;
            existingEmployee.Deleted = updatedemployee.Deleted;
            existingEmployee.Username = updatedemployee.Username;
            existingEmployee.Password = updatedemployee.Password;
        }
    }
}
