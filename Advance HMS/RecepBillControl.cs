using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISDProject
{
    public partial class RecepBillControl : UserControl
    {
        //string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        //SqlDataAdapter dataAdapter;     //build connection b/w database and program
        //DataTable table;
        string email;

        public RecepBillControl()
        {
            InitializeComponent();
        }
        

        public void RecepBillControl_Load(object sender, EventArgs e)
        {
            recepInvoiceControl1.Hide();
        }

        public void SetNameText(string text)
        {
            this.lblName.Text = text;
        }

        public void SetRoomType(string text)
        {
            this.lblRType.Text = text;
        }
        public void SetRoomQTY(string text)
        {
            this.lblRQty.Text = text;
        }
        public void SetCheckIn(string text)
        {
            this.lblCIND.Text = text;

        }
        public void SetCheckOut(string text)
        {
            this.lblCOD.Text = text;
        }
        public void SetEmail(string text)
        {
            email = text;
        }

        public TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            RecepReserveControl recep = new RecepReserveControl();

            TimeSpan ts = date1 - date2;
            
            int totaldays = ts.Days;
            int roomQty = int.Parse(lblRQty.Text);
            int bill;

            bool positive = totaldays > 0;
            bool negative = totaldays < 0;

            if (negative)
            {
                if (lblRType.Text == "Standard")
                {
                    int RtPrice = 1000 * int.Parse(lblRQty.Text);
                    lblRTPrice.Text = RtPrice.ToString();

                    totaldays = totaldays * -1;
                    bill = ((totaldays * 5000) * roomQty);
                    lblDaysTotal.Text = totaldays.ToString() + " Days";
                    lblDayPrice.Text = bill.ToString();

                    int TotalBill = int.Parse(lblRTPrice.Text) + bill;
                    lblTPRICE.Text = TotalBill.ToString();
                }
                else if(lblRType.Text == "Deluxe")
                {
                    int RtPrice = 3000 * int.Parse(lblRQty.Text);
                    lblRTPrice.Text = RtPrice.ToString();

                    totaldays = totaldays * -1;
                    bill = ((totaldays * 5000) * roomQty);
                    lblDaysTotal.Text = totaldays.ToString() + " Days";
                    lblDayPrice.Text = bill.ToString();

                    int TotalBill = int.Parse(lblRTPrice.Text) + bill;
                    lblTPRICE.Text = TotalBill.ToString();
                }
                else if (lblRType.Text == "Premium")
                {
                    int RtPrice = 5000 * int.Parse(lblRQty.Text);
                    lblRTPrice.Text = RtPrice.ToString();

                    totaldays = totaldays * -1;
                    bill = ((totaldays * 5000) * roomQty);
                    lblDaysTotal.Text = totaldays.ToString() + " Days";
                    lblDayPrice.Text = bill.ToString();

                    int TotalBill = int.Parse(lblRTPrice.Text) + bill;
                    lblTPRICE.Text = TotalBill.ToString();
                }
            }
            else
            {
                if (lblRType.Text == "Standard")
                {
                    int RtPrice = 1000 * int.Parse(lblRQty.Text);
                    lblRTPrice.Text = RtPrice.ToString();

                    bill = ((totaldays * 5000) * roomQty);
                    lblDaysTotal.Text = totaldays.ToString() + " Days";
                    lblDayPrice.Text = bill.ToString();

                    int TotalBill = int.Parse(lblRTPrice.Text) + bill;
                    lblTPRICE.Text = TotalBill.ToString();
                }
                else if (lblRType.Text == "Deluxe")
                {
                    int RtPrice = 3000 * int.Parse(lblRQty.Text);
                    lblRTPrice.Text = RtPrice.ToString();

                    bill = ((totaldays * 5000) * roomQty);
                    lblDaysTotal.Text = totaldays.ToString() + " Days";
                    lblDayPrice.Text = bill.ToString();

                    int TotalBill = int.Parse(lblRTPrice.Text) + bill;
                    lblTPRICE.Text = TotalBill.ToString();
                }
                else if (lblRType.Text == "Premium")
                {
                    int RtPrice = 5000 * int.Parse(lblRQty.Text);
                    lblRTPrice.Text = RtPrice.ToString();

                    bill = ((totaldays * 5000) * roomQty);
                    lblDaysTotal.Text = totaldays.ToString() + " Days";
                    lblDayPrice.Text = bill.ToString();

                    int TotalBill = int.Parse(lblRTPrice.Text) + bill;
                    lblTPRICE.Text = TotalBill.ToString();
                }
            }

            return ts;
        }

        public int getTotalPrice()
        {
            int a = int.Parse(lblTPRICE.Text);
            return a;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new RecepReserveControl().Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            recepInvoiceControl1.setCName(lblName.Text);
            recepInvoiceControl1.setCEmail(email);
            recepInvoiceControl1.setDes("Room Type : " + lblRType.Text);
            recepInvoiceControl1.SetPrice(lblRTPrice.Text);
            recepInvoiceControl1.setAmount(lblDayPrice.Text);
            recepInvoiceControl1.SetQty(lblRQty.Text);
            recepInvoiceControl1.SetTPrice(lblTPRICE.Text);
            recepInvoiceControl1.Show();
        }


    }
}
