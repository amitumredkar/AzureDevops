
using System.ComponentModel.DataAnnotations;
namespace SimpleAPI.Models
{

    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exeed more than 50 character")]
        public string Name { get; set; }
        [Required]
        public Dept? Department { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        //public string PhotoPath { get; set; }
    }
}