
using LibraryClass.Dao;
using LibraryClass.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_QuaySoMayMan
{
    public partial class FrmQuaySoMayMan : Form
    {
        List<Employee> employees;
        IEmployeeDao employeeDao;

        //tạo danh sách Nhân viên nhận giải
        List<NhanVienNhanGiai> nhanVienNhanGiais;
        NhanVienNhanGiaiDao nhanVienNhanGiaiDao;
        public FrmQuaySoMayMan()
        {
            InitializeComponent();
        }

        private void FrmQuaySoMayMan_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>();
            employeeDao = new EmployeeDao(ClsMain.typeDatabase,ClsMain.pathNhanVien);

            nhanVienNhanGiais = new List<NhanVienNhanGiai>();
            nhanVienNhanGiaiDao = new NhanVienNhanGiaiDao();


            LoadComboGiaiThuong();
        }

        private void LoadComboGiaiThuong()
        {
            GiaiThuongDao giaiThuong = new GiaiThuongDao();
            giaiThuong.DocNoiDung(ClsMain.pathGiaiThuong);
           
            cboGiaiThuong.DataSource = giaiThuong.giaiThuongs;

            cboGiaiThuong.DisplayMember = "TenGiai";
            cboGiaiThuong.ValueMember = "ID";
        }

        bool isOpen = true;//Điều khiển button, dừng và quay
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
      
        private void ThemDanhSachGiai(int ID)
        {
            //Lấy danh sách nhân viên sau khi quay được giải theo mã số
            Employee employee = employeeDao.GetNhanNhanTheoID(ID);
            //Tạo một đối tượng nhân viên giải
            NhanVienNhanGiai nhanVienNhanGiai = new NhanVienNhanGiai()
            {
                ID = employee.ID,
                HoTen = employee.HoTen,
                PhongBan = employee.PhongBan,
                Giai = cboGiaiThuong.Text
            };
            //Thêm vào danh sách
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
        private void TachID(string iD)
        {

            lbl1.Text = iD[4].ToString();

            lbl2.Text = iD[3].ToString();

            lbl3.Text = iD[2].ToString();

            lbl4.Text = iD[1].ToString();

            lbl5.Text = iD[0].ToString();

        }

        private void btnLayDanhSachQuay_Click(object sender, EventArgs e)
        {
            //Đọc Danh sách từ file danhsach 1.
            //Đối tượng OpenFileDialog cho phép mở hộp thoại mở file của windows
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file danh sách";
            openFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            //Kiểm tra nếu nhấp vào nút Open trên cửa sổ open.
           if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                //Lấy tên file
                string path = openFileDialog.FileName;
                //goi hàm đọc file
                employeeDao.ReadData(path);
                employees = employeeDao.employees;
                //Gọi hàm hiển thị danh sách lên lưới
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
        int EmployeeID = 0;//Mã số nhân viên sau khi nhấn btnDung sẽ lấy nhân viên này để thêm danh sách nhan vien trúng
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();//đối tượng sinh số ngẫu nhiên.
            int a = random.Next(1, employees.Count);
            EmployeeID = employees[a].ID;
            TachID(EmployeeID);
        }

        private void btnInDanhSachTrung_Click(object sender, EventArgs e)
        {
            if (nhanVienNhanGiais.Count > 0)
            {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                   // saveFileDialog.InitialDirectory = @"d:\";//Hien thi thu muc khoi tao
                    saveFileDialog.RestoreDirectory = true;

                    saveFileDialog.Filter = "Text files (*.xls)|*.xls|All files (*.*)|*.*";//Lọc loại file
                    saveFileDialog.DefaultExt = "xls";//Phần mở rộng mặc định
                    saveFileDialog.AddExtension = true;
                    
                    saveFileDialog.Title = "Lưu file Excel";//Tiêu đề của hộp thoại
                    saveFileDialog.FileName =string.Format("trungthuong_{0}{1:00}{2:00}{3:00}",DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);//trungthuong2021101801
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
                    {
                        nhanVienNhanGiaiDao.nhanVienNhanGiais = nhanVienNhanGiais;
                        //Luu danh sachs nhan vien nhan giai vào file NhanVienNhanGiai.ini
                        nhanVienNhanGiaiDao.GhiNoiDung(ClsMain.pathNhanVienNhanGiai);
                       
                        nhanVienNhanGiaiDao.XuatExcel(saveFileDialog.FileName,dgvDSTrungGiai);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi: ", ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // saveFileDialog.InitialDirectory = @"d:\";//Hien thi thu muc khoi tao
            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.Filter = "Text files (*.xls)|*.xls|All files (*.*)|*.*";//Lọc loại file
            saveFileDialog.DefaultExt = "xls";//Phần mở rộng mặc định
            saveFileDialog.AddExtension = true;

            saveFileDialog.Title = "Lưu file Excel";//Tiêu đề của hộp thoại
            saveFileDialog.FileName = string.Format("trungthuong_{0}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);//trungthuong2021101801
            if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
            {
                nhanVienNhanGiaiDao.XuatExcel(saveFileDialog.FileName, dgvDSQuay);
                MessageBox.Show("Xuất file thành công");
            }
        }
    }
}
