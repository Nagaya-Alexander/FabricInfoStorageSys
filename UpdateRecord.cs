using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FabricInfo
{
    public partial class UpdateRecord : Form
    {
        public UpdateRecord()
        {
            InitializeComponent();
        }
        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            ShowFabInfo();
        }

        private void ShowFabInfo()
        {
            string connString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
            string sql = "select * from Fabrics";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvupdaterecord.DataSource = ds.Tables[0];
            }
        }

        private void btncellupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定修改吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {

                string connString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
                string sql = "update Fabrics set fabric_name = @fabric_name, fabric_composition = @fabric_composition, fabric_origin=@fabric_origin,supplier_id = @supplier_id ,production_batch=@production_batch,glossiness=glossiness,texture_and_structure=@texture_and_structure where fabric_id = @fabric_id";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fabric_id", dgvupdaterecord.CurrentRow.Cells[0].Value);
                    command.Parameters.AddWithValue("@fabric_name", dgvupdaterecord.CurrentRow.Cells[1].Value);
                    command.Parameters.AddWithValue("@fabric_composition", dgvupdaterecord.CurrentRow.Cells[2].Value);
                    command.Parameters.AddWithValue("@fabric_origin", dgvupdaterecord.CurrentRow.Cells[3].Value);
                    command.Parameters.AddWithValue("@supplier_id", dgvupdaterecord.CurrentRow.Cells[4].Value);
                    command.Parameters.AddWithValue("@production_batch", dgvupdaterecord.CurrentRow.Cells[5].Value);
                    command.Parameters.AddWithValue("@glossiness", dgvupdaterecord.CurrentRow.Cells[6].Value);
                    command.Parameters.AddWithValue("@texture_and_structure", dgvupdaterecord.CurrentRow.Cells[7].Value);
                    command.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
                }
            }
        }

        private void btnrowupdate_Click(object sender, EventArgs e)
        {
            string connString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // 从文本框获取更新后的数据
                string fabricId = tbfabid.Text;
                string fabricName = tbfabname.Text;
                string fabricComposition = tbfabcomposition.Text;
                string fabricOrigin = tbfaborigin.Text;
                string supplierId = tbsupid.Text;
                string productionBatch = tbprobatch.Text;
                int glossiness = Convert.ToInt32(tbfabglo.Text); // 确保类型匹配
                string textureAndStructure = tbfabtands.Text;

                // 使用参数化查询更新数据
                string sql = "UPDATE Fabrics SET fabric_name = @fabric_name, fabric_composition = @fabric_composition, " +
                             "fabric_origin = @fabric_origin, supplier_id = @supplier_id, production_batch = @production_batch, " +
                             "glossiness = @glossiness, texture_and_structure = @texture_and_structure " +
                             "WHERE fabric_id = @fabric_id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // 添加参数
                    command.Parameters.AddWithValue("@fabric_id", fabricId);
                    command.Parameters.AddWithValue("@fabric_name", fabricName);
                    command.Parameters.AddWithValue("@fabric_composition", fabricComposition);
                    command.Parameters.AddWithValue("@fabric_origin", fabricOrigin);
                    command.Parameters.AddWithValue("@supplier_id", supplierId);
                    command.Parameters.AddWithValue("@production_batch", productionBatch);
                    command.Parameters.AddWithValue("@glossiness", glossiness);
                    command.Parameters.AddWithValue("@texture_and_structure", textureAndStructure);

                    // 执行更新
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("修改成功！");
                        ShowFabInfo(); // 刷新数据
                    }
                    else
                    {
                        MessageBox.Show("修改失败！请检查数据。");
                    }
                }
            }
        }


        private void dgv_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvupdaterecord.CurrentRow.Selected)
            {
                tbfabid.Text = dgvupdaterecord.CurrentRow.Cells[0].Value.ToString();
                tbfabname.Text = dgvupdaterecord.CurrentRow.Cells[1].Value.ToString();
                tbfabcomposition.Text = dgvupdaterecord.CurrentRow.Cells[2].Value.ToString();
                tbfaborigin.Text = dgvupdaterecord.CurrentRow.Cells[3].Value.ToString();
                tbsupid.Text = dgvupdaterecord.CurrentRow.Cells[4].Value.ToString();
                tbprobatch.Text = dgvupdaterecord.CurrentRow.Cells[5].Value.ToString();
                tbfabglo.Text = dgvupdaterecord.CurrentRow.Cells[6].Value.ToString();
                tbfabtands.Text = dgvupdaterecord.CurrentRow.Cells[7].Value.ToString();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}