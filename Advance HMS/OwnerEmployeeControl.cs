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
    public partial class OwnerEmployeeControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public OwnerEmployeeControl()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (cbHID.Text == "")
            {
                errorProvider1.SetError(cbHID, "Select Hotel ID");
            }
            else if (txtEFN.Text == "")
            {
                errorProvider1.SetError(txtEFN, "Fill The First Name");
            }
            else if (txtELN.Text == "")
            {
                errorProvider1.SetError(txtELN, "Fill The Last Name");
            }
            else if (cbEPost.Text == "")
            {
                errorProvider1.SetError(cbEPost, "Select The Post");
            }
            else if (txtEAdd.Text == "")
            {
                errorProvider1.SetError(txtEAdd, "Fill Address");
            }
            else if (txtEPhNum.Text == "")
            {
                errorProvider1.SetError(txtEPhNum, "Enter Phone Number");
            }
            else if (txtEemail.Text == "")
            {
                errorProvider1.SetError(txtEemail, "Enter Email");
            }

            SqlCommand command; //declares a new sql command object            

            //field names in the table            
            string insert = @"insert into Employee
           (Hotel_Id
           ,First_Name
           ,Last_Name
           ,Post
           ,Address,Phone_Number,Email)
           VALUES(@Hotel_Id,@First_Name,@Last_Name,@Post,@Address,@Phone_Number,@Email)";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    if (txtEAdd.Text != "" && txtEemail.Text != "" && txtEFN.Text != "" && txtELN.Text != "" && txtEPhNum.Text != "" && cbEPost.Text != "" && cbHID.Text != "")
                    {

                        conn.Open();//open the connection                    
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Hotel_Id", cbHID.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"First_Name", txtEFN.Text);
                        command.Parameters.AddWithValue(@"Last_Name", txtELN.Text);
                        command.Parameters.AddWithValue(@"Post", cbEPost.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"Address", txtEAdd.Text);
                        command.Parameters.AddWithValue(@"Phone_Number", txtEPhNum.Text);
                        command.Parameters.AddWithValue(@"Email", txtEemail.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Employee Added Succesfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbEPost.Text != "")
            {
                if (cbEPost.SelectedItem.ToString() == "Staff")
                {
                    string insert1 = @"insert into Emp_Login
                   (Emp_User_Name
                   ,Emp_Password)
                   VALUES(@Emp_User_Name,@Emp_Password)";

                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        try
                        {
                            conn.Open();//open the connection                    
                            command = new SqlCommand(insert1, conn);
                            command.Parameters.AddWithValue(@"Emp_User_Name", txtEFN.Text);
                            command.Parameters.AddWithValue(@"Emp_Password", txtEPhNum.Text);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            if (cbEPost.Text != "")
            {
                if (cbEPost.SelectedItem.ToString() == "Receptionist")
                {
                    string insert2 = @"insert into Recep_Login
                   (Recep_First_Name
                   ,Recep_Last_Name)
                   VALUES(@Recep_First_Name,@Recep_Last_Name)";

                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        try
                        {
                            conn.Open();//open the connection                    
                            command = new SqlCommand(insert2, conn);
                            command.Parameters.AddWithValue(@"Recep_First_Name", txtEFN.Text);
                            command.Parameters.AddWithValue(@"Recep_Last_Name", txtEPhNum.Text);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            if (cbEPost.Text != "")
            {
                if (cbEPost.SelectedItem.ToString() == "Manager")
                {
                    string insert3 = @"insert into Man_Login
                   (Man_User_Name
                   ,Man_Password)
                   VALUES(@Man_User_Name,@Man_Password)";

                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        try
                        {
                            conn.Open();//open the connection                    
                            command = new SqlCommand(insert3, conn);
                            command.Parameters.AddWithValue(@"Man_User_Name", txtEFN.Text);
                            command.Parameters.AddWithValue(@"Man_Password", txtEPhNum.Text);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
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
                cbHID.Items.Add(table.Rows[0][0]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OwnerEmployeeControl_Load(object sender, EventArgs e)
        {
            GetData("select (Hotel_Id) from Hotel");
        }
    }
}
