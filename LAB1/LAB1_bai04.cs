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
    public partial class LAB1_bai04 : Form
    {
        public LAB1_bai04()
        {
            InitializeComponent();
        }
        private Dictionary<string, double> ticketPrices = new Dictionary<string, double>
        {
            { "vé vớt", 0.25 },
            { "vé thường", 1 },
            { "vé VIP", 2 }
        };

        private Dictionary<string, double> Giagoc = new Dictionary<string, double>
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        private Dictionary<string, List<string>> seatCategories = new Dictionary<string, List<string>>
        {
            { "vé vớt", new List<string> { "A1", "A5", "C1", "C5" } },
            { "vé thường", new List<string> { "A2", "A3", "A4", "C2", "C3", "C4" } },
            { "vé VIP", new List<string> { "B2", "B3", "B4" } }
        };

        private Dictionary<string, List<int>> movieRooms = new Dictionary<string, List<int>>
        {
            { "Đào, phở và piano", new List<int> { 1, 2, 3 } },
            { "Mai", new List<int> { 2, 3 } },
            { "Gặp lại chị bầu", new List<int> { 1 } },
            { "Tarot", new List<int> { 3 } }
        };

        private Dictionary<string, bool> seatsAvailability = new Dictionary<string, bool>
        {
            { "A1", true }, { "A2", true }, { "A3", true }, { "A4", true }, { "A5", true },
            { "B1", true }, { "B2", true }, { "B3", true }, { "B4", true }, { "B5", true },
            { "C1", true }, { "C2", true }, { "C3", true }, { "C4", true }, { "C5", true }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = hoten.Text;
            string movieName = comboBox2.Text;
            string ticketType = comboBox1.Text;
            string seat = soghe.Text.ToUpper();
            string room = comboBox3.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(ticketType) || string.IsNullOrEmpty(seat) || string.IsNullOrEmpty(room))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi");
                return;
            }

            if (!seatsAvailability.ContainsKey(seat) || !seatsAvailability[seat])
            {
                MessageBox.Show("Chỗ ngồi đã được chọn hoặc không tồn tại.", "Lỗi");
                return;
            }

            if (!seatCategories[ticketType].Contains(seat))
            {
                MessageBox.Show("Chỗ ngồi không hợp lệ cho loại vé đã chọn.", "Lỗi");
                return;
            }

            if (!movieRooms[movieName].Contains(int.Parse(room)))
            {
                MessageBox.Show("Phòng chiếu không hợp lệ cho phim đã chọn.", "Lỗi");
                return;
            }

            double ticketPrice = ticketPrices[ticketType] * Giagoc[movieName];
            textBox1.Text += fullName + ", Phim " + movieName + ", Phòng " + room + ", " + ticketType + ", " + ticketPrice.ToString() + Environment.NewLine;
            seatsAvailability[seat] = false;
        }
    }
}