using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tesr
{
    internal class BusinessLogicLayer
    {
        public static List<Department> GetDepartments()
        {
            DataTable dataTable = DataAccessLayer.GetDepartments();

            List<Department> departments = new List<Department>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                departments.Add(new Department()
                {
                    DNum = (int)dataRow["Dnum"],
                    DName = (string)dataRow["DName"],
                });
            }
            return departments;
        }
    }
}
