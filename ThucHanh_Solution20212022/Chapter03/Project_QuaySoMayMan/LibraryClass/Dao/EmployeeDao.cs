using LibraryClass.DatabaseType;
using LibraryClass.EF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass.Dao
{
   public class EmployeeDao:IEmployeeDao
    {
        public string path { get; set; }
        public List<Employee> employees { get ; set ; }
        Database database { get ; set ; }

       // public List<Employee> employees;
       // Database database;
        public EmployeeDao(TypeDatabase typeDatabase, string path)
        {

            database = new Database(typeDatabase);
            employees = new List<Employee>();
        }
        //Đọc danh sách từ file danhsach.ini
        public void ReadData(string path)
        {
            Employee employee;
            List<string> listString = database.DatabaseFactory.Database.ReadFile(path);
            foreach (string item in listString)
            {
                if(!string.IsNullOrEmpty(item))
                {
                    string[] vs = item.Split(',');
                    employee = new Employee()
                    {
                        ID = Convert.ToInt32(vs[0]),
                        HoTen = vs[1],
                        PhongBan = vs[2]
                    };
                    employees.Add(employee);
                }
            }
        }
        public void GhiNoiDung(string path)
        {
            
            List<string> listString = new List<string>();
            //Sử dụng cấu trúc using để khai báo đối tượng FileStream
            foreach (Employee item in employees)
            {
                string itemString = string.Format("{0},{1},{2}", item.ID, item.HoTen, item.PhongBan);
                listString.Add(itemString);
            }
            database.DatabaseFactory.Database.WriteToFile(path, listString);
        }
           
        
        /// <summary>
        /// Phương Thức Nhân viên theo mã số
        /// </summary>
        /// <param name="ID">Mã Nhân viên </param>
        /// <returns>Nhân viên được chọn</returns>
        public Employee GetNhanNhanTheoID(int ID)
        {
            foreach (Employee item in employees)
            {
                if (item.ID == ID)
                    return item;
            }
            return null;
        }
    }
}
