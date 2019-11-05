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
    public partial class OwnerRoomReportControl : UserControl
    {
        string conString = @"Data Source=DESKTOP-EQRC7TM\ARSALAN;Initial Catalog=Hotel;User ID=sa;Password=arsalan01";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public OwnerRoomReportControl()
        {
            InitializeComponent();
        }

        private void btnRRSearch_Click(object sender, EventArgs e)
        {
            GetData("select * from Room_Damage_Record where lower(Room_Id) like '%" + txtRRSearch.Text.ToLower() + "%'");
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

        private void OwnerRoomReportControl_Load(object sender, EventArgs e)
        {
            dgRoomReport.DataSource = bindingSource1;
            GetData("select * from Room_Damage_Record");
        }
    }
}
