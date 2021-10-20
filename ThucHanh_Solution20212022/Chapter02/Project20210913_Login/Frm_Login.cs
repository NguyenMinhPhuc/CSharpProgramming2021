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
        //Khai báo biến lưu danh sách User, Biến này sẽ nhận giá trị từ biến toàn cụ trong lớp Cls_Main khi Load chuong trình
        //Biến này dùng để lưu trữ danh sách User và thực hiện thao tác kiểm tra userName và Password trên danh sách này
        private List<User> listUser;
        //Sự kiện Load của Form Login
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //Khởi tạo giá trị cho đối tượng listUser
            listUser = Cls_Main._listUser;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           //Trước khi kiểm tra username và password có trùng khớp với user trong listUser hay không phải tiến hành kiểm tra giao diện trước
           //Kiểm tra đã nhập text trên 2 textbox txtUserName và txtPassword hay chưa.
           if(!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    //kiem tra xem txt vua nhap co trung voi username va pass hay khong--> if...else...
                    //Viết phương thức kiểm tra đăng nhập với 2 tham số truyền vào là text trên 2 textbox txtUserName và txtPassword
                   if( KiemTraDangNhap(txtUserName.Text, txtPassWord.Text))
                    {
                        //Khi kiểm tra trùng khớp username và password thì sẽ cho tắt form Login và form Main sẽ đươc sử dụng bình thường
                        this.Close();
                    }
                    else
                    {
                        //Nếu khiểm tra không trùng khớp xuất thông báo trên lblErr trên StatusStrip của form Login
                        lblErr.Text = "UserName or Password wrong";
                    }
                }
            }
        }
        /// <summary>
        /// Phương thức Kiểm tra đăng nhập với 2 tham số
        /// Trong phương thức để kiểm tra, sử dụng 1 vòng lặp đê lập trên từng user của danh sách User.
        /// Trong phương thức này sử dụng Foreach để duyệt list.
        /// </summary>
        /// <param name="userName">Text trên txtUserName</param>
        /// <param name="passWord">Text trên txtPassword</param>
        /// <returns>Trả về True nếu trùng khớp, False nếu không trùng khớp UserName và Password</returns>
        private bool KiemTraDangNhap(string userName, string passWord)
        {
            foreach (User item in listUser)
            {
                //Kiểm tra nếu trủng cả Username vả Password thì sẽ return True đồng thời lưu lại thông tin User đăng nhập vào trong biễn tĩnh _StaticUser trong lớp Cls_Main. Ngược lại trả về False
                if (item.UserName.Equals(userName) && item.PassWord.Equals(passWord))
                {
                    item.Remember = ckbRemember.Checked;
                    Cls_Main._staticUser = item;
                    return true;
                }
                
            }
          return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Đê thoát khỏi chương trình các form đang mở sẽ đóng lại hết (kết thức chương trình 
            //Thực hiện việc này sử dụng phương thức Exit() trong Lớp Application.
            Application.Exit();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            foreach (User item in listUser)
            {
                if (item.UserName==txtUserName.Text && item.Remember)
                {
                    ckbRemember.Checked = true;

                    txtPassWord.Text = item.PassWord;
                    btnLogin.Focus();
                }
            }
        }
    }
}
