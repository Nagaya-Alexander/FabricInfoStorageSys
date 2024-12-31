using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FabricInfo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Isempty())
            {
                int userRoleId = Login();
                if (userRoleId != -1)
                {
                    MessageBox.Show("登录成功！");
                    FormAdmin admin = new FormAdmin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
        }

        public int Login()
        {
            int userRoleId = -1;
            String userid = UserID.Text.Trim();
            String userpassword = UserPassword.Text.Trim();
            String connString = "Data Source = .;Initial Catalog = fabric;Integrated Security = True";
            String sql = "select user_role_id from UserInfo where user_id ='" + userid + "'and user_password = '" + userpassword + "'";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userId", UserID.Text.Trim());
                command.Parameters.AddWithValue("@userPassword", UserPassword.Text.Trim());

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        userRoleId = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接失败：" + ex.Message);
                }
            }

            return userRoleId;
        }

        public bool Isempty()
        {
            if (UserID.Text.Trim() == String.Empty)
            {
                MessageBox.Show("未输入用户名！");
                return false;
            }
            if (UserPassword.Text.Trim() == String.Empty)
            {
                MessageBox.Show("未输入密码！");
                return false;
            }
            return true;
        }
    }
}