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
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            recepHomeControl1.GetData("SELECT * from Clients");
            recepHomeControl1.GetReserveData("SELECT SUM(Room_QTY)FROM Clients");
            recepHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            recepHomeControl1.GetRoomData("SELECT * from Room");
            recepHomeControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            recepHomeControl1.GetData("SELECT * from Clients");
            recepHomeControl1.GetReserveData("SELECT SUM(Room_QTY)FROM Clients");
            recepHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            recepHomeControl1.GetDamageData("SELECT * from Room_Damage_Record");
            recepHomeControl1.GetRoomData("SELECT * from Room");
            recepHomeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            recepReserveControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            recepSearchControl1.BringToFront();
        }

        private void recepReserveControl1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            recepCheckOutControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            this.Visible = false;
            new Form1().Show();
        }
    }
}
