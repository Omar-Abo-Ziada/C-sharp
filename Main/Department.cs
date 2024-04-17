using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkDay_1
{
    public class Department
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Department Name : {Name} ==> Adress : {Address}\n";
        }

    }
}
