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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        //Tạo đối tượng của lớp UserDao.
        UserDao _userDao;
        //Sự kiện load của form. sự kiện này sẽ được thực hiện khi form main đươcc mở lên.
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng UserDao để tiến hành gọi phương thức lấy danh sách User trong file listUser.ini
            _userDao = new UserDao();
            _userDao.GetUsers(Cls_Main.pathfile);
            //Gán danh sách vừa được đọc từ file vào cho biến  toàn cục _listUser trong Cls_Main.
            //giá trị này dc dùng trong các form của chương trình.
            Cls_Main._listUser = _userDao.listUser;

            //Thực hiện mờ form Login 
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            //Sau khi đăng nhập thành công sẽ hiển thị thông tin người đăng nhập trên lblUserInfor tại StatusStrip
            lblUserInfor.Text = string.Format("Login by {0}-{1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.UserName);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Cls_Main._staticUser = null;
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }

        private void mnuChangedPassword_Click(object sender, EventArgs e)
        {
            //Khai báo đối tượng form Frm_ChangedPassword
            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            //Xác định form cha của form ChangedPassword là Form hiện tại (FrmMain)
            //Để mở form này theo hình thức form cha, form con
            frm_ChangedPassword.MdiParent = this;
            //Xác định vị trí hiện thị ngay giữa màn hình của form ChangedPassword khi hiển thị
            frm_ChangedPassword.StartPosition = FormStartPosition.CenterScreen;
            //Sử dụng phương thức Show() trong trường hợp này, không được dùng ShowDialog
            frm_ChangedPassword.Show();
        }

        private void mnuSaveListUser_Click(object sender, EventArgs e)
        {
            _userDao.WriteUsers(Cls_Main.pathfile);
        }

        private void mnuUserList_Click(object sender, EventArgs e)
        {
            Frm_Users frm_Users = new Frm_Users();
            frm_Users.MdiParent = this;
            frm_Users.StartPosition = FormStartPosition.CenterScreen;
            frm_Users.Show();
        }
    }
}
