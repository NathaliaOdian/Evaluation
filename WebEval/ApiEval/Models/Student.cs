

namespace ApiEval.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Birthday { get; set; }


    }
}