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
    public partial class Uc_TextBox : UserControl
    {
        public Uc_TextBox()
        {
            InitializeComponent();
            lblTitle.Text = LabelText;
            btnSubmit.Text = TextButton;

        }
        private string labelText = "lblText";
        private string textButton = "lblButton";
        public string LabelText { get { return labelText; } set { labelText=value; } }
        public string TextButton { get { return textButton; } set { textButton = value; } }

        private void Uc_TextBox_Load(object sender, EventArgs e)
        {
            lblTitle.Text = LabelText;
            btnSubmit.Text = TextButton;
        }
    }
}
