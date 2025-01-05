namespace FabricInfo
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addrecord = new System.Windows.Forms.ToolStripMenuItem();
            this.deleterecord = new System.Windows.Forms.ToolStripMenuItem();
            this.updaterecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnadmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnadmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectinfo,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectinfo
            // 
            this.selectinfo.Name = "selectinfo";
            this.selectinfo.Size = new System.Drawing.Size(83, 24);
            this.selectinfo.Text = "查询信息";
            this.selectinfo.Click += new System.EventHandler(this.selectinfo_click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addrecord,
            this.deleterecord,
            this.updaterecord});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "修改数据";
            // 
            // addrecord
            // 
            this.addrecord.Name = "addrecord";
            this.addrecord.Size = new System.Drawing.Size(224, 26);
            this.addrecord.Text = "添加记录";
            this.addrecord.Click += new System.EventHandler(this.addrecord_click);
            // 
            // deleterecord
            // 
            this.deleterecord.Name = "deleterecord";
            this.deleterecord.Size = new System.Drawing.Size(224, 26);
            this.deleterecord.Text = "删除记录";
            this.deleterecord.Click += new System.EventHandler(this.deleterecord_click);
            // 
            // updaterecord
            // 
            this.updaterecord.Name = "updaterecord";
            this.updaterecord.Size = new System.Drawing.Size(224, 26);
            this.updaterecord.Text = "更新记录";
            this.updaterecord.Click += new System.EventHandler(this.updaterecord_click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem2.Text = "退出系统";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.exitsys_click);
            // 
            // pnadmin
            // 
            this.pnadmin.Controls.Add(this.label1);
            this.pnadmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnadmin.Location = new System.Drawing.Point(0, 28);
            this.pnadmin.Name = "pnadmin";
            this.pnadmin.Size = new System.Drawing.Size(846, 533);
            this.pnadmin.TabIndex = 2;
            this.pnadmin.AutoSizeChanged += new System.EventHandler(this.FormAdmin_Load);
            this.pnadmin.DockChanged += new System.EventHandler(this.pnadmin_DockChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(294, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎您，管理员！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 561);
            this.Controls.Add(this.pnadmin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "管理员操作界面";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnadmin.ResumeLayout(false);
            this.pnadmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectinfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addrecord;
        private System.Windows.Forms.ToolStripMenuItem deleterecord;
        private System.Windows.Forms.ToolStripMenuItem updaterecord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel pnadmin;
        private System.Windows.Forms.Label label1;
    }
}