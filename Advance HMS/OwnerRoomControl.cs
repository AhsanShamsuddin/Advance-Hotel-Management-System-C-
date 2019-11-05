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
    public partial class OwnerRoomControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public OwnerRoomControl()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cbHotelID.Text == "")
            {
                errorProvider1.SetError(cbHotelID, "Select Hotel ID");
            }
            else if (cbRType.Text == "")
            {
                errorProvider1.SetError(cbRType, "Select Room Type");
            }
            else if (txtSTD.Text == "")
            {
                errorProvider1.SetError(txtSTD, "Fill STD Room Price");
            }
            else if (txtDEL.Text == "")
            {
                errorProvider1.SetError(txtDEL, "Fill DEL Room Price");
            }
            else if (txtPRE.Text == "")
            {
                errorProvider1.SetError(txtPRE, "Fill PRE Room Price");
            }

            SqlCommand command; //declares a new sql command object            

            //field names in the table            
            string insert = @"insert into Room
           (Hotel_Id
           ,Room_Type
           ,Std_Room_Price
           ,Del_Room_Price
           ,Pre_Room_Price)
           VALUES(@Hotel_Id,@Room_Type,@Std_Room_Price,@Del_Room_Price,@Pre_Room_Price)";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    if (txtDEL.Text != "" && txtPRE.Text != "" && txtSTD.Text != "" && cbHotelID.Text != "" && cbRType.Text != "")
                    {

                        conn.Open();//open the connection                    
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Hotel_Id", cbHotelID.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"Room_Type", cbRType.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"Std_Room_Price", txtSTD.Text);
                        command.Parameters.AddWithValue(@"Del_Room_Price", txtDEL.Text);
                        command.Parameters.AddWithValue(@"Pre_Room_Price", txtPRE.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Room Added Succesfully!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void OwnerRoomControl_Load(object sender, EventArgs e)
        {
            GetData("select (Hotel_Id) from Hotel");
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                cbHotelID.Items.Add(table.Rows[0][0]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
