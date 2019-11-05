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
    public partial class OwnerHotelControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";

        public OwnerHotelControl()
        {
            InitializeComponent();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {

            if (txtHN.Text == "")
            {
                errorProvider1.SetError(txtHN, "Fill Hotel Name");
            }
            else if (txtHAdd.Text == "")
            {
                errorProvider1.SetError(txtHAdd, "Fill Address");
            }
            else if (txtHph.Text == "")
            {
                errorProvider1.SetError(txtHph, "Fill Phone Number");
            }
            else if (txtHEM.Text == "")
            {
                errorProvider1.SetError(txtHEM, "Fill Email");
            }
            else if (txtHZC.Text == "")
            {
                errorProvider1.SetError(txtHZC, "Fill Zip Code");
            }

            SqlCommand command; //declares a new sql command object            

            //field names in the table            
            string insert = @"insert into Hotel
           (Hotel_Name
           ,Address
           ,Phone_Number
           ,Email
           ,ZIPCode)
           VALUES(@Hotel_Name,@Address,@Phone_Number,@Email,@ZIPCode)";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    if (txtHAdd.Text != "" && txtHEM.Text != "" && txtHN.Text != "" && txtHph.Text != "" && txtHZC.Text != "")
                    {

                        conn.Open();//open the connection                    
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Hotel_Name", txtHN.Text);
                        command.Parameters.AddWithValue(@"Address", txtHAdd.Text);
                        command.Parameters.AddWithValue(@"Phone_Number", txtHph.Text);
                        command.Parameters.AddWithValue(@"Email", txtHEM.Text);
                        command.Parameters.AddWithValue(@"ZIPCode", txtHZC.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Hotel Added Succesfully!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
