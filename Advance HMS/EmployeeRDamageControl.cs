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
    public partial class EmployeeRDamageControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public EmployeeRDamageControl()
        {
            InitializeComponent();
        }

        private void EmployeeRDamageControl_Load(object sender, EventArgs e)
        {
            GetData("select (Room_Id) from Room");
        }

        private void btnAddDamage_Click(object sender, EventArgs e)
        {
            if (txtDA.Text == "")
            {
                errorProvider1.SetError(txtDA, "Enter Amount");
            }
            else if (cmbDPS.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(cmbDPS, "Select Status");
            }
            else if (cmbDT.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(cmbDT, "Select Damage Type");
            }

            SqlCommand command; //declares a new sql command object            

            //field names in the table            
            string insert = @"insert into Room_Damage_Record
           (Room_Id
           ,Damage_Amount
           ,Damage_Type
           ,Damage_Payment_Status)
           VALUES(@Room_Id,@Damage_Amount,@Damage_Type,@Damage_Payment_Status)";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    if (txtDA.Text != "")
                    {

                        conn.Open();//open the connection                    
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Room_Id", cmbRID.SelectedValue);
                        command.Parameters.AddWithValue(@"Damage_Amount", txtDA.Text);
                        command.Parameters.AddWithValue(@"Damage_Type", cmbDT.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"Damage_Payment_Status", cmbDPS.SelectedItem.ToString());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Room Damage Added Succesfully!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

                cmbRID.ValueMember = table.Columns[0].ToString();
                cmbRID.DisplayMember = table.Columns[0].ToString();
                cmbRID.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
