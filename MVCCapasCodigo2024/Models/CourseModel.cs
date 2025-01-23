using System.ComponentModel.DataAnnotations;

namespace MVCCapasCodigo2024.Models
{
    public class CourseModel
    {
        public int CourseID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
       
    }
}
