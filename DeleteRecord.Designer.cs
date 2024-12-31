namespace FabricInfo
{
    partial class DeleteRecord
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
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdeleteInfo = new System.Windows.Forms.DataGridView();
            this.fabric_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glossiness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texture_and_structure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleteInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(826, 16);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 40);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "请谨慎删除！！！";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvdeleteInfo
            // 
            this.dgvdeleteInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeleteInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fabric_id,
            this.fabric_name,
            this.fabric_composition,
            this.fabric_origin,
            this.supplier_id,
            this.production_batch,
            this.glossiness,
            this.texture_and_structure});
            this.dgvdeleteInfo.Location = new System.Drawing.Point(12, 69);
            this.dgvdeleteInfo.Name = "dgvdeleteInfo";
            this.dgvdeleteInfo.RowHeadersWidth = 30;
            this.dgvdeleteInfo.RowTemplate.Height = 27;
            this.dgvdeleteInfo.Size = new System.Drawing.Size(1030, 323);
            this.dgvdeleteInfo.TabIndex = 3;
            this.dgvdeleteInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeleteInfo_CellContentClick);
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
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 404);
            this.Controls.Add(this.dgvdeleteInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Name = "DeleteRecord";
            this.Text = "删除信息";
            this.Load += new System.EventHandler(this.DeleteRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleteInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdeleteInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn production_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn glossiness;
        private System.Windows.Forms.DataGridViewTextBoxColumn texture_and_structure;
    }
}