using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class MyTextBox : TextBox
    {
        public MyTextBox()
        {
            InitializeComponent();
        }
        //thêm dấu phần ngàn cho textbox
        public new String Text
        {
            get
            {
                if (base.Text.Length == 0) return "0";
                return base.Text.Trim();
            }
            set
            {
                try
                {
                    if (value.Length <= 21)
                    {
                        base.Text = cls_ActionString.themdauphanngan(value, this);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị lớn hơn miền giá trị cho phép của kiểu Int64", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        /// <summary>
        /// Thuộc tính lấy giá trị phần ngàn
        /// </summary>
        public double Dvalue
        {
            get
            {
                return Convert.ToDouble(this.Text.Replace(",", ""));
            }
            set
            {
                this.Text = value.ToString();
            }
        }
        public long Lvalue
        {
            get
            {
                return Convert.ToInt64(this.Text.Replace(",", ""));
            }
            set
            {
                this.Text = value.ToString();
            }
        }
        /// <summary>
        /// Nạp chống lên sự kiện OnkeyPress của textbox
        /// Chỉ cho phép nhập số
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
        /// <summary>
        /// cho phép con trỏ nằm cuối text box
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (base.Text.Length != 0)
            {
                int p = this.SelectionStart;
                int l = base.Text.Length;
                this.Text = base.Text;
                this.SelectionStart = this.Text.Length <= p ? Math.Abs(this.Text.Length) : Math.Abs(this.Text.Length + p - l);
            }
            base.OnKeyUp(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            //this.Text= XuLyChuoi.themdauphanngan(base.Text, this);
            base.OnTextChanged(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            if (base.Text.Length == 0) base.Text = "0";
            base.OnLeave(e);
        }

        public MyTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
        }
    }
}
