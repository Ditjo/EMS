using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public int JobTitel { get; set; }
        [Required]
        public int Department { get; set; }
        [Required]
        public decimal Salary { get; set; }
        public bool Deleted { get; set; }
        [Required]
        [StringLength(8)]
        public string Username { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }

    }
}
