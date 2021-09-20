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
    public partial class Frm_ChangedPassword : Form
    {
        public Frm_ChangedPassword()
        {
            InitializeComponent();
        }
        //Khai báo một số biến để điều khiển luồng của chương trình.
        //Biến kiểu danh sách List<User> lưu danh sách User hiện tại Danh sách này được lấy từ danh sách listUser trong lớp Cls_Main
        List<User> _listUser;
        //BIến lưu trang thái Load của comboBox, khi đổ data vào comboBox User cboUsers. fales là chứ load xong, true: đã load xong.
        bool statusLoad = false;

        //Biến IdUserType để lưu loại User : 1 là Admin; 2 là User 
        private int IdUserType = 0;
        //Lưu ID của User hiện tại, User đăng nhập vào chương trình
        int idUser = 0;
        //Khai báo đối tượng UserDao để thực hiện thao tác Lưu thay đổi của danh sách listUser vào file listUser.ini
        UserDao userDao;


        /// <summary>
        /// Khi load form Frm_ChangedPassword nếu là Tài khoản Admin sẽ cho hiển thị cả phần Reset Password, 
        /// Còn nếu là loại tại khoản User chỉ cho phép hiển thị phần ChangedPassword (xem trong giao diện)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_ChangedPassword_Load(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng UserDao được khai báo trước đó.
            userDao = new UserDao();
            //lấy loại người dùng từ biến toàn cục trong lớp Cls_Main là Cls_Main._staticUser.
            IdUserType = Cls_Main._staticUser.IdUserType;
            //Lấy ID của người dùng
            idUser = Cls_Main._staticUser.ID;
            //hiển thị id và tên người dung lên lblUserName
            lblUserName.Text =string.Format("{0}-{1}", idUser.ToString() , Cls_Main._staticUser.UserName.ToUpper());
           //kiểm tra loại người dùng để hiển thị đúng kịch bản giao diện đưa ra
            switch (IdUserType)
            {
                case 1://admin
                    grbAdmin.Enabled = true;//thuoc tinhs mat focus/co focus
                                            // grbAdmin.Visible = false;//*/Thuoc tinh an/hien
                    //Lấy danh sách User đổ vào ComboBox cboUser
                    _listUser = Cls_Main._listUser;
                    LoadCombouser();
                    break;
                case 2://User
                    grbAdmin.Enabled = false;
                    break;
                default:
                    grbAdmin.Enabled = false;
                    break;
            }
        }

        private void LoadCombouser()
        {
            //Láy data trong danh sách User (listUser) gán cho thuộc tính datasource của comboBox
            cboUser.DataSource = _listUser;
            //Gán giá trị cho thuộc tính DispalyMember. giá trị của thuộc tính này sẽ được nhìn thấy trên ComboBox.
            cboUser.DisplayMember = "UserName";\
            //Gán giá trị cho thuộc tính ValueMember của comboBox. giá trị này sẽ được lấy ra khi chọn comboBox. qua thuộc tình SelectedValue.
            cboUser.ValueMember = "ID";
            //Thực hiện chuyển index về -1 và hiển thị text trên cboUser.
            cboUser.SelectedIndex = -1;
            cboUser.Text = "--- Select user ---";
            //Gán trạng thái Load Xong comboBox
            statusLoad = true;
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboUser.SelectedIndex>=-1&&statusLoad)
            {
                //idUser = (int)cboUser.SelectedValue;
                //idUser =int.Parse( cboUser.SelectedValue.ToString());
                idUser = Convert.ToInt32(cboUser.SelectedValue);
                //MessageBox.Show(cboUser.SelectedValue.ToString());
                //inboxing -- uninboxing
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            foreach (User item in Cls_Main._listUser)
            {
                if(item.ID==idUser)
                {
                    item.PassWord = item.UserName;
                    userDao.listUser = Cls_Main._listUser;
                    userDao.WriteUsers(Cls_Main.pathfile);

                }
            }
        }

        private void btnChangedPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPasswordNewOne.Text))
            {
                if (!string.IsNullOrEmpty(txtPasswordTwo.Text))
                {
                    if (txtPasswordNewOne.Text.Equals(txtPasswordTwo.Text))
                    {
                        if (ChangedPassword(txtPasswordNewOne.Text))
                        {
                            MessageBox.Show("Changed pass successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Changed password Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Not input Password 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not input Password 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ChangedPassword(string passNew)
        {
            foreach (User item in Cls_Main._listUser)
            {
                if (item.ID == idUser)
                {
                    item.PassWord = passNew;
                    userDao.listUser = Cls_Main._listUser;
                    userDao.WriteUsers(Cls_Main.pathfile);
                    return true;
                }
            }
            return false;
        }
    }
}
