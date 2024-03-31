using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB2
{
    public partial class LAB2_bai06 : Form
    {
        string strcon = @"Data Source=LAPTOP-RRLBSJAC;Initial Catalog=ramdomMonAn;Integrated Security=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public LAB2_bai06()
        {
            InitializeComponent();
        }

        // Xử lý khi form được tải lên
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo kết nối đến cơ sở dữ liệu
        }

        // Thêm một món ăn mới vào cơ sở dữ liệu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string strCom = "insert into MonAn values(@IDMA,@TenMonAn,@HinhAnh,@IDNCC)";
                SqlCommand com = new SqlCommand(strCom, sqlCon);
                com.Parameters.AddWithValue("@IDMA", textBox1.Text);
                com.Parameters.AddWithValue("@TenMonAn", textBox2.Text);
                com.Parameters.AddWithValue("@HinhAnh", convertImageToBytes()); // Chuyển hình ảnh thành mảng byte
                com.Parameters.AddWithValue("@IDNCC", textBox4.Text);
                com.ExecuteNonQuery();
                sqlCon.Close();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        // Thêm một người dùng mới vào cơ sở dữ liệu
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string IDNCC = textBox8.Text;
                string HoVaTen = textBox7.Text;
                string QuyenHan = textBox6.Text;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO NguoiDung VALUES('" + IDNCC + "','" + HoVaTen + "','" + QuyenHan + "')";
                sqlCmd.Connection = sqlCon;
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Chọn hình ảnh từ máy tính
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "JPG files (*jpg) | *.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                textBox3.Text = openFileDialog1.FileName;
            }
        }

        // Hiển thị tất cả các món ăn trong cơ sở dữ liệu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from MonAn", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Hiển thị tất cả người dùng trong cơ sở dữ liệu
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM NguoiDung";
                sqlCmd.Connection = sqlCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSachNguoiDung.Items.Clear();
                while (reader.Read())
                {
                    string IDNCC = reader.GetString(0);
                    string HoVaTen = reader.GetString(1);
                    string QuyenHan = reader.GetString(2);
                    ListViewItem lvi = new ListViewItem(IDNCC);
                    lvi.SubItems.Add(HoVaTen);
                    lvi.SubItems.Add(QuyenHan);
                    lsvDanhSachNguoiDung.Items.Add(lvi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Chuyển hình ảnh thành mảng byte
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(textBox3.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        // Chọn một món ăn ngẫu nhiên từ cơ sở dữ liệu
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("SELECT TOP 1 MonAn.IDMA, MonAn.TenMonAn, MonAn.HinhAnh, MonAn.IDNCC, NguoiDung.HoVaTen, NguoiDung.QuyenHan FROM MonAn INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC ORDER BY NEWID();", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
