using LibraryClass.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass.Dao
{
   public interface IEmployeeDao
    {
         string path { get; set; }
        List<Employee> employees { get; set; }
        //Đọc danh sách từ file danhsach.ini
        void ReadData(string path);
        void GhiNoiDung(string path);

        Employee GetNhanNhanTheoID(int ID);

    }
}
