using Project03_Design.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_Design
{
    public partial class Frm_Use_UserControl : Form
    {

        //Khai bao Delegate
        public FrmDaskboard frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        public Frm_Use_UserControl()
        {
            InitializeComponent();
            //uc_txtBox1.lblTitle.Text = "User name:";
            //uc_txtBox1.btnSubmit.Text = "Submit";
            //uc_txtBox1.lblTitle.ForeColor = Color.Black;

        }

        private void Frm_Use_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uc_Table uc_TextBox = new Uc_Table();
            //uc_TextBox.Location = new Point(21,300);
            uc_TextBox.LblTextTitle = "Bàn 02";
            uc_TextBox.LblThanh = "Thanh";
            flowLayoutPanel1.Controls.Add(uc_TextBox);
        }
    }
}
