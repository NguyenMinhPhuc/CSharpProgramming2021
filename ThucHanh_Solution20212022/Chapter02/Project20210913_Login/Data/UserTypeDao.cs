using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
   public class UserTypeDao
    {
        List<UserType> userTypes;
        public UserTypeDao()
        {
            userTypes = new List<UserType>() { 
                new UserType(){IDUserType=1,NameUserType="Admin"},
                new UserType(){IDUserType=2,NameUserType="User"}
            };
        }
        //co the viet phuong thuc doc ghi file lay data tu file ini.
    }
}
