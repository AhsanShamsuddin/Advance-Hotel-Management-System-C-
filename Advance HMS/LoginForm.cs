using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDProject
{
    public partial class LoginForm : Form
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetOwnerData("select Own_User_Name, Own_Password from Own_Login where Own_User_Name = '" + txtUName.Text + "'and Own_Password = '" + txtPass.Text + "'");
            GetEmpData("select Emp_User_Name, Emp_Password from Emp_Login where Emp_User_Name = '" + txtUName.Text + "'and Emp_Password = '" + txtPass.Text + "'");
            GetRecepData("select Recep_First_Name, Recep_Last_Name from Recep_Login where Recep_First_Name = '" + txtUName.Text + "'and Recep_Last_Name = '" + txtPass.Text + "'");
            GetManagerData("select Man_User_Name, Man_Password from Man_Login where Man_User_Name = '" + txtUName.Text + "'and Man_Password = '" + txtPass.Text + "'");

            if (txtUName.Text == "")
            {
                errorProvider1.SetError(txtUName, "Fill User Name");
            }
            else if(txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "Fill Password");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form1().Show();
        }

        private void GetOwnerData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                { 
                    this.Visible = false;
                    new OwnerForm().Show();
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetEmpData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Visible = false;
                    new EmployeeForm().Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetManagerData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Visible = false;
                    new ManagerForm().Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetRecepData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Visible = false;
                    new ReceptionistForm().Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
