namespace FabricInfo
{
    partial class UpdateRecord
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
            this.dgvupdaterecord = new System.Windows.Forms.DataGridView();
            this.fabric_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric_origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glossiness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texture_and_structure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncellupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbfabid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbfabname = new System.Windows.Forms.TextBox();
            this.tbfabcomposition = new System.Windows.Forms.TextBox();
            this.tbfaborigin = new System.Windows.Forms.TextBox();
            this.tbsupid = new System.Windows.Forms.TextBox();
            this.tbprobatch = new System.Windows.Forms.TextBox();
            this.tbfabglo = new System.Windows.Forms.TextBox();
            this.tbfabtands = new System.Windows.Forms.TextBox();
            this.editregion = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnrowupdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdaterecord)).BeginInit();
            this.editregion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvupdaterecord
            // 
            this.dgvupdaterecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvupdaterecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fabric_id,
            this.fabric_name,
            this.fabric_composition,
            this.fabric_origin,
            this.supplier_id,
            this.production_batch,
            this.glossiness,
            this.texture_and_structure});
            this.dgvupdaterecord.Location = new System.Drawing.Point(8, 21);
            this.dgvupdaterecord.Name = "dgvupdaterecord";
            this.dgvupdaterecord.RowHeadersWidth = 51;
            this.dgvupdaterecord.RowTemplate.Height = 27;
            this.dgvupdaterecord.Size = new System.Drawing.Size(1042, 209);
            this.dgvupdaterecord.TabIndex = 0;
            this.dgvupdaterecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cellClick);
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
            // btncellupdate
            // 
            this.btncellupdate.Location = new System.Drawing.Point(817, 295);
            this.btncellupdate.Name = "btncellupdate";
            this.btncellupdate.Size = new System.Drawing.Size(133, 41);
            this.btncellupdate.TabIndex = 1;
            this.btncellupdate.Text = "保存（单元格修改）";
            this.btncellupdate.UseVisualStyleBackColor = true;
            this.btncellupdate.Click += new System.EventHandler(this.btncellupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "面料编号";
            // 
            // tbfabid
            // 
            this.tbfabid.Location = new System.Drawing.Point(127, 32);
            this.tbfabid.Name = "tbfabid";
            this.tbfabid.ReadOnly = true;
            this.tbfabid.Size = new System.Drawing.Size(137, 22);
            this.tbfabid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "面料产地";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "供应商编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "生产批次";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "光泽度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "纹路组织";
            // 
            // tbfabname
            // 
            this.tbfabname.Location = new System.Drawing.Point(127, 80);
            this.tbfabname.Name = "tbfabname";
            this.tbfabname.Size = new System.Drawing.Size(137, 22);
            this.tbfabname.TabIndex = 11;
            // 
            // tbfabcomposition
            // 
            this.tbfabcomposition.Location = new System.Drawing.Point(127, 130);
            this.tbfabcomposition.Name = "tbfabcomposition";
            this.tbfabcomposition.Size = new System.Drawing.Size(137, 22);
            this.tbfabcomposition.TabIndex = 12;
            // 
            // tbfaborigin
            // 
            this.tbfaborigin.Location = new System.Drawing.Point(127, 177);
            this.tbfaborigin.Name = "tbfaborigin";
            this.tbfaborigin.Size = new System.Drawing.Size(137, 22);
            this.tbfaborigin.TabIndex = 13;
            // 
            // tbsupid
            // 
            this.tbsupid.Location = new System.Drawing.Point(400, 32);
            this.tbsupid.Name = "tbsupid";
            this.tbsupid.Size = new System.Drawing.Size(130, 22);
            this.tbsupid.TabIndex = 14;
            // 
            // tbprobatch
            // 
            this.tbprobatch.Location = new System.Drawing.Point(400, 83);
            this.tbprobatch.Name = "tbprobatch";
            this.tbprobatch.Size = new System.Drawing.Size(130, 22);
            this.tbprobatch.TabIndex = 15;
            // 
            // tbfabglo
            // 
            this.tbfabglo.Location = new System.Drawing.Point(400, 132);
            this.tbfabglo.Name = "tbfabglo";
            this.tbfabglo.Size = new System.Drawing.Size(130, 22);
            this.tbfabglo.TabIndex = 16;
            // 
            // tbfabtands
            // 
            this.tbfabtands.Location = new System.Drawing.Point(400, 177);
            this.tbfabtands.Name = "tbfabtands";
            this.tbfabtands.Size = new System.Drawing.Size(130, 22);
            this.tbfabtands.TabIndex = 17;
            // 
            // editregion
            // 
            this.editregion.Controls.Add(this.label10);
            this.editregion.Controls.Add(this.label9);
            this.editregion.Controls.Add(this.label1);
            this.editregion.Controls.Add(this.tbfabtands);
            this.editregion.Controls.Add(this.tbfabid);
            this.editregion.Controls.Add(this.label8);
            this.editregion.Controls.Add(this.tbfabglo);
            this.editregion.Controls.Add(this.label4);
            this.editregion.Controls.Add(this.tbprobatch);
            this.editregion.Controls.Add(this.label7);
            this.editregion.Controls.Add(this.tbfaborigin);
            this.editregion.Controls.Add(this.tbsupid);
            this.editregion.Controls.Add(this.tbfabname);
            this.editregion.Controls.Add(this.label6);
            this.editregion.Controls.Add(this.tbfabcomposition);
            this.editregion.Controls.Add(this.label5);
            this.editregion.Location = new System.Drawing.Point(189, 282);
            this.editregion.Name = "editregion";
            this.editregion.Size = new System.Drawing.Size(587, 238);
            this.editregion.TabIndex = 18;
            this.editregion.TabStop = false;
            this.editregion.Text = "修改区域";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "面料成分";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "面料名称";
            // 
            // btnrowupdate
            // 
            this.btnrowupdate.Location = new System.Drawing.Point(817, 388);
            this.btnrowupdate.Name = "btnrowupdate";
            this.btnrowupdate.Size = new System.Drawing.Size(133, 41);
            this.btnrowupdate.TabIndex = 1;
            this.btnrowupdate.Text = "保存（数据行修改）";
            this.btnrowupdate.UseVisualStyleBackColor = true;
            this.btnrowupdate.Click += new System.EventHandler(this.btnrowupdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(536, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // UpdateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editregion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnrowupdate);
            this.Controls.Add(this.btncellupdate);
            this.Controls.Add(this.dgvupdaterecord);
            this.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UpdateRecord";
            this.Text = "修改信息";
            this.Load += new System.EventHandler(this.UpdateRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdaterecord)).EndInit();
            this.editregion.ResumeLayout(false);
            this.editregion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvupdaterecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric_origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn production_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn glossiness;
        private System.Windows.Forms.DataGridViewTextBoxColumn texture_and_structure;
        private System.Windows.Forms.Button btncellupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbfabid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbfabname;
        private System.Windows.Forms.TextBox tbfabcomposition;
        private System.Windows.Forms.TextBox tbfaborigin;
        private System.Windows.Forms.TextBox tbsupid;
        private System.Windows.Forms.TextBox tbprobatch;
        private System.Windows.Forms.TextBox tbfabglo;
        private System.Windows.Forms.TextBox tbfabtands;
        private System.Windows.Forms.GroupBox editregion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnrowupdate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}