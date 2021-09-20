using Project20210913_Login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project20210913_Login
{
   public class Cls_Main
    {
        //Biến lưu User sau khi đăng nhập thành công
        public static User _staticUser=new User();
    //Đối đượng danh sách User danh sách này được khởi tạo khi mở chương trình. giá trị được đọc từ file text.
        public static List<User> _listUser = new UserDao().listUser;
        //Biến lưu đường dẫn file listUser.ini trong thư mục cài đặt của project
        public static string pathfile = string.Format(@"{0}\listUser.ini", Application.StartupPath);
    }
}
