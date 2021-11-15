//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project_QuaySoMayMan
//{
//   public class EmployeeDao
//    {
//        public string path { get; set; }
//       public List<Employee> employees;
//        public EmployeeDao()
//        {
//            path = ClsMain.pathNhanVien;
//            employees = new List<Employee>();
//        }
//        //Đọc danh sách từ file danhsach.ini
//        public void DocNoiDung(string path)
//        {
//            using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
//            {
//                using (StreamReader sr=new StreamReader(fs))
//                {
//                    string line = string.Empty;
//                    Employee employee;
//                    while ((line=sr.ReadLine())!=null)
//                    {
//                        if(!string.IsNullOrEmpty(line))
//                        {
//                            string[] vs = line.Split(',');
//                            employee = new Employee()
//                            {
//                                ID = Convert.ToInt32(vs[0]),
//                                HoTen = vs[1],
//                                PhongBan=vs[2]
//                            };
//                            employees.Add(employee);
//                        }
//                    }
//                }
//            }
//        }
//        public void GhiNoiDung(string path)
//        {
//            if (File.Exists(path))
//            {
//                File.Delete(path);
//            }
//            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
//            {
//                using (StreamWriter sw = new StreamWriter(fs))
//                {
//                    //Sử dụng cấu trúc using để khai báo đối tượng FileStream
//                    foreach (Employee item in employees)
//                    {
//                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
//                        sw.WriteLine(string.Format("{0},{1},{2}", item.ID, item.HoTen, item.PhongBan));
//                    }
//                }
//            }
//        }
//        /// <summary>
//        /// Phương Thức Nhân viên theo mã số
//        /// </summary>
//        /// <param name="ID">Mã Nhân viên </param>
//        /// <returns>Nhân viên được chọn</returns>
//        public Employee GetNhanNhanTheoID(int ID)
//        {
//            foreach (Employee item in employees)
//            {
//                if (item.ID == ID)
//                    return item;
//            }
//            return null;
//        }
//    }
//}
