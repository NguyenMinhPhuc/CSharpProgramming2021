using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
   public class UserDao
    {
        //Khai báo  đối tượng List<User>
        public List<User> listUser;
        //Viết hàm tạo để khởi tạo đối tượng listUser.
        public UserDao()
        {
            listUser = new List<User>();
            #region khoá code
            //user = new User();
            //user.ID = 1;
            //user.UserName = "admin";
            //user.PassWord = "admin";
            //user.Remember = true;

            //user = new User(2, "user2", "user2", true);


            //
            //{
            //    new User() { ID = 1,UserName="admin",PassWord="admin",Remember=true ,IdUserType=1},//1 la Admin
            //    new User() { ID = 2,UserName="user",PassWord="user",Remember=false,IdUserType=2},
            //    new User() { ID = 3,UserName="phuc",PassWord="123456789",Remember=true,IdUserType=2 }//2 la user thuong
            //};
            #endregion
        }
        //Phương thức ghi danh sách listUser vào trong file text theo đương dẫn file Path
        public void WriteUsers(string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            //Sử dụng cấu trúc using để khai báo đối tượng FileStream
            using(FileStream fs=new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                //Sử dung class StreamWriter để làm việc với file text (ini, txt)
                using(StreamWriter sw=new StreamWriter(fs))
                {
                    foreach (User item in listUser)
                    {
                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", item.ID,item.FullName,item.Sex.ToString(), item.UserName, item.PassWord, item.Remember.ToString(), item.IdUserType));
                    }
                }
            }

        }
        //Phuong thức đọc nội dung file text theo dường dẫn path và chứa trong listUser.
        
        public void GetUsers(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                //Dùng Lớp StreamReader để đọc file theo đường dẫn được khai báo trong FileStream (phía trên).
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    User user;
                    listUser.Clear();
                    //Readline() phương thức đọc từng dòng trong file.
                    //Vòng Lặp while cho phép thực hiện việc này liên tục khi đọc đươc giá trì null
                    //Sau khi đọc xong 1 dòng, data sẽ được lưu vào trong biến line.
                    while ((line=sr.ReadLine())!=null)
                    {
                        //1,admin,admin,True,1
                        //Kiểm tra line có giá trị hay không (null hoặc enmpty)
                        if (!string.IsNullOrEmpty(line))
                        {
                            //Dùng hàm Split('char') để tách chuỗi line thành mảng theo ký tự (char) ngăn cách
                            string[] userArray = line.Split(',');
                            //Tạo một đối tượng User và thêm giá trị từ mảng đọc được vào 
                            user = new User();
                            user.ID = Convert.ToInt32(userArray[0]);
                            user.FullName = userArray[1];
                            user.Sex = Convert.ToBoolean(userArray[2]);
                            user.UserName = userArray[3];
                            user.PassWord = userArray[4];
                            user.Remember = Convert.ToBoolean(userArray[5].ToString());
                            user.IdUserType = Convert.ToInt32(userArray[6]);
                            //Them User vào trong danh sách listUser.
                            listUser.Add(user);
                        }

                    }
                }
            }

        }

        //Viet phuong thuc lay MaxID cuar ListUser
        public int GetMaxID()
        {
            int maxID = 0;
            foreach (User item in listUser)
            {
                if (item.ID > maxID)
                    maxID = item.ID;
            }
            return maxID+1;
        }
    }
}
