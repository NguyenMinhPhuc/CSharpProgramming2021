using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QuaySoMayMan
{
   public class EmployeeDao
    {
       public List<Employee> employees;
        public EmployeeDao()
        {
            employees = new List<Employee>();
        }
        public void DocFileDanhSach(string path)
        {
            using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                using (StreamReader sr=new StreamReader(fs))
                {
                    string line = string.Empty;
                    Employee employee;
                    while ((line=sr.ReadLine())!=null)
                    {
                        if(!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            employee = new Employee()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                HoTen = vs[1],
                                PhongBan=vs[2]
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
        }

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
