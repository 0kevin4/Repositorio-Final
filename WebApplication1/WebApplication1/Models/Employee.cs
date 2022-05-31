using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Adress")]
        public string Adress { get; set; }
        public DateTime? RecordCreation { get; set; }
        public DateTime? RecordUpdateOn { get; set; }
        public bool Estate { get; set; } = true;
    }
}
