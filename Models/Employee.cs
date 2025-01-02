using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{

   
    
        public class Employee
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string Name { get; set; }

            [Required]
            [MaxLength(100)]
            public string Department { get; set; }

            [Required]
            public decimal Salary { get; set; }
        }
    }


