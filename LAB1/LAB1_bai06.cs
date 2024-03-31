using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LAB1
{
    public partial class LAB1_bai06 : Form
    {
        public LAB1_bai06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day, month;
            day = int.Parse(textBox1.Text);
            month = int.Parse(textBox2.Text);
            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                textBox3.Text = "cung Bạch Dương";
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                textBox3.Text = "cung Kim Ngưu";
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
                textBox3.Text = "cung Song Tử";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                textBox3.Text = "cung Cự Giải";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                textBox3.Text = "cung Sư Tử";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 23))
                textBox3.Text = "cung Xử Nữ";
            else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
                textBox3.Text = "cung Thiên Bình";
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
                textBox3.Text = "cung Thần Nông";
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
                textBox3.Text = "cung Nhân Mã";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
                textBox3.Text = "cung Ma Kết";
            else if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
                textBox3.Text = "cung Bảo Bình";
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
                textBox3.Text = "cung Song Ngư";
            else
            {
                MessageBox.Show("Ngay thang khong hop le,Vui long nhap lai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}

