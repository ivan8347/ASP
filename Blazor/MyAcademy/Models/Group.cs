using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
   
    public class Group
    {
        [Key]
        [Column("group_id",TypeName="TINYINT")]
        public int GroupId { get; set; }

        [Column("group_name")]
        [StringLength(10)]
        public string GroupName { get; set; }

        [Column("direction", TypeName="TINYINT")]
        public int Direction { get; set; }

        [Column("weekdays", TypeName ="TINYINT")]
        public int? Weekdays { get; set; }

        [Column("start_time", TypeName ="TIME")]
        public TimeSpan? StartTime { get; set; }

        [Column("start_date", TypeName ="DATE")]
        public DateTime? StartDate { get; set; }
    }
}
