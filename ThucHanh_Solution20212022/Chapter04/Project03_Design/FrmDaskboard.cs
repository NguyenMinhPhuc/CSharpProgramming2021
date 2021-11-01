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
    public partial class FrmDaskboard : Form
    {
        public FrmDaskboard()
        {
            InitializeComponent();
        }
        private void LoadMenu()
        {
            pnl__Menu_HeThong.Height = 300;
            pnl__DanhMuc.Height = 45;
            pnl__Menu_TacVu.Height = 45;
            pnl__Left_Menu.Width = 250;
            timer1.Enabled = true;
            lblTime.Text = string.Format("{0:dd-MM-yyyy hh:mm:ss tt}", DateTime.Now);
        }
        private void FrmDaskboard_Load(object sender, EventArgs e)
        {
            LoadMenu();

        }

        private void btn__HeThong_Click(object sender, EventArgs e)
        {
            //xu ly việc thay đổi chiều cao của các panel menu
            if(pnl__Menu_HeThong.Height==300)
            {
                pnl__Menu_HeThong.Height = 45;
            }
            else
            {
                pnl__Menu_HeThong.Height = 300;
                pnl__DanhMuc.Height = 45;
                pnl__Menu_TacVu.Height = 45;
                pnl__Left_Menu.Width = 250;
            }
        }

        private void btn__Menu_DanhMuc_Click(object sender, EventArgs e)
        {
            if (pnl__DanhMuc.Height == 300)
            {
                pnl__DanhMuc.Height = 45;
            }
            else
            {
                pnl__Menu_HeThong.Height = 45;
                pnl__DanhMuc.Height = 300;
                pnl__Menu_TacVu.Height = 45;
                pnl__Left_Menu.Width = 250;
            }
        }

        private void btn__Menu_TacVu_Click(object sender, EventArgs e)
        {
            if (pnl__Menu_TacVu.Height == 300)
            {
                pnl__Menu_TacVu.Height = 45;
            }
            else
            {
                pnl__Menu_HeThong.Height = 45;
                pnl__DanhMuc.Height = 45;
                pnl__Menu_TacVu.Height = 300;
                pnl__Left_Menu.Width = 250;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void pcb__Menuheader_Click(object sender, EventArgs e)
        {
            if(pnl__Left_Menu.Width== 250)
            {
                pnl__Left_Menu.Width =50;
                pnl__Menu_HeThong.Height = 45;
                pnl__DanhMuc.Height = 45;
                pnl__Menu_TacVu.Height = 45;

            }
            else
            {
                pnl__Left_Menu.Width = 250;
            }

        }

        private void btn__ThoatChuongTrinh_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void FrmDaskboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tắt chương trình hay không\n Chọn OK để tắt; Chọn Cancel để hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:dd-MM-yyyy hh:mm:ss tt}", DateTime.Now);
        }
    }
}
