using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region trust server certififcate issue
            //Trust Server Certificate = True  => why exception when I write it in sqlConnection string ? 
            //The issue you're encountering might be due to the fact that the Trust Server Certificate=True option is not recognized or supported in the connection string for the SqlConnection object in the .NET framework.
            //The Trust Server Certificate = True option is typically used in connection strings for SQL Server in other contexts,
            //such as when connecting via SQL Server Management Studio or other SQL client tools.However, 
            //it is not a standard connection string option for SqlConnection objects in .NET. 
            #endregion

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-2U2SE1A;Initial Catalog=Company_SD;Integrated Security=True;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select Fname , SSN , Salary from Employee";

            #region Connected Mode

            //sqlConnection.Open();

            //SqlDataReader sqlDataReader = cmd.ExecuteReader();

            //while (sqlDataReader.Read())
            //{
            //    string name = sqlDataReader["Fname"].ToString();
            //    int SSN = (int)sqlDataReader["SSN"];
            //    int salary = (int)sqlDataReader["salary"];

            //    Console.WriteLine($" Name : {name}\t ID : {SSN}\t Salary : {salary}  \n");
            //}

            //sqlConnection.Close();

            //Console.ReadLine();

            #endregion

            #region Disonnected Mode

            //DataTable dataTable = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    int SSN = (int)row["SSN"];
            //    string name = (string)row["fname"];
            //    int salary = (int)row["Salary"];

            //    Console.WriteLine($" ID : {SSN}\t Name : {name}\t Salary : {salary} \n");
            //}

            //Console.ReadLine();
            #endregion

            #region Insert Update Delete

            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.Connection = sqlConnection;
            //cmd2.CommandText = "Update Employee set Salary = Salary + 1000 ";

            //sqlConnection.Open();

            //int noRowAffected = cmd2.ExecuteNonQuery();

            //Console.WriteLine($" {noRowAffected} rows affected ...");

            //sqlConnection.Close();

            //Console.ReadLine(); 
            #endregion
        }
    }
}
