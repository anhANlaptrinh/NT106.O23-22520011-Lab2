using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class LAB1_bai02 : Form
    {
        public LAB1_bai02()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, minn, maxx;
            int i = 1, j = 1, k = 1, check1 = 0, check2 = 0, check3 = 0, checkdau1 = 0, checkdau2 = 0, checkdau3 = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui long nhap lai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                if (textBox1.Text[0] < 45 || textBox1.Text[0] > 57 || textBox1.Text[0] > 45 && textBox1.Text[0] < 48)
                    check1++;
                if (textBox2.Text[0] < 45 || textBox2.Text[0] > 57 || textBox2.Text[0] > 45 && textBox2.Text[0] < 48)
                    check2++;
                if (textBox3.Text[0] < 45 || textBox3.Text[0] > 57 || textBox3.Text[0] > 45 && textBox3.Text[0] < 48)
                    check3++;
                while (i < textBox1.Text.Length)
                {
                    if (textBox1.Text[i] < 46 || textBox1.Text[i] > 57 || textBox1.Text[i] > 46 && textBox1.Text[i] < 48)
                    {
                        check1++;
                    }
                    if (textBox1.Text[i] == 46) checkdau1++;
                    i++;
                }
                while (j < textBox2.Text.Length)
                {
                    if (textBox2.Text[j] < 46 || textBox2.Text[j] > 57 || textBox2.Text[j] > 46 && textBox2.Text[j] < 48)
                    {
                        check2++;
                    }
                    if (textBox2.Text[j] == 46) checkdau2++;
                    j++;
                }
                while (k < textBox3.Text.Length)
                {
                    if (textBox3.Text[k] < 46 || textBox3.Text[k] > 57 || textBox3.Text[k] > 46 && textBox3.Text[k] < 48)
                    {
                        check3++;
                    }
                    if (textBox3.Text[k] == 46) checkdau3++;
                    k++;
                }
                if (check1 != 0 || check2 != 0 || check3 != 0 || checkdau1 > 1 || checkdau2 > 1 || checkdau3 > 1)
                {
                    MessageBox.Show("Vui long nhap lai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    num1 = float.Parse(textBox1.Text);
                    num2 = float.Parse(textBox2.Text);
                    num3 = float.Parse(textBox3.Text);
                    maxx = num1;
                    if (num2 > maxx)
                    {
                        maxx = num2;
                    }
                    if (num3 > maxx)
                    {
                        maxx = num3;
                    }
                    minn = num1;
                    if (num2 < minn)
                    {
                        minn = num2;
                    }
                    if (num3 < minn)
                    {
                        minn = num3;
                    }
                    textBox4.Text = maxx.ToString();
                    textBox5.Text = minn.ToString();
                }
            }
        }
    }
}
