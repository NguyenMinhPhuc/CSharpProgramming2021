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
        UserDao userDao;

        List<User> listUser;

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            userDao = new UserDao();

            GetDataToDataGridView();
        }

        private void GetDataToDataGridView()
        {
            //Lay duoc data.
            userDao.GetUsers(Cls_Main.pathfile);
            listUser = userDao.listUser;

            //gan danh sach User vao dataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listUser;
            dgvUserList.DataSource = bindingSource;

            lblQuantity.Text = dgvUserList.RowCount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_User_Modified frm_User_Modified = new Frm_User_Modified();
            frm_User_Modified.isAdd = true;
            frm_User_Modified.ShowDialog();
            GetDataToDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (user != null)
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
        User user;
        private void dgvUserList_Click(object sender, EventArgs e)
        {
            if(dgvUserList.RowCount>0)
            {
                user = new User()
                {
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                userDao.listUser.Remove(user);
                userDao.WriteUsers(Cls_Main.pathfile);
                user = null;
                GetDataToDataGridView();
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
