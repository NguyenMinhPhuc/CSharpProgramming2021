
using System.Drawing;

namespace Project03_Design
{
    partial class Frm_DoiMatKhau_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button2 = new System.Windows.Forms.Button();
            this.waterMarkTextBox1 = new MyLibrary.WaterMarkTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cricleButton1 = new MyLibrary_2021.CricleButton();
            this.textColor3 = new MyLibrary_2021.TextColor();
            this.textNumber6 = new MyLibrary_2021.TextNumber(this.components);
            this.textNumber5 = new MyLibrary_2021.TextNumber(this.components);
            this.textColor2 = new MyLibrary_2021.TextColor();
            this.textColor1 = new MyLibrary_2021.TextColor();
            this.textNumber4 = new MyLibrary_2021.TextNumber(this.components);
            this.textNumber3 = new MyLibrary_2021.TextNumber(this.components);
            this.textNumber2 = new MyLibrary_2021.TextNumber(this.components);
            this.textNumber1 = new MyLibrary_2021.TextNumber(this.components);
            this.cricleButton2 = new MyLibrary_2021.CricleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(184)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doi mau khau";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(184)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Project03_Design.Properties.Resources.close_window_32px;
            this.button1.Location = new System.Drawing.Point(764, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 4);
            this.panel2.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(184)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(123, 228);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox1.TabIndex = 8;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Silver;
            this.waterMarkTextBox1.WaterMarkText = "user Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 57);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cricleButton1
            // 
            this.cricleButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.cricleButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cricleButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cricleButton1.BorderRadius = 10;
            this.cricleButton1.BorderSize = 0;
            this.cricleButton1.FlatAppearance.BorderSize = 0;
            this.cricleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cricleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cricleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cricleButton1.ForeColor = System.Drawing.Color.White;
            this.cricleButton1.Location = new System.Drawing.Point(592, 306);
            this.cricleButton1.Name = "cricleButton1";
            this.cricleButton1.Size = new System.Drawing.Size(150, 40);
            this.cricleButton1.TabIndex = 16;
            this.cricleButton1.Text = "cricleButton1";
            this.cricleButton1.TextColor = System.Drawing.Color.White;
            this.cricleButton1.UseVisualStyleBackColor = false;
            // 
            // textColor3
            // 
            this.textColor3.BackColorFocus = System.Drawing.Color.Aqua;
            this.textColor3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textColor3.Location = new System.Drawing.Point(465, 306);
            this.textColor3.Name = "textColor3";
            this.textColor3.Size = new System.Drawing.Size(100, 36);
            this.textColor3.TabIndex = 14;
            this.textColor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textNumber6
            // 
            this.textNumber6.BackColorFocus = System.Drawing.Color.Aqua;
            this.textNumber6.DoubleValue = 0D;
            this.textNumber6.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textNumber6.IntValue = 0;
            this.textNumber6.Location = new System.Drawing.Point(465, 255);
            this.textNumber6.Name = "textNumber6";
            this.textNumber6.Size = new System.Drawing.Size(100, 36);
            this.textNumber6.TabIndex = 13;
            this.textNumber6.Text = "0";
            this.textNumber6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textNumber5
            // 
            this.textNumber5.BackColorFocus = System.Drawing.Color.Aqua;
            this.textNumber5.DoubleValue = 0D;
            this.textNumber5.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textNumber5.IntValue = 0;
            this.textNumber5.Location = new System.Drawing.Point(355, 177);
            this.textNumber5.Name = "textNumber5";
            this.textNumber5.Size = new System.Drawing.Size(100, 36);
            this.textNumber5.TabIndex = 12;
            this.textNumber5.Text = "0";
            this.textNumber5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textColor2
            // 
            this.textColor2.BackColorFocus = System.Drawing.Color.Aqua;
            this.textColor2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textColor2.Location = new System.Drawing.Point(123, 341);
            this.textColor2.Name = "textColor2";
            this.textColor2.Size = new System.Drawing.Size(100, 36);
            this.textColor2.TabIndex = 11;
            this.textColor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textColor1
            // 
            this.textColor1.BackColorFocus = System.Drawing.Color.Aqua;
            this.textColor1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textColor1.Location = new System.Drawing.Point(558, 140);
            this.textColor1.Name = "textColor1";
            this.textColor1.Size = new System.Drawing.Size(100, 36);
            this.textColor1.TabIndex = 10;
            this.textColor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textNumber4
            // 
            this.textNumber4.BackColorFocus = System.Drawing.Color.Aqua;
            this.textNumber4.DoubleValue = 0D;
            this.textNumber4.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textNumber4.IntValue = 0;
            this.textNumber4.Location = new System.Drawing.Point(226, 177);
            this.textNumber4.Name = "textNumber4";
            this.textNumber4.Size = new System.Drawing.Size(100, 36);
            this.textNumber4.TabIndex = 9;
            this.textNumber4.Text = "0";
            this.textNumber4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textNumber3
            // 
            this.textNumber3.BackColorFocus = System.Drawing.Color.Aqua;
            this.textNumber3.DoubleValue = 50000D;
            this.textNumber3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textNumber3.IntValue = 50000;
            this.textNumber3.Location = new System.Drawing.Point(226, 125);
            this.textNumber3.Name = "textNumber3";
            this.textNumber3.Size = new System.Drawing.Size(100, 36);
            this.textNumber3.TabIndex = 6;
            this.textNumber3.Text = "50,000";
            this.textNumber3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textNumber2
            // 
            this.textNumber2.BackColorFocus = System.Drawing.Color.Aqua;
            this.textNumber2.DoubleValue = 0D;
            this.textNumber2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textNumber2.IntValue = 0;
            this.textNumber2.Location = new System.Drawing.Point(89, 140);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(100, 36);
            this.textNumber2.TabIndex = 5;
            this.textNumber2.Text = "0";
            this.textNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textNumber1
            // 
            this.textNumber1.BackColorFocus = System.Drawing.Color.MediumSpringGreen;
            this.textNumber1.DoubleValue = 0D;
            this.textNumber1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textNumber1.IntValue = 0;
            this.textNumber1.Location = new System.Drawing.Point(72, 72);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(360, 36);
            this.textNumber1.TabIndex = 4;
            this.textNumber1.Text = "0";
            this.textNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cricleButton2
            // 
            this.cricleButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cricleButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cricleButton2.BorderRadius = 10;
            this.cricleButton2.BorderSize = 0;
            this.cricleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cricleButton2.FlatAppearance.BorderSize = 0;
            this.cricleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cricleButton2.ForeColor = System.Drawing.Color.White;
            this.cricleButton2.Location = new System.Drawing.Point(592, 251);
            this.cricleButton2.Name = "cricleButton2";
            this.cricleButton2.Size = new System.Drawing.Size(150, 40);
            this.cricleButton2.TabIndex = 17;
            this.cricleButton2.Text = "cricleButton2";
            this.cricleButton2.TextColor = System.Drawing.Color.White;
            this.cricleButton2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Red;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(487, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 18;
            // 
            // Frm_DoiMatKhau_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cricleButton2);
            this.Controls.Add(this.cricleButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textColor3);
            this.Controls.Add(this.textNumber6);
            this.Controls.Add(this.textNumber5);
            this.Controls.Add(this.textColor2);
            this.Controls.Add(this.textColor1);
            this.Controls.Add(this.textNumber4);
            this.Controls.Add(this.waterMarkTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textNumber3);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DoiMatKhau_Main";
            this.Text = "Frm_DoiMatKhau_Main";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private MyLibrary_2021.TextNumber textNumber1;
        private MyLibrary_2021.TextNumber textNumber2;
        private MyLibrary_2021.TextNumber textNumber3;
        private System.Windows.Forms.Button button2;
        private MyLibrary.WaterMarkTextBox waterMarkTextBox1;
        private MyLibrary_2021.TextNumber textNumber4;
        private MyLibrary_2021.TextColor textColor1;
        private MyLibrary_2021.TextColor textColor2;
        private MyLibrary_2021.TextNumber textNumber5;
        private MyLibrary_2021.TextNumber textNumber6;
        private MyLibrary_2021.TextColor textColor3;
        private System.Windows.Forms.Button button3;
        private MyLibrary_2021.CricleButton cricleButton1;
        private MyLibrary_2021.CricleButton cricleButton2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}