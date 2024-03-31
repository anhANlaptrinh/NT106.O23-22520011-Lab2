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
    public partial class LAB1_bai03_1 : Form
    {
        public LAB1_bai03_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long number;
            if (long.TryParse(textBox1.Text, out number))
            {
                if (number < 0 || number > 999999999999)
                {
                    MessageBox.Show("Số không hợp lệ. Vui lòng nhập số có 12 chữ số không âm.");
                    return;
                }

                string words = ConvertNumberToWords(number);
                textBox2.Text = words;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên có 12 chữ số.", "Lỗi Nhập liệu");
            }
        }

        private string ConvertNumberToWords(long number)
        {
            if (number == 0)
                return "Không";

            string words = "";
            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] teens = { "", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] thousandsGroups = { "", "ngàn", "triệu", "tỷ" };

            int numGroups = 4;
            int[] groups = new int[numGroups];
            for (int i = 0; i < numGroups; i++)
            {
                groups[i] = (int)(number % 1000);
                number /= 1000;
            }

            for (int i = numGroups - 1; i >= 0; i--)
            {
                int hundreds = groups[i] / 100;
                int tensUnits = groups[i] % 100;

                if (hundreds != 0)
                    words += ones[hundreds] + " trăm ";

                if (tensUnits != 0)
                {
                    if (tensUnits < 10)
                        words += ones[tensUnits];
                    else if (tensUnits < 20)
                        words += teens[tensUnits - 10];
                    else
                    {
                        words += ones[tensUnits / 10] + " mươi ";
                        if (tensUnits % 10 != 0)
                            words += ones[tensUnits % 10];
                    }
                }

                if (groups[i] != 0)
                    words += thousandsGroups[i] + " ";
            }

            return words.Trim();
        }
    }
}
