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

namespace FabricInfo
{
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            ShowFabInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvupdaterecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                dgvdeleteInfo.DataSource = ds.Tables[0];
            }
        }
        private void dgvdeleteInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvdeleteInfo.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("确定要删除这条记录吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dgvdeleteInfo.SelectedRows[0].Index;
                    // 获取fabric_id列的值，确保它是字符串类型
                    var fabricIdValue = dgvdeleteInfo["fabric_id", selectedIndex].Value.ToString();

                    if (!string.IsNullOrEmpty(fabricIdValue))
                    {
                        string connString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
                        string sql = "DELETE FROM Fabrics WHERE fabric_id = @Id";
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            SqlCommand command = new SqlCommand(sql, connection);
                            // 将fabric_id作为字符串传递
                            command.Parameters.AddWithValue("@Id", fabricIdValue);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        // 删除后刷新显示
                        ShowFabInfo();
                    }
                    else
                    {
                        MessageBox.Show("fabric_id 无效，无法进行删除操作。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的记录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
