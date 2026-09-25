using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyAcademy.Models
{
    public class Teacher
    {

        [Key]
        [Column("teacher_id",TypeName ="SMALLINT")]
        public int TeacherId { get; set; }

        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;

        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("birth_date", TypeName = "DATE")]
        public DateOnly? BirthDate { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }



        [Column("work_since", TypeName = "DATE")]
        public DateOnly? WorkSince { get; set; }

        [Column("rate", TypeName = "smallmoney")]
        public decimal? Rate { get; set; }
    }
}