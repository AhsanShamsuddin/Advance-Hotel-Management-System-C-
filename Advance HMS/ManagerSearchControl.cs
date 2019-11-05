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
    public partial class ManagerSearchControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public ManagerSearchControl()
        {
            InitializeComponent();
        }

        private void ManagerSearchControl_Load(object sender, EventArgs e)
        {
            dgClient.DataSource = bindingSource1;
            GetClientData("select * from Clients");

            dgEmp.DataSource = bindingSource2;
            GetEmpData("select * from Employee");
        }


        private void GetClientData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
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
                bindingSource2.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            GetClientData("select * from Clients where lower(first_name) like '%" + txtClientSearch.Text.ToLower() + "%'");
        }

        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            GetEmpData("select * from Employee where lower(first_name) like '%" + txtEmpSearch.Text.ToLower() + "%'");
        }

        private void dgClient_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();  //get the update command    
            try
            {
                bindingSource1.EndEdit();//updates the table that is in memory in our program
                dataAdapter.Update(table);//actually updates the data base  
                dgClient.Columns[0].ReadOnly = true;
                MessageBox.Show("Update Successful!");//confirms to user update is saved to actual table in sql server  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show message to the user       
            }
        }

        private void dgEmp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();  //get the update command    
            try
            {
                bindingSource2.EndEdit();//updates the table that is in memory in our program
                dataAdapter.Update(table);//actually updates the data base  
                dgEmp.Columns[0].ReadOnly = true;
                MessageBox.Show("Update Successful!");//confirms to user update is saved to actual table in sql server  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show message to the user       
            }
        }
    }
}
