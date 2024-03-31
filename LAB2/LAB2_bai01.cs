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
    public partial class LAB2_bai01 : Form
    {
        public LAB2_bai01()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi người dùng nhấn vào nút "Đọc file"
        private void button1_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến tập tin đầu vào
            string inputFilePath = "C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\input1.txt";

            // Kiểm tra xem tập tin có tồn tại không
            if (!File.Exists(inputFilePath))
            {
                MessageBox.Show("File không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Đọc nội dung từ tập tin và hiển thị trong TextBox
            textBox1.Text = File.ReadAllText(inputFilePath);

            // Thông báo thành công
            MessageBox.Show("Đã đọc nội dung thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý sự kiện khi người dùng nhấn vào nút "Ghi file"
        private void button2_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến tập tin đầu ra
            string outputFilePath = "C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\output1.txt";

            // Chuyển đổi nội dung trong TextBox thành chữ hoa
            string content = textBox1.Text.ToUpper();

            // Ghi nội dung vào tập tin
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write(content);
            }

            // Hiển thị nội dung đã chuyển đổi trong TextBox
            textBox1.Text = content;

            // Thông báo thành công
            MessageBox.Show("Đã ghi nội dung thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
