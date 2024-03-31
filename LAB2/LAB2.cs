using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class LAB2 : Form
    {
        public LAB2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LAB2_bai01 frombai1 = new LAB2_bai01();
            frombai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAB2_bai02 frombai2 = new LAB2_bai02();
            frombai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LAB2_bai03 frombai3 = new LAB2_bai03();
            frombai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LAB2_bai04 frombai4 = new LAB2_bai04();
            frombai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LAB2_bai05 frombai5 = new LAB2_bai05();
            frombai5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LAB2_bai06 frombai6 = new LAB2_bai06();
            frombai6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LAB2_bai07 frombai7 = new LAB2_bai07();
            frombai7.Show();
        }
    }
}
