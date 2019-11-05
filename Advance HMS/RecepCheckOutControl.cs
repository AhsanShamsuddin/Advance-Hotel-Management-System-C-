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
    public partial class RecepCheckOutControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;


        public RecepCheckOutControl()
        {
            InitializeComponent();
        }

        private void RecepCheckOutControl_Load(object sender, EventArgs e)
        {
            GetData("select (Client_Id) from Clients");
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

                cbClientID.ValueMember = table.Columns[0].ToString();
                cbClientID.DisplayMember = table.Columns[0].ToString();
                cbClientID.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            string deleteState = @"Delete from Clients where Client_Id = '" + cbClientID.SelectedValue.ToString() + "'"; 

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(deleteState, conn);

                        comm.ExecuteNonQuery();
                        GetClientData(deleteState);
                        MessageBox.Show("Check Out Succesfully");

                        
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private void GetClientData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
