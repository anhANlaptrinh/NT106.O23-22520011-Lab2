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
    public partial class LAB1_bai03 : Form
    {
        public LAB1_bai03()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0;
            for (i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] < 48 || textBox1.Text[i] > 57)
                    count++;
            }
            if (count != 0)
            {
                MessageBox.Show("Vui long nhap lai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Vui long nhap lai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                int num = int.Parse(textBox1.Text);
                if (num < 0 ||  num > 9)
                {
                    MessageBox.Show("Vui long nhap lai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    switch(num)
                    {
                        case 0:
                            {
                                textBox2.Text = "Không";
                                break;
                            }
                        case 1:
                            {
                                textBox2.Text = "Một";
                                break;
                            }
                        case 2:
                            {
                                textBox2.Text = "Hai";
                                break;
                            }
                        case 3:
                            {
                                textBox2.Text = "Ba";
                                break;
                            }
                        case 4:
                            {
                                textBox2.Text = "Bốn";
                                break;
                            }
                        case 5:
                            {
                                textBox2.Text = "Năm";
                                break;
                            }
                        case 6:
                            {
                                textBox2.Text = "Sáu";
                                break;
                            }
                        case 7:
                            {
                                textBox2.Text = "Bảy";
                                break;
                            }
                        case 8:
                            {
                                textBox2.Text = "Tám";
                                break;
                            }
                        case 9:
                            {
                                textBox2.Text = "Chín";
                                break;
                            }
                    }
                }
            }
        }
    }
}
