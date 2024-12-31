namespace FabricInfo
{
    partial class SelectInfo
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
            this.btnselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvselevtinfo = new System.Windows.Forms.DataGridView();
            this.fabric_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glossiness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texture_and_structure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfabid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfabname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsupid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselevtinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(613, 64);
            this.btnselect.Margin = new System.Windows.Forms.Padding(4);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(69, 37);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "查询";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "面料编号";
            // 
            // dgvselevtinfo
            // 
            this.dgvselevtinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselevtinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fabric_id,
            this.fabric_name,
            this.fabric_composition,
            this.fabric_origin,
            this.supplier_id,
            this.production_batch,
            this.glossiness,
            this.texture_and_structure});
            this.dgvselevtinfo.Location = new System.Drawing.Point(23, 107);
            this.dgvselevtinfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvselevtinfo.Name = "dgvselevtinfo";
            this.dgvselevtinfo.RowHeadersWidth = 51;
            this.dgvselevtinfo.RowTemplate.Height = 27;
            this.dgvselevtinfo.Size = new System.Drawing.Size(1051, 384);
            this.dgvselevtinfo.TabIndex = 3;
            this.dgvselevtinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvselevtinfo_CellContentClick);
            // 
            // fabric_id
            // 
            this.fabric_id.DataPropertyName = "fabric_id";
            this.fabric_id.HeaderText = "面料编号";
            this.fabric_id.MinimumWidth = 6;
            this.fabric_id.Name = "fabric_id";
            this.fabric_id.Width = 125;
            // 
            // fabric_name
            // 
            this.fabric_name.DataPropertyName = "fabric_name";
            this.fabric_name.HeaderText = "面料名称";
            this.fabric_name.MinimumWidth = 6;
            this.fabric_name.Name = "fabric_name";
            this.fabric_name.Width = 125;
            // 
            // fabric_composition
            // 
            this.fabric_composition.DataPropertyName = "fabric_composition";
            this.fabric_composition.HeaderText = "面料成分";
            this.fabric_composition.MinimumWidth = 6;
            this.fabric_composition.Name = "fabric_composition";
            this.fabric_composition.Width = 125;
            // 
            // fabric_origin
            // 
            this.fabric_origin.DataPropertyName = "fabric_origin";
            this.fabric_origin.HeaderText = "面料产地";
            this.fabric_origin.MinimumWidth = 6;
            this.fabric_origin.Name = "fabric_origin";
            this.fabric_origin.Width = 125;
            // 
            // supplier_id
            // 
            this.supplier_id.DataPropertyName = "supplier_id";
            this.supplier_id.HeaderText = "供应商编号";
            this.supplier_id.MinimumWidth = 6;
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Width = 125;
            // 
            // production_batch
            // 
            this.production_batch.DataPropertyName = "production_batch";
            this.production_batch.HeaderText = "生产批次";
            this.production_batch.MinimumWidth = 6;
            this.production_batch.Name = "production_batch";
            this.production_batch.Width = 125;
            // 
            // glossiness
            // 
            this.glossiness.DataPropertyName = "glossiness";
            this.glossiness.HeaderText = "光泽度";
            this.glossiness.MinimumWidth = 6;
            this.glossiness.Name = "glossiness";
            this.glossiness.Width = 125;
            // 
            // texture_and_structure
            // 
            this.texture_and_structure.DataPropertyName = "texture_and_structure";
            this.texture_and_structure.HeaderText = "织物组织";
            this.texture_and_structure.MinimumWidth = 6;
            this.texture_and_structure.Name = "texture_and_structure";
            this.texture_and_structure.Width = 125;
            // 
            // tbfabid
            // 
            this.tbfabid.Location = new System.Drawing.Point(236, 25);
            this.tbfabid.Name = "tbfabid";
            this.tbfabid.Size = new System.Drawing.Size(178, 27);
            this.tbfabid.TabIndex = 4;
            this.tbfabid.TextChanged += new System.EventHandler(this.tbfabinfo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(102, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "面料名称";
            // 
            // tbfabname
            // 
            this.tbfabname.Location = new System.Drawing.Point(236, 70);
            this.tbfabname.Name = "tbfabname";
            this.tbfabname.Size = new System.Drawing.Size(178, 27);
            this.tbfabname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(462, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "供应商编号";
            // 
            // tbsupid
            // 
            this.tbsupid.Location = new System.Drawing.Point(590, 25);
            this.tbsupid.Name = "tbsupid";
            this.tbsupid.Size = new System.Drawing.Size(168, 27);
            this.tbsupid.TabIndex = 8;
            // 
            // SelectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 515);
            this.Controls.Add(this.tbsupid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbfabname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbfabid);
            this.Controls.Add(this.dgvselevtinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnselect);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectInfo";
            this.Text = "查询面料信息";
            this.Load += new System.EventHandler(this.SelectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvselevtinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvselevtinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn production_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn glossiness;
        private System.Windows.Forms.DataGridViewTextBoxColumn texture_and_structure;
        private System.Windows.Forms.TextBox tbfabid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfabname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsupid;
    }
}