using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QuaySoMayMan.Common;

namespace Project_QuaySoMayMan
{
   public class NhanVienNhanGiaiDao
    {
        public List<NhanVienNhanGiai> nhanVienNhanGiais;
        public string path { get; set; }
        

        public NhanVienNhanGiaiDao()
        {
            nhanVienNhanGiais = new List<NhanVienNhanGiai>();
           
            path = ClsMain.pathNhanVienNhanGiai;
        }

        public void DocNoiDung(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    NhanVienNhanGiai nhanVienNhanGiai;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            nhanVienNhanGiai = new NhanVienNhanGiai()
                            {
                                ID = Convert.ToInt32(vs[0]), HoTen=vs[1],PhongBan=vs[2],Giai=vs[3]
                            };
                            nhanVienNhanGiais.Add(nhanVienNhanGiai);
                        }
                    }
                }
            }
        }
        public void GhiNoiDung(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //Sử dụng cấu trúc using để khai báo đối tượng FileStream
                    foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
                    {
                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                        sw.WriteLine(string.Format("{0},{1},{2},{3}", item.ID, item.HoTen, item.PhongBan, item.Giai));
                    }
                }
            }
        }

        internal void XuatExcel(string path)
        {
            List<string> list = new List<string>();
            //code Xuất Excel 
            foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
            {
                string line = string.Format("{0},{1},{2},{3}", item.ID, item.HoTen, item.PhongBan, item.Giai);
                list.Add(line);
            }
            string[] title=new string[]{
                "ma so","Họ và tên","Phòng ban", "Giải","Thanh tien"
            };
            XuatFileExcel.XuatExcel(path, list, "Danh sách nhân viên trúng giải", "Đã ký", title);
           // XuatFileExcel.XuatExcel(path, list, "Danh sách nhân viên trúng giải", "Đã ký", "id","name","phong ban");
        }

        internal void XuatExcel(string path,DataGridView dgv)
        {
            XuatFileExcel.XuatExcel(path, dgv,1, "Tahoma",16,12);
           
        }
    }
}
