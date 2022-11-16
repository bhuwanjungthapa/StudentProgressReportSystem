
using System.ComponentModel.DataAnnotations;
namespace StudentProgressReportSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }
        


    }

}
