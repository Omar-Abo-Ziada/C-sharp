using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkDay_1
{
   public class Course
    {

        public string Name { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"Course Name : {Name} ==> Hours : {Hours}\n";
        }
    }
}
