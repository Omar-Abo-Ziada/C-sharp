using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tesr
{
    internal static class DataAccessLayer
    {
        static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-2U2SE1A;Initial Catalog=Company_SD;Integrated Security=True;");
        static SqlCommand sqlCommand = new SqlCommand();
        static DataTable dataTable = new DataTable();
        static SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        static DataAccessLayer()
        {
            sqlCommand.Connection = sqlConnection;
        }

        public static DataTable GetDepartments()
        {
            sqlCommand.CommandText = "select Dnum , Dname from Departments";

            // Disconnected mode 

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable GetDepartmentEmployee(int dNo)
        {
            sqlCommand.CommandText = $"select * from Employee where Dno={dNo} ";

            // Disconnected mode 

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}

