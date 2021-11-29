using MyLibrary_2021;
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
    public partial class Frm_BaoCao : Form
    {
        public Frm_BaoCao()
        {
            InitializeComponent();
        }
        public FrmDaskboard frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
       
        private void btnBaoCao01_Click(object sender, EventArgs e)
        {
            //Random randonGen = new Random();
            //Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            //randonGen.Next(255));

            uc_BaoCao01 uc_BaoCao01 = new uc_BaoCao01();
            if (!pnl_Container.Panel2.Controls.Contains(uc_BaoCao01.Instance))
            {
                pnl_Container.Panel2.Controls.Add(uc_BaoCao01.Instance);
                uc_BaoCao01.Instance.Dock = DockStyle.Fill;
                uc_BaoCao01.Instance.BringToFront();
            }
            else
                uc_BaoCao01.Instance.BringToFront();

        }

        private void Frm_BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void cricleButton1_Click(object sender, EventArgs e)
        {
            Random randonGen = new Random();
            Color randomColor;// = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            //randonGen.Next(255));

            //khai báo control
            CricleButton cricleButton = null;
            int k = 0;
            //khoi tạo cotrl trong vong lăp
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
           randonGen.Next(255));
                    cricleButton = new CricleButton();
                    cricleButton.Name = string.Format("btn_{0}", k++);
                    cricleButton.Text = string.Format(" button {0}", k++);
                    cricleButton.Size = new Size(150, 150);
                    cricleButton.Location = new Point(j * (cricleButton.Width+8), i * (cricleButton.Height+8));
                   // cricleButton.Margin = new Padding(64);
                    cricleButton.BackColor = randomColor;
                    //Add vào control chứa
                    pnl_Container.Panel2.Controls.Add(cricleButton);
                    //tao Event
                    cricleButton.Click += CricleButton_Click;
                    cricleButton.Leave += CricleButton_Leave;
                    cricleButton.Enter += CricleButton_Enter;
                }
            }
           
           
        }

        private void CricleButton_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void CricleButton_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void CricleButton_Click(object sender, EventArgs e)
        {
            Button button=null;
            if (sender is Button)
                button = (Button)sender;
            MessageBox.Show(button.Text);
        }

        private void uc_TextBox1_Load(object sender, EventArgs e)
        {

        }

        private void navigationBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
