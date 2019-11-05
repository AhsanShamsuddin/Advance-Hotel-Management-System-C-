using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDProject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            employeeHomeControl1.BringToFront();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeHomeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            employeeRDamageControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form1().Show();
        }
    }
}
