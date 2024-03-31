using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace LAB2
{
    public partial class LAB2_bai04 : Form
    {
        public LAB2_bai04()
        {
            InitializeComponent();
        }

        // Khai báo lớp Student để định nghĩa thông tin của một sinh viên
        public class Student
        {
            public string Mssv { get; set; }
            public string HoTen { get; set; }
            public string Sdt { get; set; }
            public float Diem1 { get; set; }
            public float Diem2 { get; set; }
            public float Diem3 { get; set; }
            public float dtb { get; set; }

            // Phương thức để thiết lập thông tin của một sinh viên
            public void SetSt(string mssv, string ht, string dt, float diem1, float diem2, float diem3)
            {
                Mssv = mssv;
                HoTen = ht;
                Sdt = dt;
                Diem1 = diem1;
                Diem2 = diem2;
                Diem3 = diem3;
            }

            // Phương thức để lấy thông tin của một sinh viên dưới dạng chuỗi
            public string GetSt()
            {
                string content = "";
                content = Mssv + "\n" + HoTen + "\n" + Sdt + "\n" + Diem1.ToString() + "\n" + Diem2.ToString() + "\n" + Diem3.ToString() + "\n";
                if (dtb != null)
                {
                    content += ((float)dtb).ToString();
                }
                content += "\n";
                return content;
            }

            // Phương thức để tính điểm trung bình của một sinh viên
            public float Tinh()
            {
                dtb = (Diem1 + Diem2 + Diem3) / 3;
                return dtb;
            }
        }

        // Khai báo danh sách sinh viên
        List<Student> students = new List<Student>();

        // Xử lý sự kiện khi người dùng nhấn nút "Thêm sinh viên"
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng Student mới và thiết lập thông tin từ các TextBox
            Student student = new Student();
            student.Mssv = tbMssv.Text;
            student.HoTen = tbHoTen.Text;
            student.Sdt = tbSđt.Text;
            student.Diem1 = float.Parse(diem1.Text);
            student.Diem2 = float.Parse(diem2.Text);
            student.Diem3 = float.Parse(diem3.Text);

            // Kiểm tra tính hợp lệ của MSSV, SĐT và điểm
            if (IsValidMssv(student.Mssv) && IsValidPhoneNumber(student.Sdt) && IsValidGrade(student.Diem1) && IsValidGrade(student.Diem2) && IsValidGrade(student.Diem3))
            {
                // Thêm sinh viên vào danh sách và tải lại dữ liệu
                students.Add(student);
                LoadData();
            }
            else
            {
                MessageBox.Show("MSSV hoặc SĐT hoặc Điểm không hợp lệ!");
            }
        }

        // Phương thức để kiểm tra tính hợp lệ của MSSV
        private bool IsValidMssv(string mssv)
        {
            return mssv.Length == 8 && mssv.All(char.IsDigit);
        }

        // Phương thức để kiểm tra tính hợp lệ của SĐT
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.StartsWith("0") && phoneNumber.All(char.IsDigit);
        }

        // Phương thức để kiểm tra tính hợp lệ của điểm
        private bool IsValidGrade(float grade)
        {
            return grade >= 0 && grade <= 10;
        }

        // Phương thức để tải lại dữ liệu vào ListView
        private void LoadData()
        {
            listView.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.Mssv);
                item.SubItems.Add(student.HoTen);
                item.SubItems.Add(student.Sdt);
                item.SubItems.Add(student.Diem1.ToString());
                item.SubItems.Add(student.Diem2.ToString());
                item.SubItems.Add(student.Diem3.ToString());
                listView.Items.Add(item);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Lưu danh sách sinh viên"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lưu danh sách sinh viên vào tập tin đầu vào
            SaveStudentsToFile("C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\input4.txt");
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Tính điểm trung bình và lưu kết quả"
        private void btnTinh_Click(object sender, EventArgs e)
        {
            // Tính điểm trung bình của từng sinh viên
            CalculateAverages();

            // Lưu kết quả vào tập tin đầu ra
            SaveStudentsToFile("C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\output4.txt");
        }

        // Phương thức để tính điểm trung bình của từng sinh viên
        private void CalculateAverages()
        {
            foreach (var student in students)
            {
                student.Tinh();
            }
        }

        // Phương thức để lưu danh sách sinh viên vào tập tin
        private void SaveStudentsToFile(string fileName)
        {
            try
            {
                // Chuyển danh sách sinh viên thành chuỗi JSON và lưu vào tập tin
                string jsonString = JsonSerializer.Serialize(students);
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Lưu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công: " + ex.Message);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Mở danh sách sinh viên từ tập tin"
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Mở tập tin đầu ra và hiển thị danh sách sinh viên
            OpenStudentsFromFile("C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\output4.txt");
            DisplayStudents();
        }

        // Phương thức để hiển thị danh sách sinh viên trong RichTextBox
        private void DisplayStudents()
        {
            rtbFile.Clear();

            foreach (var student in students)
            {
                rtbFile.AppendText($"MSSV: {student.Mssv}\n");
                rtbFile.AppendText($"Họ tên: {student.HoTen}\n");
                rtbFile.AppendText($"Điện thoại: {student.Sdt}\n");
                rtbFile.AppendText($"Điểm 1: {student.Diem1}\n");
                rtbFile.AppendText($"Điểm 2: {student.Diem2}\n");
                rtbFile.AppendText($"Điểm 3: {student.Diem3}\n");
                rtbFile.AppendText($"Điểm trung bình: {student.dtb}\n\n");
            }
        }

        // Phương thức để mở tập tin và đọc danh sách sinh viên
        private void OpenStudentsFromFile(string fileName)
        {
            try
            {
                // Đọc nội dung tập tin và chuyển đổi thành danh sách sinh viên
                string jsonString = File.ReadAllText(fileName);
                students = JsonSerializer.Deserialize<List<Student>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load file không thành công: " + ex.Message);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Xóa thông tin"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong các TextBox
            tbHoTen.Text = null;
            tbMssv.Text = null;
            tbSđt.Text = null;
            diem1.Text = null;
            diem2.Text = null;
            diem3.Text = null;
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }
    }
}
