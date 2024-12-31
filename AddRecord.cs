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
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddRecord_Load(object sender, EventArgs e)
        {

        }

        private void makeEmpty_click(object sender, EventArgs e)
        {
            foreach (Control con in groupBox1.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
            foreach (Control con in groupBox2.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
        }

        private void takePreserve_click(object sender, EventArgs e)
        {
            string fabric_id = tbfabid.Text.Trim();
            string fabric_name = tbfabname.Text.Trim();
            string fabric_composition = tbfabcomposition.Text.Trim();
            string fabric_origin = tbfaborigin.Text.Trim();
            string supplier_id = tbsupid.Text.Trim();
            string production_batch = tbprobatch.Text.Trim();
            string glossiness = tbfabglo.Text.Trim();
            string texture_and_structure = tbfabtands.Text.Trim();

            if (string.IsNullOrEmpty(fabric_id) || string.IsNullOrEmpty(fabric_name) || string.IsNullOrEmpty(fabric_composition) ||
                string.IsNullOrEmpty(fabric_origin) || string.IsNullOrEmpty(supplier_id) || string.IsNullOrEmpty(production_batch) ||
                string.IsNullOrEmpty(glossiness) || string.IsNullOrEmpty(texture_and_structure))
            {
                MessageBox.Show("所有字段均为必填项，请填写完整!");
                return;
            }

            if (!int.TryParse(glossiness, out _))
            {
                if (!double.TryParse(glossiness, out _))
                {
                    MessageBox.Show("光泽度必须为数字!");
                    return;
                }
            }

            String connectionString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkFabricIdQuery = "SELECT COUNT(*) FROM fabrics WHERE fabric_id = @fabric_id";
                using (SqlCommand checkFabricIdCommand = new SqlCommand(checkFabricIdQuery, connection))
                {
                    checkFabricIdCommand.Parameters.AddWithValue("@fabric_id", fabric_id);
                    int fabricIdCount = (int)checkFabricIdCommand.ExecuteScalar();
                    if (fabricIdCount > 0)
                    {
                        MessageBox.Show("面料ID已存在!");
                        return;
                    }
                }

                string checkSupplierIdQuery = "SELECT COUNT(*) FROM suppliers WHERE supplier_id = @supplier_id";
                using (SqlCommand checkSupplierIdCommand = new SqlCommand(checkSupplierIdQuery, connection))
                {
                    checkSupplierIdCommand.Parameters.AddWithValue("@supplier_id", supplier_id);
                    int supplierIdCount = (int)checkSupplierIdCommand.ExecuteScalar();
                    if (supplierIdCount == 0)
                    {
                        MessageBox.Show("供应商ID不存在，请先添加供应商信息!");
                        return;
                    }
                }

                string query = "INSERT INTO fabrics (fabric_id, fabric_name, fabric_composition, fabric_origin, supplier_id, production_batch, glossiness, texture_and_structure) " +
                               "VALUES (@fabric_id, @fabric_name, @fabric_composition, @fabric_origin, @supplier_id, @production_batch, @glossiness, @texture_and_structure)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fabric_id", fabric_id);
                    command.Parameters.AddWithValue("@fabric_name", fabric_name);
                    command.Parameters.AddWithValue("@fabric_composition", fabric_composition);
                    command.Parameters.AddWithValue("@fabric_origin", fabric_origin);
                    command.Parameters.AddWithValue("@supplier_id", supplier_id);
                    command.Parameters.AddWithValue("@production_batch", production_batch);
                    command.Parameters.AddWithValue("@glossiness", glossiness);
                    command.Parameters.AddWithValue("@texture_and_structure", texture_and_structure);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("记录添加成功!");
        }
    }
}
