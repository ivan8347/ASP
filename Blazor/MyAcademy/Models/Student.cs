using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
    public class Student
    {
        [Key]
        public int stud_id { get; set; }

        public string last_name { get; set; } = string.Empty;

        public string first_name { get; set; } = string.Empty;

        public string? middle_name { get; set; }

        [Column(TypeName = "DATE")]
        public DateOnly? birth_date { get; set; }

        public string? email { get; set; }

        public string? phone { get; set; }


        [Column("group")]
        [ForeignKey(nameof(Group))]
        public int? group { get; set; }
        public Group Group{ get; set; }
    }
}
