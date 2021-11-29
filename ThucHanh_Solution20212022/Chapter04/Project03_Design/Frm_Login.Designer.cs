
namespace Project03_Design
{
    partial class Frm_Login
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Khoa CNTT",
            "So luong SV",
            "Dia chi"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Khoa KT");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtUsername = new MyLibrary_2021.TextColor();
            this.txtPassword = new MyLibrary_2021.TextColor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new MyLibrary_2021.CricleButton();
            this.btnExit = new MyLibrary_2021.CricleButton();
            this.toolTipUserName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBarClick = new System.Windows.Forms.ProgressBar();
            this.btnClick = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnThem = new MyLibrary_2021.CricleButton();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.tvuser = new System.Windows.Forms.TreeView();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taoButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColorFocus = System.Drawing.Color.Aqua;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtUsername.Location = new System.Drawing.Point(823, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(349, 36);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipUserName.SetToolTip(this.txtUsername, "Nhập Username đăng nhập");
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColorFocus = System.Drawing.Color.Aqua;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtPassword.Location = new System.Drawing.Point(823, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(349, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipPassword.SetToolTip(this.txtPassword, "Nhập mật khẩu đăng nhập");
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(860, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.toolTipButton.SetToolTip(this.btnLogin, "Nhấn để đăng nhập");
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1022, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.toolTipButton.SetToolTip(this.btnExit, "Nhấn vào Exit để thoát");
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // toolTipButton
            // 
            this.toolTipButton.AutomaticDelay = 100;
            this.toolTipButton.BackColor = System.Drawing.Color.Red;
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ShowAlways = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Thông báo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBarClick
            // 
            this.progressBarClick.Location = new System.Drawing.Point(823, 300);
            this.progressBarClick.Name = "progressBarClick";
            this.progressBarClick.Size = new System.Drawing.Size(349, 23);
            this.progressBarClick.Step = 9;
            this.progressBarClick.TabIndex = 6;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(913, 338);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(177, 23);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Green;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.imageList16;
            this.listView1.Location = new System.Drawing.Point(47, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 210);
            this.listView1.SmallImageList = this.imageList16;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(968, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(268, 53);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Them";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16.Images.SetKeyName(0, "logout_rounded_left_32px.png");
            this.imageList16.Images.SetKeyName(1, "access_denied_32px.png");
            this.imageList16.Images.SetKeyName(2, "bulleted_list_32px.png");
            this.imageList16.Images.SetKeyName(3, "close_window_32px.png");
            this.imageList16.Images.SetKeyName(4, "data_backup_32px.png");
            this.imageList16.Images.SetKeyName(5, "file_32px.png");
            this.imageList16.Images.SetKeyName(6, "file_32px_color.png");
            this.imageList16.Images.SetKeyName(7, "key_32px.png");
            this.imageList16.Images.SetKeyName(8, "logout_rounded_down_32px.png");
            this.imageList16.Images.SetKeyName(9, "menu_32px.png");
            this.imageList16.Images.SetKeyName(10, "power_off_button_32px.png");
            this.imageList16.Images.SetKeyName(11, "query_32px.png");
            this.imageList16.Images.SetKeyName(12, "system_administrator_male_32px.png");
            this.imageList16.Images.SetKeyName(13, "user_groups_32px.png");
            // 
            // tvuser
            // 
            this.tvuser.Location = new System.Drawing.Point(436, 99);
            this.tvuser.Name = "tvuser";
            this.tvuser.Size = new System.Drawing.Size(173, 210);
            this.tvuser.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(436, 73);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "add subnode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.Location = new System.Drawing.Point(386, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoButtonToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 70);
            // 
            // taoButtonToolStripMenuItem
            // 
            this.taoButtonToolStripMenuItem.Name = "taoButtonToolStripMenuItem";
            this.taoButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taoButtonToolStripMenuItem.Text = "Min";
            this.taoButtonToolStripMenuItem.Click += new System.EventHandler(this.taoButtonToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maxToolStripMenuItem.Text = "Max";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.tvuser);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.progressBarClick);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLibrary_2021.TextColor txtUsername;
        private MyLibrary_2021.TextColor txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyLibrary_2021.CricleButton btnLogin;
        private MyLibrary_2021.CricleButton btnExit;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.ToolTip toolTipUserName;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ProgressBar progressBarClick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MyLibrary_2021.CricleButton btnThem;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TreeView tvuser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taoButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
    }
}