using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDProject
{
    public partial class RecepInvoiceControl : UserControl
    {
        public RecepInvoiceControl()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new RecepBillControl().Show();
        }

        private void RecepInvoiceControl_Load(object sender, EventArgs e)
        {
            
        }

        public void setCName(string text)
        {
            this.lblCName.Text = "Name : "+text;
        }

        public void setCEmail(string text)
        {
            this.lblCEmail.Text = "Email : "+text;
        }

        public void setAmount(string text)
        {
            this.lblAmount.Text = text;
        }
        public void setDes(string text)
        {
            this.lblDes.Text = text;
        }
        public void SetPrice(string text)
        {
            this.lblPrice.Text = text;
        }
        public void SetQty(string text)
        {
            this.lblQTY.Text = text;
        }
        public void SetTPrice(string text)
        {
            this.lblTPRICE.Text = text;
        }


    }
}
