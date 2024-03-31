using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class LAB1_bai07 : Form
    {
        public LAB1_bai07()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] parts = input.Split(',');
            string ten_sv = parts[0];
            double[] diem_mon = parts.Skip(1).Select(double.Parse).ToArray();

            hoten.Text = ten_sv.ToString();
            string multiplicationTable = "";
            for (int i = 0; i < diem_mon.Length; i++)
            {
                multiplicationTable += $"Môn {i + 1}: {diem_mon[i]}{Environment.NewLine}";
            }
            danhsachdiem.Text = multiplicationTable;
            double diem_tb = diem_mon.Sum() / diem_mon.Length;
            diemtrungbinh.Text = diem_tb.ToString();
            double diem_cao_nhat = diem_mon.Max();
            double diem_thap_nhat = diem_mon.Min();
            diemmax.Text = diem_cao_nhat.ToString();
            diemmin.Text = diem_thap_nhat.ToString();
            int so_mon_dau = diem_mon.Count(d => d >= 5);
            int so_mon_khong_dau = diem_mon.Count(d => d < 5);
            somondau.Text = so_mon_dau.ToString();
            somonrot.Text = so_mon_khong_dau.ToString();
            string xep_loai = XepLoaiSinhVien(diem_tb, diem_mon);
            xeploai.Text =  xep_loai;
        }

        private string XepLoaiSinhVien(double diem_tb, double[] diem_mon)
        {
            if (diem_tb >= 8 && diem_mon.All(d => d >= 6.5))
                return "Giỏi";
            else if (diem_tb >= 6.5 && diem_mon.All(d => d >= 5))
                return "Khá";
            else if (diem_tb >= 5 && diem_mon.All(d => d >= 3.5))
                return "Trung bình";
            else if (diem_tb >= 3.5 && diem_mon.All(d => d >= 2))
                return "Yếu";
            else
                return "Kém";
        }
    }
}
