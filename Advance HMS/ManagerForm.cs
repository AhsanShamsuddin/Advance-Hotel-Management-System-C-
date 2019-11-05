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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            managerHomeControl1.GetData("SELECT * from Clients");
            managerHomeControl1.GetReserveData("SELECT SUM(Room_QTY)FROM Clients");
            managerHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            managerHomeControl1.GetResolvedData("SELECT * from Room_Damage_Record where Damage_Payment_Status = 'Paid'");
            managerHomeControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            managerHomeControl1.GetData("SELECT * from Clients");
            managerHomeControl1.GetReserveData("SELECT SUM(Room_QTY)FROM Clients");
            managerHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            managerHomeControl1.GetResolvedData("SELECT * from Room_Damage_Record where Damage_Payment_Status = 'Paid'");
            managerHomeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            managerEmployeeControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            managerSearchControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            managerRDamageControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            managerRReportControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form1().Show();
        }
    }
}
