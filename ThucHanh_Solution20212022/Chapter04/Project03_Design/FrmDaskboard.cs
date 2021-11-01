using DevComponents.DotNetBar;
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

        #region Thiet ke layOut
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
            if (pnl__Menu_HeThong.Height == 300)
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

        

        private void pcb__Menuheader_Click(object sender, EventArgs e)
        {
            if (pnl__Left_Menu.Width == 250)
            {
                pnl__Left_Menu.Width = 50;
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
            if (MessageBox.Show("Bạn có muốn tắt chương trình hay không\n Chọn OK để tắt; Chọn Cancel để hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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
        #endregion

        #region Dieu khiem mo form tren tabcontrol DOTBar2
        bool trangThaiMoTa = false;
        string tieuDeTab;

        public FrmDaskboard frm;
        public delegate void _deDongTab();
        /// <summary>
        /// Phuong thuc kiem 1 tab da duoc mo hay chua
        /// </summary>
        /// <param name="name">ten của form</param>
        /// <returns>true: đã mở; false: chưa mở</returns>
        private bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < tc_Main.Tabs.Count; i++)
            {
                if (tc_Main.Tabs[i].Text == name)
                {
                    tc_Main.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void tc_Main_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            TabItem t = tc_Main.SelectedTab;
            tc_Main.Tabs.Remove(t);
        }

        private void DongTab()
        {
            foreach (TabItem item in tc_Main.Tabs)
            {
                if(item.IsSelected)
                {
                    tc_Main.Tabs.Remove(item);
                    return;
                }
            }
        }


        #endregion

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Chuc nang sao luu";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_SaoLuu_Main";
                Frm_SaoLuu_Main frm = new Frm_SaoLuu_Main()
                {
                    DongTab=new Frm_SaoLuu_Main._deDongTab(DongTab),
                    frm=this,
                    TopLevel=false,
                    Dock=DockStyle.Fill

                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.trangThaiMoTa = true;
            this.tieuDeTab = "Doi Mat Khau";

            if (!CheckOpenTabs(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = "Frm_DoiMatKhau_Main";
                Frm_DoiMatKhau_Main frm = new Frm_DoiMatKhau_Main()
                {
                    DongTab = new Frm_DoiMatKhau_Main._deDongTab(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill

                };
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
        }
    }
}
