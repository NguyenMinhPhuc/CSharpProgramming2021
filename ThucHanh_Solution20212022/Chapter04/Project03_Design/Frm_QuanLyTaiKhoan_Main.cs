using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_Design
{
    public partial class Frm_QuanLyTaiKhoan_Main : Form
    {

        public FrmDaskboard frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        public Frm_QuanLyTaiKhoan_Main()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "File(*.xlsx)|*.xlsx|Excel|*.xls";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                txtpath.Text = openFileDialog.FileName;
                AddSheetName2Combobox(txtpath.Text, cboSheet);
            }
        }

        public void AddSheetName2Combobox(string FileName, System.Windows.Forms.ComboBox cmb)
        {
            if (!System.IO.File.Exists(FileName))
            {
                return;
            }

            // Cắt đường dẫn tập tin để kiểm tra xem là xls hay xlsx
            string[] fileParts = FileName.Split('.');

            string connString = "";
            if (FileName.Length > 1 && fileParts[1] == "xls")// sử dụng cho Microsoft Excel 2003
            {
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=Excel 8.0";
            }
            else // sử dụng cho Microsoft Excel 2007
            {
                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=Excel 12.0";
            }
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connString;
            conn.Open();
            try
            {
                DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string[] excelSheetNames = new string[dt.Rows.Count];
                int i = 0;

                foreach (DataRow row in dt.Rows)
                {
                    excelSheetNames[i] = row[2].ToString();
                    i++;
                }

                cmb.Items.Clear();

                for (int s = 0; s < excelSheetNames.Length; s++)
                {
                    if (excelSheetNames[s].Substring(excelSheetNames[s].Length - 1, 1) != "_")
                        cmb.Items.Add(excelSheetNames[s].ToString());
                }
            }
            catch
            {
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        private void btnLayduLieu_Click(object sender, EventArgs e)
        {
            if (cboSheet.Text == "")
            {
                MessageBox.Show("Chọn sheet lấy dữ liệu");
            }
            else
            {
                string filePath = txtpath.Text;

                if (!System.IO.File.Exists(filePath))
                {
                    return;
                }

                // Cắt đường dẫn tập tin để kiểm tra xem là xls hay xlsx
                string[] fileParts = filePath.Split('.');

                string connString = "";
                if (filePath.Length > 1 && fileParts[1] == "xls")// sử dụng cho Microsoft Excel 2003
                {
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0";
                }
                else // sử dụng cho Microsoft Excel 2007
                {
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0";
                }
                // Tạo đối tượng kết nối
                OleDbConnection oledbConn = new OleDbConnection(connString);
                try
                {
                    // Mở kết nối
                    oledbConn.Open();
                    string tensheet = cboSheet.Text;
                    // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + tensheet + "]", oledbConn);

                    // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                    OleDbDataAdapter oleda = new OleDbDataAdapter();

                    oleda.SelectCommand = cmd;

                    // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                    DataSet ds = new DataSet();

                    // Đổ đữ liệu từ tập excel vào DataSet
                    oleda.Fill(ds);

                    // Hiển thị dữ liệu đọc từ tập tin excel lên trên GridView

                    dgvDanhSachNhanVien.DataSource = ds.Tables[0].DefaultView;


                    // gvkhachmoi.colmota.
                    //   this.colghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    int sodong = 0;
                    sodong = ds.Tables[0].Rows.Count;
                    lblErr.Text = "Số lượng : " + sodong;
                    //this.grdanhsachexcel.Text = this.grdanhsachexcel.Text + sodong;
                }
                catch
                {
                }
                finally
                {
                    oledbConn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTab();
        }
    }
}
