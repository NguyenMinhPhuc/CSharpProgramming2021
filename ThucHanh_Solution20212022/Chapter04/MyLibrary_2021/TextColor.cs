using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary_2021
{
   public partial class TextColor:TextBox
    {
        public TextColor()
        {
            this.TextAlign = HorizontalAlignment.Right;
            this.Font = new Font("Tahoma", 18F);
        }
        Color backColorFocus = Color.Aqua;
        public Color BackColorFocus
        {
            get
            {
                return backColorFocus;
            }
            set
            {
                backColorFocus = value;
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = BackColorFocus;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLeave(e);
        }
    }
}
