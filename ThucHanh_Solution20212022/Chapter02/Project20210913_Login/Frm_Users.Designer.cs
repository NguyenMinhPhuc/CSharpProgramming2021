
namespace Project20210913_Login
{
    partial class Frm_Users
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
            this.lsbDanhSach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbDanhSach
            // 
            this.lsbDanhSach.FormattingEnabled = true;
            this.lsbDanhSach.Location = new System.Drawing.Point(408, 134);
            this.lsbDanhSach.Name = "lsbDanhSach";
            this.lsbDanhSach.Size = new System.Drawing.Size(563, 459);
            this.lsbDanhSach.TabIndex = 0;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 605);
            this.Controls.Add(this.lsbDanhSach);
            this.Name = "Frm_Users";
            this.Text = "Frm_Users";
            this.Load += new System.EventHandler(this.Frm_Users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDanhSach;
    }
}