using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company_SDEntities context = new Company_SDEntities();

            //var query = context.Departments.Where(q => q.Employees.Count() > 1).Select(q => new {q.Dnum , q.Dname} );
            context.Database.Log = log => Debug.WriteLine(log);

            //foreach (var department in query) 
            //{
            //    Console.WriteLine(department);
            //}

            //var query = context.Departments.Where(q => q.Dnum>1).Select(q => new { q.Dnum, q.Dname });
            //context.Database.Log = log => Debug.WriteLine(log);

            //foreach (var department in query)
            //{
            //    Console.WriteLine(department);
            //}

            //var query = 
            //    from dep in context.Departments
            //    where dep.Dnum > 1 && dep.Dname.StartsWith("S")
            //    select dep;

            //foreach (var department in query)
            //{
            //    Console.WriteLine(department.Dname);
            //}
            //Console.ReadLine();

            //int id = int.Parse("1");

            //var query = 
            //    from dep in context.Departments
            //    where dep.Dnum > id && dep.Dname.Contains("s")
            //    select dep;

            //foreach (var department in query)
            //{
            //    Console.WriteLine(department.Dname);
            //}
            //Console.ReadLine();


            //Department dep = context.Departments.First();
            //dep.Dname = "Human Resources";

            //context.SaveChanges();

            //Console.WriteLine(dep.Dname);
        }
    }
}
