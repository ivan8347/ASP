using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
    public class Student
    {
        [Key]

        public int stud_id { get; set; }
       
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string? middle_name { get; set; }

        //[Column(TypeName = "DATE")]
        public DateOnly birth_date { get; set; }
        [Required]
        public string email {  get; set; }
        [Required]
        public string phone { get; set; }
    }
}
