using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QuaySoMayMan
{
   public class GiaiThuongDao
    {
        public string path { get; set; }
        public List<GiaiThuong> giaiThuongs;
        public GiaiThuongDao()
        {
            path = ClsMain.pathGiaiThuong;
            giaiThuongs = new List<GiaiThuong>();
        }
        public void DocNoiDung(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    GiaiThuong giaiThuong;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            giaiThuong = new GiaiThuong()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                TenGiai= vs[1],
                               
                            };
                            giaiThuongs.Add(giaiThuong);
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
                    foreach (GiaiThuong item in giaiThuongs)
                    {
                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                        sw.WriteLine(string.Format("{0},{1}", item.ID, item.TenGiai));
                    }
                }
            }
        }

    }
}
