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
    public partial class RecepReserveControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public RecepReserveControl()
        {
            InitializeComponent();
        }

        private void RecepReserveControl_Load(object sender, EventArgs e)
        {
            recepBillControl1.Hide();
            GetData("select (Room_Id) from Room");
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            if(txtFN.Text == "")
            {
                errorProvider1.SetError(txtFN, "Fill The First Name");
            }
            else if (txtLN.Text == "")
            {
                errorProvider1.SetError(txtLN, "Fill The Last Name");
            }
            else if (txtAdd.Text == "")
            {
                errorProvider1.SetError(txtAdd, "Fill Address");
            }
            else if (txtNUM.Text == "")
            {
                errorProvider1.SetError(txtNUM, "Fill Phone Number");
            }
            else if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Enter Email");
            }
            else if (dtChkIn.Text == "")
            {
                errorProvider1.SetError(dtChkIn, "Select Chech In Date");
            }
            else if (dtChkOut.Text == "")
            {
                errorProvider1.SetError(dtChkOut, "Select Chech Out Date");
            }
            else if (cmbRT.Text == "")
            {
                errorProvider1.SetError(cmbRT, "Select Room Type");
            }
            else if (ncQTY.Value.ToString() == "" && ncQTY.Value > 0)
            {
                errorProvider1.SetError(ncQTY, "Select Room Quantity");
            }
            else if (cbRID.Text == "")
            {
                errorProvider1.SetError(cbRID, "Select Room ID");
            }

            SqlCommand command; //declares a new sql command object            

            //field names in the table            
            string insert = @"insert into Clients
           (First_Name
           ,Last_Name
           ,DOB
           ,Address
           ,Phone_Number
           ,Email
           ,Check_In, Check_Out, Room_Type, Room_QTY, Room_Id)
           VALUES(@First_Name,@Last_Name,@DOB,@Address,@Phone_Number,@Email,@Check_In,@Check_Out,@Room_Type,@Room_QTY,@Room_Id)SELECT SCOPE_IDENTITY()";
            
            string insert2 = @"insert into Bill
           (Amount
           ,Client_First_Name
           ,Client_Last_Name)
           VALUES(@Amount,@Client_First_Name,@Client_Last_Name)";

            string insert1 = @"insert into Invoice
           (Invoice_Status
           ,Invoice_Date
           ,Invoice_Description)
           VALUES(@Invoice_Status,@Invoice_Date,@Invoice_Description)";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    if (txtAdd.Text != "" && ncQTY.Value > 0 && txtEmail.Text != "" && txtFN.Text != "" && txtLN.Text != "" && txtNUM.Text != "" && cbRID.Text != "" && ncQTY.Value.ToString() != "" && dtChkIn.Text != "" && dtChkOut.Text != "" && dtDOB.Text != "" && cmbRT.Text != "")
                    {

                        conn.Open();//open the connection                    
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"First_Name", txtFN.Text);
                        command.Parameters.AddWithValue(@"Last_Name", txtLN.Text);
                        command.Parameters.AddWithValue(@"DOB", dtDOB.Value.Date);
                        command.Parameters.AddWithValue(@"Address", txtAdd.Text);
                        command.Parameters.AddWithValue(@"Phone_Number", txtNUM.Text);
                        command.Parameters.AddWithValue(@"Email", txtEmail.Text);
                        command.Parameters.AddWithValue(@"Check_In", dtChkIn.Value.Date);
                        command.Parameters.AddWithValue(@"Check_Out", dtChkOut.Value.Date);
                        command.Parameters.AddWithValue(@"Room_Type", cmbRT.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"Room_QTY", ncQTY.Value.ToString());
                        command.Parameters.AddWithValue(@"Room_Id", cbRID.SelectedValue);
                        //command.Parameters.AddWithValue(@"Taken", "Yes");
                        command.ExecuteNonQuery();

                        errorProvider1.Dispose();

                        MessageBox.Show("Reserved Succesfully!");
                        recepBillControl1.SetNameText(txtFN.Text);
                        recepBillControl1.SetRoomType(cmbRT.SelectedItem.ToString());
                        recepBillControl1.SetRoomQTY(ncQTY.Value.ToString());
                        recepBillControl1.SetCheckIn(dtChkIn.Value.ToShortDateString());
                        recepBillControl1.SetCheckOut(dtChkOut.Value.ToShortDateString());
                        recepBillControl1.getDateDifference(dtChkIn.Value.Date, dtChkOut.Value.Date);
                        recepBillControl1.Show();
                        recepBillControl1.SetEmail(txtEmail.Text);
                    }

                    if (txtFN.Text != "" && txtLN.Text != "")
                    {
                        command = new SqlCommand(insert2, conn);
                        command.Parameters.AddWithValue(@"Amount", recepBillControl1.getTotalPrice());
                        command.Parameters.AddWithValue(@"Client_First_Name", txtFN.Text);
                        command.Parameters.AddWithValue(@"Client_Last_Name", txtLN.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bill Generated!");
                        errorProvider1.Dispose();
                    }

                    if (dtChkIn.Value.ToString() != "" && txtFN.Text != "")
                    {
                        command = new SqlCommand(insert1, conn);
                        command.Parameters.AddWithValue(@"Invoice_Status", "On");
                        command.Parameters.AddWithValue(@"Invoice_Date", dtChkIn.Value.ToShortDateString());
                        command.Parameters.AddWithValue(@"Invoice_Description", txtFN.Text + " " + cmbRT.SelectedItem.ToString() + " " + ncQTY.Value.ToString());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Invoice Generated!");
                        errorProvider1.Dispose();
                    }

                        txtFN.Text = "";
                        txtLN.Text = "";
                        txtAdd.Text = "";
                        txtNUM.Text = "";
                        txtEmail.Text = "";
                        dtChkIn.ResetText();
                        dtChkOut.ResetText();
                        cmbRT.ResetText();
                        ncQTY.ResetText();
                        dtDOB.ResetText();
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

                cbRID.ValueMember = table.Columns[0].ToString();
                cbRID.DisplayMember = table.Columns[0].ToString();
                cbRID.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetRoomData(string selectCommand)
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

        private void recepBillControl1_Load(object sender, EventArgs e)
        {
            new RecepReserveControl().Hide();

        }
    }
}
