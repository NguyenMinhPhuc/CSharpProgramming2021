using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuaySoMayMan
{
    public partial class FrmQuaySoMayMan : Form
    {
        List<Employee> employees;
        EmployeeDao employeeDao;
        public FrmQuaySoMayMan()
        {
            InitializeComponent();
        }

        private void FrmQuaySoMayMan_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>();
            employeeDao = new EmployeeDao();
            nhanVienNhanGiais = new List<NhanVienNhanGiai>();
            LoadComboGiaiThuong();
        }

        private void LoadComboGiaiThuong()
        {
            GiaiThuongDao giaiThuong = new GiaiThuongDao();
            giaiThuong.DocFileDanhSachGiaiThuong(ClsMain.pathGiaiThuong);
           
            cboGiaiThuong.DataSource = giaiThuong.giaiThuongs;

            cboGiaiThuong.DisplayMember = "TenGiai";
            cboGiaiThuong.ValueMember = "ID";
        }

        bool isOpen = true;
        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (employees.Count > 0)
            {
                if (isOpen)
                {
                    timer1.Enabled = true;
                    btnQuay.Text = "Dừng";
                    isOpen = false;

                }
                else
                {
                    timer1.Enabled = false;
                    btnQuay.Text = "Quay";
                    isOpen = true;
                    ThemDanhSachGiai(EmployeeID);
                }
            }
            else
            {
                MessageBox.Show("Chua chon danh sach");
            }
        }
        List<NhanVienNhanGiai> nhanVienNhanGiais;
        private void ThemDanhSachGiai(int ID)
        {
            Employee employee = employeeDao.GetNhanNhanTheoID(ID);
            NhanVienNhanGiai nhanVienNhanGiai = new NhanVienNhanGiai()
            {
                ID = employee.ID,
                HoTen = employee.HoTen,
                PhongBan = employee.PhongBan,
                Giai = cboGiaiThuong.Text
            };
            nhanVienNhanGiais.Add(nhanVienNhanGiai);
            HienThiDanhsachNhanGiai();
        }

        private void HienThiDanhsachNhanGiai()
        {
            int i = 1;
            nhanVienNhanGiais.Sort();//tang dần
            nhanVienNhanGiais.Reverse();//giam dần
            foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
            {
                item.STT = i++;
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanVienNhanGiais;
            dgvDSTrungGiai.DataSource = bindingSource;
        }

        private void TachID(int iD)
        {
            int number = iD;//1234
            if (number > 0) { 
                lbl1.Text = (number % 10).ToString();
             number = number / 10;
            }
            if (number > 0)
            {
                lbl2.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl3.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl4.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl5.Text = (number % 10).ToString();
                number = number / 10;
            }

        }

        private void btnLayDanhSachQuay_Click(object sender, EventArgs e)
        {
            //Đọc Danh sách từ file danhsach 1.
            OpenFileDialog openFileDialog = new OpenFileDialog();
           // openFileDialog.Filter = "Text files(*.ini) | *.ini | All files(*.*) | *.* ";
            openFileDialog.Title = "Chọn file danh sách";
            openFileDialog.InitialDirectory = Application.StartupPath;
           if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                //goi hamf ddocj file
                employeeDao.DocFileDanhSach(path);
                employees = employeeDao.employees;

                HienThiDanhSachNhanVien();
            }
        }

        private void HienThiDanhSachNhanVien()
        {
            int i = 1;
            foreach (Employee item in employees)
            {
                item.STT = i++;
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = employees;
            dgvDSQuay.DataSource = bindingSource;
        }
        int EmployeeID = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(1, employees.Count);
            EmployeeID = employees[a].ID;
            TachID(EmployeeID);
        }
    }
}
