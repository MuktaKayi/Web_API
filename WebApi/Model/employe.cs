using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class employe
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? AddressLine { get; set; }
        public string? City { get; set; }
        [Key]
        public int EmployeeID { get; set; }
        public int department_id { get; set; }

    }
}
