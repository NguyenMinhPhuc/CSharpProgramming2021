using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project20210913_Login
{
    public partial class Frm_Users : Form
    {
        public Frm_Users()
        {
            InitializeComponent();
        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            foreach (var item in Cls_Main._listUser)
            {
                lsbDanhSach.Items.Add(item.GetString());
               
                Cls_Main._listUser.Remove(item);
            }
           
        }
    }
}
