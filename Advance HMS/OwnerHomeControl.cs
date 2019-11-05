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
    public partial class OwnerHomeControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public OwnerHomeControl()
        {
            InitializeComponent();
        }

        private void OwnerHomeControl_Load(object sender, EventArgs e)
        {
            lblTC.Text = "0";
            lblTR.Text = "0";
        }

        public void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    lblTC.Text = table.Rows.Count.ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetRevenueData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                lblTR.Text = table.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetDamageData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    lblRD.Text = table.Rows.Count.ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetResolvedData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    lblRDC.Text = table.Rows.Count.ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
