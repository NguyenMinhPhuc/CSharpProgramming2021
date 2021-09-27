using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
   public class UserType
    {
        //Kiểu dữ liệu UserType
        private int iDUserType;//ctrl+R+E--> Enter
        private string nameUserType;

        public int IDUserType { get => iDUserType; set => iDUserType = value; }
        public string NameUserType { get => nameUserType; set => nameUserType = value; }
    }
}
