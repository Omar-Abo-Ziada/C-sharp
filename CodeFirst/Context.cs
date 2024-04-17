using CodeFirst.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-2U2SE1A;Initial Catalog=TestCodeFirstDB;Integrated Security=True;")
        {
            
        }
        public virtual DbSet<Depatment> Depatments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
