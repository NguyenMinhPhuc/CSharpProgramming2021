using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_Design.UserControls
{
    public partial class Uc_Table : UserControl
    {
        public Uc_Table()
        {
            InitializeComponent();
        }
        private string lblTextTitle = string.Empty;
        private PictureBox pictureBox;
        private string lblThanh = string.Empty;

        public string LblTextTitle { get => lblTextTitle; set => lblTextTitle = value; }
        public string LblThanh { get => lblThanh; set => lblThanh = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }

        private void Uc_Table_Load(object sender, EventArgs e)
        {
            lblTitle.Text = lblTextTitle;
            button1.Text = LblThanh;
        }
    }
}
