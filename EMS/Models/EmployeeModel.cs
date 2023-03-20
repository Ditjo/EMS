namespace EMS.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JobTitel { get; set; }
        public int Department { get; set; }
        public double Salary { get; set; }
        public bool Deleted { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
