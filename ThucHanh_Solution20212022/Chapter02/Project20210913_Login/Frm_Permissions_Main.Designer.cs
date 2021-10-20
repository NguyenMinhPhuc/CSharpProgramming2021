
namespace Project20210913_Login
{
    partial class Frm_Permissions_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Permissions_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvPermission = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDisplay = new System.Windows.Forms.CheckBox();
            this.ckbAdd = new System.Windows.Forms.CheckBox();
            this.ckbUpdate = new System.Windows.Forms.CheckBox();
            this.ckbDelete = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisplay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboUserType
            // 
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Location = new System.Drawing.Point(124, 28);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(351, 32);
            this.cboUserType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserType:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(885, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.Text = "Refresh";
            // 
            // dgvPermission
            // 
            this.dgvPermission.AllowUserToAddRows = false;
            this.dgvPermission.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFunctionName,
            this.colDisplay,
            this.colAdd,
            this.colUpdate,
            this.colDelete});
            this.dgvPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermission.Location = new System.Drawing.Point(0, 106);
            this.dgvPermission.Name = "dgvPermission";
            this.dgvPermission.ReadOnly = true;
            this.dgvPermission.RowHeadersVisible = false;
            this.dgvPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermission.Size = new System.Drawing.Size(885, 391);
            this.dgvPermission.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDelete);
            this.groupBox1.Controls.Add(this.ckbUpdate);
            this.groupBox1.Controls.Add(this.ckbAdd);
            this.groupBox1.Controls.Add(this.ckbDisplay);
            this.groupBox1.Controls.Add(this.cboUserType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // ckbDisplay
            // 
            this.ckbDisplay.AutoSize = true;
            this.ckbDisplay.Location = new System.Drawing.Point(481, 32);
            this.ckbDisplay.Name = "ckbDisplay";
            this.ckbDisplay.Size = new System.Drawing.Size(89, 28);
            this.ckbDisplay.TabIndex = 2;
            this.ckbDisplay.Text = "Display";
            this.ckbDisplay.UseVisualStyleBackColor = true;
            // 
            // ckbAdd
            // 
            this.ckbAdd.AutoSize = true;
            this.ckbAdd.Location = new System.Drawing.Point(586, 31);
            this.ckbAdd.Name = "ckbAdd";
            this.ckbAdd.Size = new System.Drawing.Size(64, 28);
            this.ckbAdd.TabIndex = 3;
            this.ckbAdd.Text = "Add";
            this.ckbAdd.UseVisualStyleBackColor = true;
            // 
            // ckbUpdate
            // 
            this.ckbUpdate.AutoSize = true;
            this.ckbUpdate.Location = new System.Drawing.Point(681, 31);
            this.ckbUpdate.Name = "ckbUpdate";
            this.ckbUpdate.Size = new System.Drawing.Size(89, 28);
            this.ckbUpdate.TabIndex = 4;
            this.ckbUpdate.Text = "Update";
            this.ckbUpdate.UseVisualStyleBackColor = true;
            // 
            // ckbDelete
            // 
            this.ckbDelete.AutoSize = true;
            this.ckbDelete.Location = new System.Drawing.Point(790, 32);
            this.ckbDelete.Name = "ckbDelete";
            this.ckbDelete.Size = new System.Drawing.Size(83, 28);
            this.ckbDelete.TabIndex = 5;
            this.ckbDelete.Text = "Delete";
            this.ckbDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 29);
            this.btnSave.Text = "Save";
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colFunctionName
            // 
            this.colFunctionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFunctionName.HeaderText = "Function";
            this.colFunctionName.Name = "colFunctionName";
            this.colFunctionName.ReadOnly = true;
            // 
            // colDisplay
            // 
            this.colDisplay.HeaderText = "Display";
            this.colDisplay.Name = "colDisplay";
            this.colDisplay.ReadOnly = true;
            // 
            // colAdd
            // 
            this.colAdd.HeaderText = "Add";
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            // 
            // colUpdate
            // 
            this.colUpdate.HeaderText = "Update";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // Frm_Permissions_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 519);
            this.Controls.Add(this.dgvPermission);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_Permissions_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Permissions_Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.DataGridView dgvPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunctionName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDisplay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbDelete;
        private System.Windows.Forms.CheckBox ckbUpdate;
        private System.Windows.Forms.CheckBox ckbAdd;
        private System.Windows.Forms.CheckBox ckbDisplay;
    }
}