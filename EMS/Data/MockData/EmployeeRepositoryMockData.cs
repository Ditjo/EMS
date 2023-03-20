using EMS.Models;

namespace EMS.Data.MockData
{
    public class EmployeeRepositoryMockData : IEmployee
    {
        public async Task<List<EmployeeModel>> GetEmployees()
        {
            List<EmployeeModel> list = new List<EmployeeModel>()
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
                },
            };

            return list;
        }
    }
}
