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
    public partial class LAB1_bai08 : Form
    {
        public LAB1_bai08()
        {
            InitializeComponent();
        }
        private string danhSachMonAn = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string monAnMoi = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(monAnMoi))
            {
                danhSachMonAn += ", " + monAnMoi;
                textBox2.Text += monAnMoi + Environment.NewLine;
                MessageBox.Show("Đã thêm món ăn mới.");
                textBox1.Text = "";
            }
        }

        private void timmonan_Click(object sender, EventArgs e)
        {
            string[] monAnList = danhSachMonAn.Split(',').Select(m => m.Trim()).ToArray();
            if (monAnList.Length > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, monAnList.Length);
                string monAnChon = monAnList[randomIndex];
                textBox3.Text = "Hôm nay ăn: " + monAnChon;
            }
            else
            {
                MessageBox.Show("Chưa có món ăn nào được thêm vào.");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
