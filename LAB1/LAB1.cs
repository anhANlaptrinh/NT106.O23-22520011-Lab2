using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//b
namespace LAB1
{
    public partial class LAB1 : Form
    {
        public LAB1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LAB1_bai01 frombai1 = new LAB1_bai01();
            frombai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAB1_bai02 frombai2 = new LAB1_bai02();
            frombai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LAB1_bai03 frombai3 = new LAB1_bai03();
            frombai3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LAB1_bai04 frombai4 = new LAB1_bai04();
            frombai4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LAB1_bai05 frombai5 = new LAB1_bai05();
            frombai5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LAB1_bai06 frombai6 = new LAB1_bai06();
            frombai6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LAB1_bai07 frombai7 = new LAB1_bai07();
            frombai7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LAB1_bai08 frombai8 = new LAB1_bai08();
            frombai8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LAB1_bai03_1 frombai3_1 = new LAB1_bai03_1();
            frombai3_1.Show();
        }
    }
}
