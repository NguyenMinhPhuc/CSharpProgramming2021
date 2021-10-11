using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_TongKetProLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool statusLoadCom = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Nguyen Minh Phuc";
            textBox2.Text = string.Format("{0:###,###0}", 123456789);
            MessageBox.Show(textBox2.Text);
            int a = Convert.ToInt32(textBox2.Text.Replace(",", ""));
            this.Text = a.ToString();

            // data cho comboBox;
            //datatable, list<T>
            List<School> schools = new List<School>()
            {
                new School(){Id=1, Name="Dai hoc Lac Hong"},
                new School(){Id=2, Name="Dai hoc Bach Khoa"},
                 new School(){Id=3, Name="Dai hoc Cong nghe thong tin"},
                new School(){Id=4, Name="Dai hoc KHTN"}
            };
            comboBox2.DataSource = schools;

            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "---Chon Truong---";
            statusLoadCom = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 4)
                MessageBox.Show("da nhap 4 ky tu");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Cyan;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (checkBox1.Checked)
                richTextBox1.Text += checkBox1.Text;
            if (checkBox2.Checked)
                richTextBox1.Text += checkBox2.Text;
            if (checkBox3.Checked)
                richTextBox1.Text += checkBox3.Text;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                richTextBox1.Text += checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                richTextBox1.Text += checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                richTextBox1.Text += checkBox3.Text;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("index: {0}- Text: {1}",comboBox1.SelectedIndex,comboBox1.Text));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex>-1&&statusLoadCom)
            {
                MessageBox.Show(string.Format("index: {0}- DisPlayMember: {1}- valuemember: {2}", comboBox2.SelectedIndex, comboBox2.Text,comboBox2.SelectedValue));
            }
        }
    }
}
