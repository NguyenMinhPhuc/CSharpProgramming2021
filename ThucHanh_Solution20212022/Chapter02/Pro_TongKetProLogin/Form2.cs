using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_TongKetProLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void mnuForm_01_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();//MDIParent
            
            //form1.ShowDialog();
            //MessageBox.Show("www");
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            form1.MdiParent = this;
            form1.Show();//MDIParent
        }
    }
}
