using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Text = "My Revision Form";
            //this.BackColor = Color.Beige;

            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = e.Location.ToString();
            this.Text = $"X = {e.X} , Y = {e.Y}";

            this.BackColor = Color.FromArgb(e.X %255 , e.Y %255 , e.X %255);

        }
    }
}
