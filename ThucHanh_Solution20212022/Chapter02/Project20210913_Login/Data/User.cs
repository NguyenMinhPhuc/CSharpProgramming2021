using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20210913_Login.Data
{
    public class User
    {
        // field
        private int iD;
        private string userName;
        private string passWord;
        private bool remember;
        //Contructor
        public User() { }
        public User(int iD, string userName, string passWord, bool remeber)
        {
            this.iD = iD;
            this.userName = userName;
            this.passWord = passWord;
            this.remember = remeber;
        }
        // Properties
        public int ID { get { return iD; } set { iD = value; } }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool Remember { get => remember; set => remember = value; }
    }
}
