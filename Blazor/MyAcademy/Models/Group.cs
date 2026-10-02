using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyAcademy.Models

{
    public class Group
    {
        [Key]
        [Column("group_id")]
        public int group_id { get; set; }

        [Required]
        [Column("group_name", TypeName = "NCHAR(10)")]
        public string group_name { get; set; }

        [Required]
        [Column("direction", TypeName = "TINYINT")]
        [ForeignKey(nameof(Direction))]
        public int direction { get; set; }

        [Column("weekdays", TypeName = "TINYINT")]
        public int? learningDays { get; set; }

        [Column("start_time", TypeName = "TIME(0)")]
        public TimeOnly? start_time { get; set; }

        [Column("start_date", TypeName = "DATE")]
        public DateOnly? start_date { get; set; }


        //navigation properties
        public Direction Direction { get; set; }
        public ICollection<Student> Students { get; set; }

        //public Teacher Teacher { get; set; }
    }
}
