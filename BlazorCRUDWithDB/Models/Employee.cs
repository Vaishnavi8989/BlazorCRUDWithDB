using System.ComponentModel.DataAnnotations;

namespace BlazorCRUDWithDB.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Department { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
