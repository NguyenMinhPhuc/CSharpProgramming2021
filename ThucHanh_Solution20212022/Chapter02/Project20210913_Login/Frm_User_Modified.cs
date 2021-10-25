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
    public partial class Frm_User_Modified : Form
    {
        public Frm_User_Modified()
        {
            InitializeComponent();
        }
        //Thuộc tính để xác định mở form Frm_User_Modified theo cách Add hay Update.
        public bool isAdd = false;//True là ADD. False: Update.
        //Đối tượng UserDao để lấy data
        UserDao userDao;

        //Kiểm User để nhận data từ form Frm_User_Main.
        public User user;
        //Biến lưu lỗi. biến này dùng truyền tham chiếu trong phương thức UpdataUser.
        string err = string.Empty;
        private void Frm_User_Modified_Load(object sender, EventArgs e)
        {
            userDao = new UserDao();//Khởi tạo đối tượng UserDao
            userDao.GetUsers(Cls_Main.pathfile); //Đọc danh sách từ file
            //Lấy Data vào trong ComboBox UserType.
            LoadDataToComUserType();
            if (isAdd)
            {
                //Mã User phải thực hiện tăng tự động 
                txtID.Text = CreateMaxID();
                //Khoá control không cho tập trung con tro
                txtID.Enabled = false;
            }
            else
            {
                //Phương thức gán giá trị user vào Control của Form
                SetDataToControl(user);
            }
        }
        /// <summary>
        /// Phương thức gán User vào các control
        /// </summary>
        /// <param name="user">User này là user được truyền qua từ Form Frm_User_Main</param>
        private void SetDataToControl(User user)
        {
            txtID.Text = user.ID.ToString();
            txtFullName.Text = user.FullName;
            txtUserName.Text = user.UserName;
            txtPassWord.Text = user.PassWord;
            rdoMale.Checked = user.Sex;
            ckbRemember.Checked = user.Remember;
            cboUserType.SelectedValue = user.IdUserType;
        }
        /// <summary>
        /// Phương thức lấy dữ liệu vào trong ComboBox.
        /// </summary>
        private void LoadDataToComUserType()
        {
            //Tạo dữ liệu danh sách UserType.
            List<UserType> userTypes = new List<UserType>()
            {
                new UserType(){IDUserType=1,NameUserType="Admin"},
                 new UserType(){IDUserType=2,NameUserType="User"},
            };

            //gan vao datasource cua comboBox
            cboUserType.DataSource = userTypes;
            //Thiet lap thuoc tinh
            cboUserType.DisplayMember = "NameUserType";
            cboUserType.ValueMember = "IDUserType";
        }
        /// <summary>
        /// Phương thức Tạo ID lớn nhất
        /// </summary>
        /// <returns></returns>
        private string CreateMaxID()
        {
            string maxID=string.Empty;
            maxID = userDao.GetMaxID().ToString();
            return maxID;
        }
      /// <summary>
      /// Sự kiện Click của Button
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFullName.Text))//Kiểm tra phải nhập fullname
            {
                if (!string.IsNullOrEmpty(txtUserName.Text))//Kiểm tra phải nhập UserName 
                {
                    if (!string.IsNullOrEmpty(txtPassWord.Text))//Kiểm tra phải nhập Password
                    {
                        if (cboUserType.SelectedIndex>-1)//Kiểm tra phải chọn UserType
                        {
                            //Khởi tạo User Và lấy dữ liệu từ Control,
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                FullName = txtFullName.Text,
                                Sex = rdoMale.Checked,
                                UserName=txtUserName.Text,
                                PassWord=txtPassWord.Text,
                                Remember=ckbRemember.Checked,
                                IdUserType=Convert.ToInt32(cboUserType.SelectedValue.ToString())
                            };
                            //gọi phương thức UpdateUser.
                           if(UpdateUser(ref err,user))
                            {
                                MessageBox.Show("Add User SuccessFull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();//Đóng form
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not Select userType", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Select Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Not Select UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not Select FullName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Phương thức UpdateUser thực hiện 2 việc Thêm và Sửa thông tin của User.
        /// </summary>
        /// <param name="err">Lưu lỗi</param>
        /// <param name="user">Đối tượng User chứa giá trị User cần thêm hoặc sửa</param>
        /// <returns></returns>
        private bool UpdateUser(ref string err,User user)
        {
            try
            {
                if (isAdd)
                {
                    userDao.listUser.Add(user);//Thêm user vào trong List<User> Của UserDao
                    userDao.WriteUsers(Cls_Main.pathfile);//Ghi listUser vào trong file listUser.ini
                    return true;//Trả vể true khi thực hiện thành công.
                }
                else
                {
                    foreach (User item in userDao.listUser)//Lập trên danh sách User, để tìm User cần sửa
                    {
                        if(item.ID==user.ID)//Kiểm tra User cấn sửa
                        {
                            //Sửa thông tin user trên listUser.
                            item.FullName = user.FullName;
                            item.UserName = user.UserName;
                            item.PassWord = user.PassWord;
                            item.Sex = user.Sex;
                            item.Remember = user.Remember;
                            item.IdUserType = user.IdUserType;
                        }
                    }
                    //Ghi nội dung trên danh sách ListUser trong UserDao vào file listUser.ini
                    userDao.WriteUsers(Cls_Main.pathfile);
                    return true;
                }  
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }
    }
}
