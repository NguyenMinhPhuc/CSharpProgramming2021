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
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }

        private void FrmTabControl_Load(object sender, EventArgs e)
        {

        }

        #region Tabpage01
        #endregion

        #region Tabpage01
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==0)
            {
                tabPage1.BackColor = Color.Cyan;
            }
            else
            {
                tabPage2.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tabPage3.BackColor = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lblpath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
