using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tesr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxDepartments.DisplayMember = "DName"; // Dname => is the name of the prop inside the obj not inside the databse
            comboBoxDepartments.ValueMember = "DNum";  // Dnum => is the name of the prop inside the obj not inside the databse
            comboBoxDepartments.DataSource = BusinessLogicLayer.GetDepartments();
            //comboBoxDepartments.DataSource = DataAccessLayer.GetDepartments();
            //comboBoxDepartments.DataSource = DataAccessLayer.GetDepartmentEmployee(10); // => kamel
        }
    }
}
