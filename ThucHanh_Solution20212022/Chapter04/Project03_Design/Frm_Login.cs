using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_Design
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Chua nhap password");
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Chua nhap user name");
                txtUsername.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarClick.Value < 100)
            {
                progressBarClick.PerformStep();
                btnClick.Text = string.Format("Click {0:00.00}%", progressBarClick.Value/Convert.ToDouble(progressBarClick.Maximum));
            }
            else
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "SmallIcon":
                    listView1.View = listView1.View = System.Windows.Forms.View.SmallIcon;
                    break;
                case "LargeIcon":
                    listView1.View = System.Windows.Forms.View.LargeIcon;
                    break;
                case "Tile":
                    listView1.View = System.Windows.Forms.View.Tile;
                    break;
                case "List":
                    listView1.View = System.Windows.Forms.View.List;
                    break;
                case "Details":
                    listView1.View = System.Windows.Forms.View.Details;
                    break;
                default:
                    listView1.View = listView1.View = System.Windows.Forms.View.SmallIcon;
                    break;
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(System.Windows.Forms.View.SmallIcon);
            comboBox1.Items.Add(System.Windows.Forms.View.LargeIcon);
            comboBox1.Items.Add(System.Windows.Forms.View.Tile);
            comboBox1.Items.Add(System.Windows.Forms.View.List);
            comboBox1.Items.Add(System.Windows.Forms.View.Details);

            CreateHeaderListView();

        }
        private void CreateHeaderListView()
        {
            ColumnHeader colTenKhoa = new ColumnHeader(0);
            colTenKhoa.Text = "Tên khoa";
            colTenKhoa.Width = 200;
            ColumnHeader colSoLuong = new ColumnHeader(1);
            colSoLuong.Text = "Số Lượng";
            colSoLuong.Width = 100;
            ColumnHeader colDiaChi = new ColumnHeader(2);
            colDiaChi.Text = "Địa chỉ";
            colDiaChi.Width = 500;
            colDiaChi.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

            this.listView1.Columns.Add(colTenKhoa);
            this.listView1.Columns.Add(colSoLuong);
            this.listView1.Columns.Add(colDiaChi);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem;
            ListViewItem.ListViewSubItem listViewSubItemSL;
            ListViewItem.ListViewSubItem listViewSubItemDC;
            for (int i = 0; i < 10; i++)
            {
                 listViewItem = new ListViewItem(string.Format("Khoa Quan tri {0}",i+1),i+1);

                listViewSubItemSL = new ListViewItem.ListViewSubItem(listViewItem, (300+i).ToString());
                listViewSubItemDC = new ListViewItem.ListViewSubItem(listViewItem, "BuuLong");

                listViewItem.SubItems.Add(listViewSubItemSL);
                listViewItem.SubItems.Add(listViewSubItemDC);

                listView1.Items.Add(listViewItem);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tvuser.Nodes.Add(txtUser.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tvuser.SelectedNode.Nodes.Add(txtUser.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                tvuser.Nodes.Add(string.Format("Item {0}",i));
                for (int j = 0; j < 5; j++)
                {
                    tvuser.Nodes[i].Nodes.Add(string.Format("subItem {0}",j));
                    for (int k = 0; k < 7; k++)
                    {
                        tvuser.Nodes[i].Nodes[j].Nodes.Add(string.Format("sub__subItem {0}", k));
                    }
                }
            }
            tvuser.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0:ddMMyyyy}\n {1}\n{2}\n{3}\n{4},\n{5},\n{6},\n{7}",
                dateTimePicker1.Value,
                dateTimePicker1.Value.ToLongDateString(),
                  dateTimePicker1.Value.ToShortTimeString(),
                    dateTimePicker1.Value.ToLongTimeString(),
                      dateTimePicker1.Value.ToShortTimeString(),
                        dateTimePicker1.Value.Year,
                          dateTimePicker1.Value.Month,
                            dateTimePicker1.Value.Day),
                            dateTimePicker1.Value.AddDays(6).ToString());
          int day=  DateTime.Now.Subtract(dateTimePicker1.Value).Days;

        }

        private void taoButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
