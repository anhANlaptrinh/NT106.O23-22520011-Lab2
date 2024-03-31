using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class LAB1_bai01 : Form
    {
        public LAB1_bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int i = 0, j = 0, check1 = 0, check2 = 0;
            long sum;
            while ( i < textBox1.Text.Length)
            {
                if (textBox1.Text[i] < 48 || textBox1.Text[i] > 57)
                {
                    check1++;
                }
                i++;
            }
            while (j < textBox2.Text.Length)
            {
                if (textBox2.Text[j] < 48 || textBox2.Text[j] > 57)
                {
                    check2++;
                }
                j++;
            }
            if (check1 !=0 || check2 != 0) 
            {
                MessageBox.Show("Vui long nhap so nguyen!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui long nhap so nguyen!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
        }
    }
}
