using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_Design.UserControls
{
    public partial class uc_BaoCao01 : UserControl
    {
        public uc_BaoCao01()
        {
            InitializeComponent();
        }
        private static uc_BaoCao01 _instance;
        public static uc_BaoCao01 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_BaoCao01();
                return _instance;
            }
        }
    }
}
