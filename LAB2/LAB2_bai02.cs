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
    public partial class LAB2_bai02 : Form
    {
        public LAB2_bai02()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi người dùng nhấn vào nút "Chọn file"
        private void button1_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại để chọn tập tin
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Nếu người dùng chọn tập tin và nhấn OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên tập tin và đường dẫn tuyệt đối của tập tin đã chọn
                string fileName = openFileDialog.SafeFileName;
                string filePath = openFileDialog.FileName;

                // Tạo đối tượng FileInfo từ đường dẫn tập tin
                FileInfo fileInfo = new FileInfo(filePath);

                // Đọc nội dung của tập tin và hiển thị trong TextBox
                textBox1.Text = File.ReadAllText(filePath);

                // Hiển thị thông tin về tập tin trong các TextBox khác
                textBox2.Text = fileName; // Tên tập tin
                textBox3.Text = fileInfo.Length.ToString() + " bytes"; // Kích thước tập tin
                textBox4.Text = filePath; // Đường dẫn tập tin

                // Đếm số dòng, số từ và số ký tự trong tập tin
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;

                // Sử dụng StreamReader để đọc từng dòng trong tập tin
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineCount++; // Tăng biến đếm số dòng

                        // Tách các từ trong dòng và đếm số từ
                        charCount += line.Length; // Tăng biến đếm số ký tự
                        wordCount += line.Split(new char[] { ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    }
                }

                // Hiển thị số liệu về số dòng, số từ và số ký tự trong các TextBox tương ứng
                textBox5.Text = lineCount.ToString(); // Số dòng
                textBox6.Text = wordCount.ToString(); // Số từ
                textBox7.Text = charCount.ToString(); // Số ký tự
            }
        }
    }
}
