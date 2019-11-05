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
    public partial class RecepSearchControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter; 
        DataTable table;

        public RecepSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetData("select * from Clients where lower(first_name) like '%" + txtSearch.Text.ToLower() + "%'");
        }

        private void GetData(string selectCommand)
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

        private void RecepSearchControl_Load(object sender, EventArgs e)
        {
            dgSearch.DataSource = bindingSource1;
            GetData("select * from Clients");
        }

        private void dgSearch_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();  //get the update command    
            try
            {
                bindingSource1.EndEdit();//updates the table that is in memory in our program
                dataAdapter.Update(table);//actually updates the data base  
                dgSearch.Columns[0].ReadOnly = true;
                MessageBox.Show("Update Successful!");//confirms to user update is saved to actual table in sql server  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show message to the user       
            }

        }
    }
}
