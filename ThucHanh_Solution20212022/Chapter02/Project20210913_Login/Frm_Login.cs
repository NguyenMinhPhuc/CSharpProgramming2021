using Project20210913_Login.Data;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private UserDao _user;
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            _user = new UserDao();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           //kiem tra 2 txtbox co nhap hay khong
           if(!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    //kiem tra xem txt vua nhap co trung voi username va pass hay khong--> if...else...
                  
                   if( KiemTraDangNhap(txtUserName.Text, txtPassWord.Text))
                    {
                        //Kiem tra bien nho
                        _user.user.Remember = ckbRemember.Checked;
                        Cls_Main._staticUser = _user.user;
                        this.Close();
                    }
                    else
                    {
                        lblErr.Text = "UserName or Password wrong";
                    }
                }
            }
        }

        private bool KiemTraDangNhap(string userName, string passWord)
        {
           if(_user.user.UserName.Equals(userName)&& _user.user.PassWord.Equals(passWord))
            {
                return true;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Dung dong chuong trinh
            Application.Exit();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (_user.user.Remember)
            {
                ckbRemember.Checked = true;

                txtPassWord.Text = _user.user.PassWord;
                btnLogin.Focus();
            }
        }
    }
}
