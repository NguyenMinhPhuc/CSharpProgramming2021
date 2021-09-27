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
    public partial class Frm_Users_Main : Form
    {
        public Frm_Users_Main()
        {
            InitializeComponent();
        }
        //Khai báo đối tượng UserDao để thực hiện lấy data
        UserDao userDao;
        //Khai báo danh sách User để giữ danh sách User lấy từ UserDao
        List<User> listUser;

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            userDao = new UserDao();//Khởi tạo đối tượng UserDao

            GetDataToDataGridView();//Phương thức Lấy data và hiển thị lên lưới dataGridView
        }
        /// <summary>
        /// Phương thức lấy data và cho hiển thị lên lưới DataGridView.
        /// </summary>
        private void GetDataToDataGridView()
        {
            //Lay duoc data.
            userDao.GetUsers(Cls_Main.pathfile);
            listUser = userDao.listUser;

            //Sử dụng BindingSource để nắm giữ danh sách
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listUser;
            //Gán bindingSource cho thuộc tính DataSource của DataGridView.
            dgvUserList.DataSource = bindingSource;
            //Đếm số người trên dataGridView.
            lblQuantity.Text = dgvUserList.RowCount.ToString();
        }
        /// <summary>
        /// Sự kiện Click của buttn Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_User_Modified frm_User_Modified = new Frm_User_Modified();
            frm_User_Modified.isAdd = true;
            frm_User_Modified.ShowDialog();
            GetDataToDataGridView();
        }
        /// <summary>
        /// Sự kiện Click của button Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (user != null)//Kiểm tra đã chọn User cần sửa thông tin chưa.
            {
                Frm_User_Modified frm_User_Modified = new Frm_User_Modified();
                frm_User_Modified.isAdd = false;
                frm_User_Modified.user = user;
                frm_User_Modified.ShowDialog();
                user = null;
                GetDataToDataGridView();
            }
            else
            {

            }
        }
        //Khai báo đối tượng User để khi lick lên lưới, sẽ lưu đối tượng trên lưới vào trong đối tượng này.
        User user;
        private void dgvUserList_Click(object sender, EventArgs e)
        {
            if(dgvUserList.RowCount>0)//Kiểm tra dataGridView có dữ liệu hay không
            {
                user = new User()
                {
                    //Lấy data trên dòng hiện tại (CurrentRow) tại ô (Cells) theo tên.
                    ID = Convert.ToInt32(dgvUserList.CurrentRow.Cells["colID"].Value.ToString()),
                    FullName= dgvUserList.CurrentRow.Cells["colFullName"].Value.ToString(),
                    Sex =Convert.ToBoolean( dgvUserList.CurrentRow.Cells["colSex"].Value.ToString()),
                    UserName = dgvUserList.CurrentRow.Cells["colUserName"].Value.ToString(),
                    PassWord = dgvUserList.CurrentRow.Cells["colPassWord"].Value.ToString(),
                    Remember = Convert.ToBoolean(dgvUserList.CurrentRow.Cells["colRemember"].Value.ToString()),
                    IdUserType =Convert.ToInt32( dgvUserList.CurrentRow.Cells["colIDUserType"].Value.ToString())
                };
            }
        }
        /// <summary>
        /// Sự kiến Click của button xoá
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)//Kiểm tra đã chọn User cần xoá trên dataGridView chưa.
            {
                //Thực hiện phương thức Remove để xoá user ra khỏi listUser của UserDao.
                //Chú ý: để phương thức này hoạt động được, phải tiến hành viết nạp chồng (override) lên phương thức Equals trong lớp User. để quy định khi so sánh 2 user sẽ dùng thuộc tính nào.
                userDao.listUser.Remove(user);
                //Ghi lại danh sách lên file listUser.ini.
                userDao.WriteUsers(Cls_Main.pathfile);
                user = null;
                GetDataToDataGridView();//Hiển thị lại danh sách lên DataGridView.
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDataToDataGridView();
        }
    }
}
