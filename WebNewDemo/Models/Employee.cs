using System.ComponentModel.DataAnnotations;

namespace WebNewDemo.Models
{
    public class Employee
    {
        [Key]   
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int salary { get; set; }
    }
}
