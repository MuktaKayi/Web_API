using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi
{
    [Table("Employee")]
    public class Student_Entity
    {
        //public string? Name { get; set; }
        //public int Age { get; set; }
        //public string? Department { get; set; }
        //public double Salary { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? AddressLine { get; set; } 
        public string? City { get; set; }
        [Key]
        public int  EmployeeID { get; set; }
        public int department_id { get; set; }

    }
}
