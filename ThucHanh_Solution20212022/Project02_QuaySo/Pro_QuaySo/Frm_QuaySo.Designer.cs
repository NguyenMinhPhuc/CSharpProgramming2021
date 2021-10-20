
namespace Pro_QuaySo
{
    partial class Frm_QuaySo
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
            this.components = new System.ComponentModel.Container();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnQuay = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnbegin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnEnd1 = new System.Windows.Forms.Button();
            this.btnBegin1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblDanhSachTrung = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(85, 47);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(356, 143);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "00000";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnQuay
            // 
            this.btnQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuay.Location = new System.Drawing.Point(447, 69);
            this.btnQuay.Name = "btnQuay";
            this.btnQuay.Size = new System.Drawing.Size(124, 44);
            this.btnQuay.TabIndex = 1;
            this.btnQuay.Text = "Quay";
            this.btnQuay.UseVisualStyleBackColor = true;
            this.btnQuay.Click += new System.EventHandler(this.btnQuay_Click);
            // 
            // btnDung
            // 
            this.btnDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDung.Location = new System.Drawing.Point(447, 120);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(124, 41);
            this.btnDung.TabIndex = 2;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Fuchsia;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(51, 256);
            this.lbl5.Margin = new System.Windows.Forms.Padding(3);
            this.lbl5.Name = "lbl5";
            this.lbl5.Padding = new System.Windows.Forms.Padding(3);
            this.lbl5.Size = new System.Drawing.Size(150, 150);
            this.lbl5.TabIndex = 3;
            this.lbl5.Text = "0";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Lime;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(201, 256);
            this.lbl4.Margin = new System.Windows.Forms.Padding(3);
            this.lbl4.Name = "lbl4";
            this.lbl4.Padding = new System.Windows.Forms.Padding(3);
            this.lbl4.Size = new System.Drawing.Size(150, 150);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "0";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Yellow;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(501, 256);
            this.lbl2.Margin = new System.Windows.Forms.Padding(3);
            this.lbl2.Name = "lbl2";
            this.lbl2.Padding = new System.Windows.Forms.Padding(3);
            this.lbl2.Size = new System.Drawing.Size(150, 150);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "0";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Aqua;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(351, 256);
            this.lbl3.Margin = new System.Windows.Forms.Padding(3);
            this.lbl3.Name = "lbl3";
            this.lbl3.Padding = new System.Windows.Forms.Padding(3);
            this.lbl3.Size = new System.Drawing.Size(150, 150);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "0";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Red;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(651, 256);
            this.lbl1.Margin = new System.Windows.Forms.Padding(3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(3);
            this.lbl1.Size = new System.Drawing.Size(150, 150);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "0";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnbegin
            // 
            this.btnbegin.Location = new System.Drawing.Point(818, 285);
            this.btnbegin.Name = "btnbegin";
            this.btnbegin.Size = new System.Drawing.Size(75, 23);
            this.btnbegin.TabIndex = 7;
            this.btnbegin.Text = "Begin";
            this.btnbegin.UseVisualStyleBackColor = true;
            this.btnbegin.Click += new System.EventHandler(this.btnbegin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(818, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "End";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnEnd1
            // 
            this.btnEnd1.Location = new System.Drawing.Point(818, 516);
            this.btnEnd1.Name = "btnEnd1";
            this.btnEnd1.Size = new System.Drawing.Size(75, 23);
            this.btnEnd1.TabIndex = 15;
            this.btnEnd1.Text = "End";
            this.btnEnd1.UseVisualStyleBackColor = true;
            this.btnEnd1.Click += new System.EventHandler(this.btnEnd1_Click);
            // 
            // btnBegin1
            // 
            this.btnBegin1.Location = new System.Drawing.Point(818, 487);
            this.btnBegin1.Name = "btnBegin1";
            this.btnBegin1.Size = new System.Drawing.Size(75, 23);
            this.btnBegin1.TabIndex = 14;
            this.btnBegin1.Text = "Begin";
            this.btnBegin1.UseVisualStyleBackColor = true;
            this.btnBegin1.Click += new System.EventHandler(this.btnBegin1_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Lime;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(651, 458);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(150, 150);
            this.label11.TabIndex = 13;
            this.label11.Text = "0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Red;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(501, 458);
            this.label22.Margin = new System.Windows.Forms.Padding(3);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(3);
            this.label22.Size = new System.Drawing.Size(150, 150);
            this.label22.TabIndex = 11;
            this.label22.Text = "0";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(351, 458);
            this.label33.Margin = new System.Windows.Forms.Padding(3);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(3);
            this.label33.Size = new System.Drawing.Size(150, 150);
            this.label33.TabIndex = 12;
            this.label33.Text = "0";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Yellow;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(201, 458);
            this.label44.Margin = new System.Windows.Forms.Padding(3);
            this.label44.Name = "label44";
            this.label44.Padding = new System.Windows.Forms.Padding(3);
            this.label44.Size = new System.Drawing.Size(150, 150);
            this.label44.TabIndex = 9;
            this.label44.Text = "0";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.Blue;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(51, 458);
            this.label55.Margin = new System.Windows.Forms.Padding(3);
            this.label55.Name = "label55";
            this.label55.Padding = new System.Windows.Forms.Padding(3);
            this.label55.Size = new System.Drawing.Size(150, 150);
            this.label55.TabIndex = 10;
            this.label55.Text = "0";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblDanhSachTrung
            // 
            this.lblDanhSachTrung.FormattingEnabled = true;
            this.lblDanhSachTrung.Location = new System.Drawing.Point(934, 458);
            this.lblDanhSachTrung.Name = "lblDanhSachTrung";
            this.lblDanhSachTrung.Size = new System.Drawing.Size(202, 251);
            this.lblDanhSachTrung.TabIndex = 16;
            // 
            // Frm_QuaySo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 744);
            this.Controls.Add(this.lblDanhSachTrung);
            this.Controls.Add(this.btnEnd1);
            this.Controls.Add(this.btnBegin1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbegin);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnQuay);
            this.Controls.Add(this.txtNumber);
            this.Name = "Frm_QuaySo";
            this.Text = "Frm_QuaySo";
            this.Load += new System.EventHandler(this.Frm_QuaySo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnQuay;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnbegin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnEnd1;
        private System.Windows.Forms.Button btnBegin1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ListBox lblDanhSachTrung;
    }
}