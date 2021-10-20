
namespace Project20210913_Login
{
    partial class Frm_ChangedPassword
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
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.txtPasswordNewOne = new System.Windows.Forms.TextBox();
            this.txtPasswordTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangedPassword = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbAdmin.SuspendLayout();
            this.grbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(257, 38);
            this.cboUser.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(363, 37);
            this.cboUser.TabIndex = 0;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User: ";
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.label4);
            this.grbAdmin.Controls.Add(this.btnResetPassword);
            this.grbAdmin.Controls.Add(this.cboUser);
            this.grbAdmin.Location = new System.Drawing.Point(22, 71);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(635, 148);
            this.grbAdmin.TabIndex = 2;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Admin-Reset Password";
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.btnChangedPassword);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.txtPasswordTwo);
            this.grbUser.Controls.Add(this.txtPasswordNewOne);
            this.grbUser.Location = new System.Drawing.Point(22, 225);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(635, 210);
            this.grbUser.TabIndex = 3;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "User-Changed password";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(364, 85);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(256, 54);
            this.btnResetPassword.TabIndex = 1;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtPasswordNewOne
            // 
            this.txtPasswordNewOne.Location = new System.Drawing.Point(267, 52);
            this.txtPasswordNewOne.Name = "txtPasswordNewOne";
            this.txtPasswordNewOne.Size = new System.Drawing.Size(353, 35);
            this.txtPasswordNewOne.TabIndex = 0;
            // 
            // txtPasswordTwo
            // 
            this.txtPasswordTwo.Location = new System.Drawing.Point(267, 99);
            this.txtPasswordTwo.Name = "txtPasswordTwo";
            this.txtPasswordTwo.Size = new System.Drawing.Size(353, 35);
            this.txtPasswordTwo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password New";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password New pre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choise User";
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.Location = new System.Drawing.Point(364, 140);
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.Size = new System.Drawing.Size(256, 54);
            this.btnChangedPassword.TabIndex = 4;
            this.btnChangedPassword.Text = "Changed Password";
            this.btnChangedPassword.UseVisualStyleBackColor = true;
            this.btnChangedPassword.Click += new System.EventHandler(this.btnChangedPassword_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(99, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(534, 29);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "N/A";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-2, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 4);
            this.panel1.TabIndex = 5;
            // 
            // Frm_ChangedPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.grbUser);
            this.Controls.Add(this.grbAdmin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_ChangedPassword";
            this.Text = "Frm_ChangedPassword";
            this.Load += new System.EventHandler(this.Frm_ChangedPassword_Load);
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Button btnChangedPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordTwo;
        private System.Windows.Forms.TextBox txtPasswordNewOne;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel1;
    }
}