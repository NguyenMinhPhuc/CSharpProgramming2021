using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
    public class User:IComparable
    {
        // field - Những thuộc tính cần lưu trữ của User 
        private int iD;
        private string fullName;
        private bool sex;//true: nam; false: nu
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
        public string FullName { get => fullName; set => fullName = value; }
        public bool Sex { get => sex; set => sex = value; }

        //Phương thức Lấy chuỗi định dạng của đối tượng User 
        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, UserName, PassWord, Remember.ToString(), IdUserType);
        }
        /// <summary>
        /// Phương thức nạp chồng giúp so sánh 2 đối tượng user nếu bằng nhau ==> true.
        /// Có thể quy định user bằng nhau theo thuộc tính nào là do người dụng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj is User)
            {
                return this.ID.Equals(((User)obj).ID);
            }
            return false;
        }
        /// <summary>
        /// Phương thức được thực thi từ interface Icomparable 
        /// nếu muốn sắp xếp danh sách.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
             return this.ID.CompareTo(((User)obj).ID);
        }
    }
}
