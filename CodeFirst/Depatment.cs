using CodeFirst.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("Department" , Schema ="IT")]
    internal class Depatment
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
