
using System.ComponentModel.DataAnnotations;
namespace StudentProgressReportSystem.Models
{
    public class Progress
    {

        [Key]
        public int Sno { get; set; }
        [Required]
        public int Batch { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public int Symbol { get; set; }
        [Required]
        public int Math { get; set; }
        [Required]
        public int Science { get; set; }
        [Required]
        public int Social { get; set; }
        [Required]
        public int Nepali { get; set; }
        [Required]
        public int Computer { get; set; }



    }

}
