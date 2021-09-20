using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
    public class User
    {
        // field - Những thuộc tính cần lưu trữ của User 
        private int iD;
        private string userName;
        private string passWord;
        private bool remember;
        private int idUserType;
        //Contructor- hàm tạo cho đối tượng User 
        public User() { }
        public User(int iD, string userName, string passWord, bool remeber)
        {
            this.iD = iD;
            this.userName = userName;
            this.passWord = passWord;
            this.remember = remeber;
        }
        // Properties - Tạo thuộc tính cho User theo snipet: RClick vào
        // field tương ứng --> Chọn Quick Action &... (Ctrl +)--> Encapsulate Field...
        public int ID { get { return iD; } set { iD = value; } }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool Remember { get => remember; set => remember = value; }
        public int IdUserType { get => idUserType; set => idUserType = value; }
        //Phương thức Lấy chuỗi định dạng của đối tượng User 
        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, UserName, PassWord, Remember.ToString(), IdUserType);
        }
    }
}
