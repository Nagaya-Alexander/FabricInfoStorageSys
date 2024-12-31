using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FabricInfo
{
    public partial class SelectInfo : Form
    {
        public SelectInfo()
        {
            InitializeComponent();
        }

        private void dgvselevtinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectInfo_Load(object sender, EventArgs e)
        {
            ShowSelectInfo();
        }

        public void ShowSelectInfo(string fabId = "", string fabName = "", string supId = "")
        {
            string connString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
            StringBuilder sql = new StringBuilder("select * from Fabrics where 1=1");

            if (!string.IsNullOrEmpty(fabId))
            {
                sql.Append(" and fabric_id like @fabId");
            }
            if (!string.IsNullOrEmpty(fabName))
            {
                sql.Append(" and fabric_name like @fabName");
            }
            if (!string.IsNullOrEmpty(supId))
            {
                sql.Append(" and supplier_id like @supId");
            }

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), connection);
                if (!string.IsNullOrEmpty(fabId))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@fabId", "%" + fabId + "%");
                }
                if (!string.IsNullOrEmpty(fabName))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@fabName", "%" + fabName + "%");
                }
                if (!string.IsNullOrEmpty(supId))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@supId", "%" + supId + "%");
                }
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvselevtinfo.DataSource = ds.Tables[0];
            }
        }


        private void tbfabinfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            string fabId = tbfabid.Text.Trim();
            string fabName = tbfabname.Text.Trim();
            string supId = tbsupid.Text.Trim();
            ShowSelectInfo(fabId, fabName, supId);
        }
    }
}
