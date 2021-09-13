using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project20210913_Login
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            lblUserInfor.Text = string.Format("Login by {0}-{1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.UserName);
           //show form con tren form cha
            Frm_Chidle frm_Chidle = new Frm_Chidle();
            frm_Chidle.MdiParent = this;
            frm_Chidle.Show();
           
        }
    }
}
