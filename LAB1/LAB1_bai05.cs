using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class LAB1_bai05 : Form
    {
        public LAB1_bai05()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int i = 0, j = 0, check1 = 0, check2 = 0;
            while (i < textBox1.Text.Length)
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
            if (check1 != 0 || check2 != 0)
            {
                MessageBox.Show("Vui long nhap so nguyen!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui long nhap lai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Vui long chon yeu cau!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox1.Text == "Bảng Cửu Chương")
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                if (num2 < num1)
                {
                    MessageBox.Show("B-A < 0,Vui long nhap lai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                }
                else
                {
                    int X  = num2 - num1;
                    string multiplicationTable = "";
                    for (int h  = 1; h <= 10; h++)
                    {
                        multiplicationTable += $"{X} x {h} = {X * h}{Environment.NewLine}";
                    }
                    textBox3.Text = multiplicationTable;
                }
            }
            if (comboBox1.Text == "Tính Toán Giá Trị")
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                if (num1 < num2)
                {
                    MessageBox.Show("A-B < 0,Vui long nhap lai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                }
                else
                {
                    int Y = num1 - num2;
                    long giaithua = 1, tong = 0;
                    for (int k = 1 ; k <= Y ; k ++)
                    {
                        giaithua *= k;
                    }
                    for (int l = 1; l <= num2; l++)
                    {
                        tong = tong + (long)Math.Pow(num1, l);
                    }
                    textBox3.Text = "(A-B)!= " + giaithua.ToString() + Environment.NewLine + "A^1 + A^2 + ... + A^B = " + tong.ToString();

                }
            }
        }
    }
}
