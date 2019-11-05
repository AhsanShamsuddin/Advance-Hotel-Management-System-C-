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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ownerHomeControl1.GetData("SELECT * from Clients");
            ownerHomeControl1.GetRevenueData("SELECT SUM(Amount)FROM Bill");
            ownerHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            ownerHomeControl1.GetResolvedData("SELECT * from Room_Damage_Record where Damage_Payment_Status = 'Paid'");
            ownerHomeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            ownerHotelControl1.BringToFront();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ownerHomeControl1.GetData("SELECT * from Clients");
            ownerHomeControl1.GetRevenueData("SELECT SUM(Amount)FROM Bill");
            ownerHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            ownerHomeControl1.GetResolvedData("SELECT * from Room_Damage_Record where Damage_Payment_Status = 'Paid'");
            ownerHomeControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            ownerRoomControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            ownerEmployeeControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form1().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            ownerSearchControl1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button11.Height;
            SidePanel.Top = button11.Top;
            ownerRoomReportControl1.BringToFront();
        }
    }
}
