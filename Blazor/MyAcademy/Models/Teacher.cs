using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyAcademy.Models
{
    public class Teacher
    {

        [Key]
        [Column(TypeName ="SMALLINT")]
        public int teacher_id { get; set; }

        public string last_name { get; set; } = string.Empty;

        public string first_name { get; set; } = string.Empty;

        public string? middle_name { get; set; }

        [Column(TypeName = "DATE")]
        public DateOnly? birth_date { get; set; }

        public string? email { get; set; }

        public string? phone { get; set; }



        [Column(TypeName = "DATE")]
        public DateOnly? work_since { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? rate { get; set; }
    }
}