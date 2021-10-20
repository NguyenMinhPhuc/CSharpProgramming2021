using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_QuaySo
{
    public partial class Frm_QuaySo : Form
    {
        public Frm_QuaySo()
        {
            InitializeComponent();
        }
        Random random;
        List<int> emp;
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNumber.Text = string.Format("{0:00000}", random.Next(1,99999));
        }

        private void Frm_QuaySo_Load(object sender, EventArgs e)
        {
            txtNumber.Text = string.Format("{0:00000}", 0);
            timer1.Enabled = false;
            timer2.Enabled = false;
            emp = new List<int>()
            {
               81622,82034,48286,96278,32140,81300,35740,82945,66631,40520,17733,13177,85320,21054,88724,60655,2118,12061,41101,99551,62479,47646,43591,37467,41235,70929,82175,21055,11688,13586,84308,64523,37513,49714,94797,54584,23802,29111,99288,89311,90929,49505,51631,40086,46310,31717,98948,66051,
51526,11261,86482,50658,79445,25314,31828,47983,40433,81524,61461,93146,73484,17421,44955,
42096,12143,21563,79721,16663,17930,28804,13289,68477,84685,64243,68530,46023,74039,84113,
22679,74114,54203,45591,13337,51437,19738,55039,18668,30977,32407,26839,71864,74700,92342,37930,
60456,23903,75136,98150,42587,90990,39193,72418,72664,36320,91001,73457,78777,37006,10273,41173,
42158,66147,75161,84925,53073,51025,81633,38964,61606,80450,56773,76807,80511,99209,29090,24343,
99360,85577,46171,36331,45563,68823,33157,57100,51573,42745,81982,73835,70635,34032,58423,27180,
13855,49271,39325,83482,47124,52842,64485,19303,78957,18887,26551,20552,82641,98787,19816,99976,
24768,54684,37369,73118,88068,25850,74049,17085,41872,70979,78931,61876,97997,97873,24425,75939,
96119,71573,81933,29923,59515,78860,87167,44116,34487,61740,11244,68845,29388,91219,80138,63243,
94645,98607,72329,29679,16771,56463,41006,55679,38812,52225,19160,35661,40835,17503,91580,10706,
26889,50985,75270,15341,52369,28175,95734,11797,37292,63192,16095,50165,57994,50513,90218,23229,
42676,99003,65825,50530,64726,79463,74838,86793,89592,65850,27366,25980,46101,17683,13396,71416,
66126,49932,71418,62252,81682,40981,35711,33040,25016,79703,34764,13877,31926,74078,41410,19809,
59888,65017,24475,51414,15440,34561,92944,29579,87283,76327,71991,46908,52231,78942,60173,96079,25282,33807,72343,30515,46256,84527,38724,98972,62048,64870,19953,15327,79367,49821,52231,80158,44625,97113,36232,48250,59216,62028,11484,32928,35350,30493,28368,64609,90273,79622,78319,54442,26154,13763,70686,73483,54210,19390,51291,84603,45625,30495,62790,36438,36882,72449,75322,44822,93886,95362,17155,29826,64335,81793,23134,23160,32023,94415,58774,76844,95939,41917,95111,49277,33381,51706,60022,23463,51838,22373,59645,55681,41445,86757,62738,83194,83536 };
        }
        private void btnQuay_Click(object sender, EventArgs e)
        {
            random = new Random();
            timer1.Enabled = true;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int Number = random.Next(0, 99999);
            
            lbl1.Text = (Number % 10).ToString();
            Number = Number / 10;
            lbl2.Text = (Number % 10).ToString();
            Number = Number / 10;
            lbl3.Text = (Number % 10).ToString();
            Number = Number / 10;
            lbl4.Text = (Number % 10).ToString();
            Number = Number / 10;
            lbl5.Text = (Number % 10).ToString();
        }

        private void btnbegin_Click(object sender, EventArgs e)
        {
            random = new Random();
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int NumberBinding = random.Next(0, emp.Count);
            int Number = emp[NumberBinding];
            label11.Text = (Number % 10).ToString();
            Number = Number / 10;
            label22.Text = (Number % 10).ToString();
            Number = Number / 10;
            label33.Text = (Number % 10).ToString();
            Number = Number / 10;
            label44.Text = (Number % 10).ToString();
            Number = Number / 10;
            label55.Text = (Number % 10).ToString();
        }

        private void btnBegin1_Click(object sender, EventArgs e)
        {
            random = new Random();
            timer3.Enabled = true;
        }

        private void btnEnd1_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            lblDanhSachTrung.Items.Add(string.Format("{0}{1}{2}{3}{4}",label55.Text, label44.Text, label33.Text, label22.Text, label11.Text));

        }
    }
}
