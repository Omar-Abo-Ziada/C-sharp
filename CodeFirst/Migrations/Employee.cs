using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Migrations
{
    [Table("Employee" , Schema ="HR")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EID { get; set; }

        [Required , MaxLength(50)]
        //[MaxLength(50)]
        public string? Name { get; set; }

        [Column(TypeName ="date")]
        public DateTime? BirthDate { get; set; }

        public decimal? Salary { get; set; }

        [ForeignKey("Depatment")]
        public int? Dept_ID { get; set; }

        public virtual Depatment? Depatment { get; set; }
    }
}
