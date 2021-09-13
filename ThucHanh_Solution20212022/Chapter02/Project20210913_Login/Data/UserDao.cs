using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
   public class UserDao
    {
       public User user;
        public UserDao()
        {
            //user = new User();
            //user.ID = 1;
            //user.UserName = "admin";
            //user.PassWord = "admin";
            //user.Remember = true;

            //user = new User(2, "user2", "user2", true);

            user = new User() { ID = 1,UserName="admin",PassWord="admin",Remember=true };
        }
    }
}
