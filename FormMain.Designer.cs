namespace FabricInfo
{

    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.logpanel = new System.Windows.Forms.Panel();
            this.pnbackground = new System.Windows.Forms.Panel();
            this.logpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(52, 278);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 15);
            this.Password.TabIndex = 1;
            this.Password.Text = "密  码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(181, 347);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(35, 347);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(76, 25);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(134, 217);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(100, 25);
            this.UserID.TabIndex = 4;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(134, 275);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(100, 25);
            this.UserPassword.TabIndex = 5;
            // 
            // logpanel
            // 
            this.logpanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.logpanel.Controls.Add(this.label1);
            this.logpanel.Controls.Add(this.UserPassword);
            this.logpanel.Controls.Add(this.Password);
            this.logpanel.Controls.Add(this.UserID);
            this.logpanel.Controls.Add(this.btnLogin);
            this.logpanel.Controls.Add(this.btnexit);
            this.logpanel.Location = new System.Drawing.Point(644, 0);
            this.logpanel.Name = "logpanel";
            this.logpanel.Size = new System.Drawing.Size(301, 597);
            this.logpanel.TabIndex = 6;
            // 
            // pnbackground
            // 
            this.pnbackground.AutoSize = true;
            this.pnbackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnbackground.BackgroundImage = global::FabricInfo.Properties.Resources.fabric01;
            this.pnbackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnbackground.Location = new System.Drawing.Point(-2, 0);
            this.pnbackground.Name = "pnbackground";
            this.pnbackground.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnbackground.Size = new System.Drawing.Size(649, 597);
            this.pnbackground.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 596);
            this.Controls.Add(this.pnbackground);
            this.Controls.Add(this.logpanel);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.logpanel.ResumeLayout(false);
            this.logpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Panel logpanel;
        private System.Windows.Forms.Panel pnbackground;
    }
}

