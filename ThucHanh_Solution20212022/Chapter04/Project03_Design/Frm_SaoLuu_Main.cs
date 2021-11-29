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
    public partial class Frm_SaoLuu_Main : Form
    {
        public Frm_SaoLuu_Main()
        {
            InitializeComponent();
        }
        //Khai bao Delegate
        public FrmDaskboard frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        private void Frm_SaoLuu_Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTab();
        }
    }
}
