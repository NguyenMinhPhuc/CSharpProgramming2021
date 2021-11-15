using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_Design
{
    public partial class Frm_Emplyee_Main : Form
    {
        public FrmDaskboard frm;
        public delegate void _deDongTab();
        public _deDongTab DongTab;
        public Frm_Emplyee_Main()
        {
            InitializeComponent();
        }

        private void Frm_Emplyee_Main_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DongTab();
        }
        string err = string.Empty;
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
                //Lấy danh sách sheet trong file Excel vào comboBox.
                AddSheetNameToComboBox(ref err,txtPath.Text, cboSheets);
            }
        }

        private void AddSheetNameToComboBox(ref string err, string path, ComboBox cboSheets)
        {
            if (!File.Exists(path))
            {
                return;
            }
            string[] fileParts = path.Split('.');//d:/danhsach.xls
            string connectString = string.Empty;
            if(path.Length>1 && fileParts[1]=="xls")
            {
                connectString =string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0",path);
            }
            else
            {
                connectString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0", path);
            }
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connectString;
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

                cboSheets.Items.Clear();

                for (int s = 0; s < excelSheetNames.Length; s++)
                {
                    if (excelSheetNames[s].Substring(excelSheetNames[s].Length - 1, 1) != "_")
                        cboSheets.Items.Add(excelSheetNames[s].ToString());
                }
            }
            catch(Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            if(cboSheets.Text.Length<=0)
            {
                MessageBox.Show("Chua chon Sheet");
            }
            else
            {
                string path = txtPath.Text;
                if (!File.Exists(path))
                {
                    return;
                }
                string[] fileParts = path.Split('.');//d:/danhsach.xls
                string connectString = string.Empty;
                if (path.Length > 1 && fileParts[1] == "xls")
                {
                    connectString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0", path);
                }
                else
                {
                    connectString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0", path);
                }
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connectString;
                conn.Open();
                try
                {
                    string tenSheet = cboSheets.Text;
                    OleDbCommand cmd = new OleDbCommand("Select * from [" + tenSheet + "]", conn);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                    //DataSet ds = new DataSet();

                    //da.Fill(ds);
                    //  dgvDanhSach.DataSource = ds.Tables[0].DefaultView;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSach.DataSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                }
            }
        }
    }
}
