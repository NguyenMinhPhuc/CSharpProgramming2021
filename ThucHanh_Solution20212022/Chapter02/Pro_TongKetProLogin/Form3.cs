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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<School> schools = new List<School>()
            {
                new School(){Id=1, Name="Dai hoc Lac Hong"},
                new School(){Id=2, Name="Dai hoc Bach Khoa"},
                 new School(){Id=3, Name="Dai hoc Cong nghe thong tin"},
                new School(){Id=4, Name="Dai hoc KHTN"}
            };
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = schools;
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["colID"].Value.ToString());
                string Name = dataGridView1.CurrentRow.Cells["colName"].Value.ToString();

                MessageBox.Show(string.Format("{0}-{1}",ID.ToString(),Name),"Title",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
