using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricInfo
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void selectinfo_click(object sender, EventArgs e)
        {
            SelectInfo selectinfo = null;
            if (Application.OpenForms["SelectInfo"]!=null)
            {
                selectinfo = (SelectInfo)Application.OpenForms["SelectInfo"];
            }
            else
            {
                selectinfo = new SelectInfo();
                selectinfo.MdiParent = this;
                selectinfo.Show();
            }
            
        }

        private void addrecord_click(object sender, EventArgs e)
        {
            AddRecord addrecord =null;
            if (Application.OpenForms["AddRecord"]!=null){
                addrecord = (AddRecord)Application.OpenForms["AddRecord"];

            }
            else
            {
                addrecord = new AddRecord();
                addrecord.MdiParent = this;
                addrecord.Show();
        }
            }


        private void deleterecord_click(object sender, EventArgs e)
        {

            DeleteRecord deleterecord = null;
            if (Application.OpenForms["DeleteRecord"] != null)
            {
                deleterecord = (DeleteRecord)Application.OpenForms["DeleteRecord"];
            }
            else
            {
                deleterecord = new DeleteRecord();
                deleterecord.MdiParent = this;
                deleterecord.Show();
            }
        }
        private void updaterecord_click(object sender, EventArgs e)
        {
            UpdateRecord updaterecord = null;
            if (Application.OpenForms["UpdateRecord"] != null)
            {
                updaterecord = (UpdateRecord)Application.OpenForms["UpdateRecord"];

            }
            else
            {
                updaterecord = new UpdateRecord();
                updaterecord.MdiParent = this;
                updaterecord.Show();
            }
        }

        private void exitsys_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
