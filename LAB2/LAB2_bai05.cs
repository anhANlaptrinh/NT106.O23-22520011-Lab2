using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LAB2
{
    public partial class LAB2_bai05 : Form
    {
        public LAB2_bai05()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Xử lý tệp"
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại để chọn tệp
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string inputFile = openFileDialog.FileName; // Đường dẫn tới tệp input
                    string outputFile = "C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\output5.txt"; // Đường dẫn tới tệp output
                    ProcessInputFile(inputFile, outputFile); // Gọi phương thức xử lý tệp input
                }
            }
        }

        // Phương thức để xử lý tệp input
        private void ProcessInputFile(string inputFile, string outputFile)
        {
            if (File.Exists(inputFile)) // Kiểm tra xem tệp input có tồn tại không
            {
                // Đọc dữ liệu từ tệp input
                string[] lines = File.ReadAllLines(inputFile);
                int totalLines = lines.Length;

                // Khởi tạo ProgressBar để hiển thị tiến trình xử lý
                progressBar.Minimum = 0;
                progressBar.Maximum = totalLines;
                progressBar.Step = 1;

                List<Movie> movies = new List<Movie>(); // Danh sách để lưu thông tin các bộ phim

                // Xử lý từng dòng trong tệp input
                for (int i = 0; i < totalLines; i += 5)
                {
                    string movieName = lines[i]; // Tên phim
                    double ticketPrice = double.Parse(lines[i + 1]); // Giá vé
                    string theater = lines[i + 2]; // Rạp chiếu phim
                    int totalTickets = int.Parse(lines[i + 3]); // Tổng số vé
                    int ticketsSold = int.Parse(lines[i + 4]); // Số vé đã bán
                    Movie movie = new Movie(movieName, ticketPrice, theater, totalTickets, ticketsSold); // Tạo đối tượng Movie mới
                    movies.Add(movie); // Thêm đối tượng vào danh sách
                    progressBar.PerformStep(); // Tăng giá trị của ProgressBar
                }

                // Xử lý và ghi dữ liệu vào tệp output
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    progressBar.Value = 0;
                    progressBar.Maximum = movies.Count;
                    progressBar.Step = 1;

                    foreach (var movie in movies)
                    {
                        movie.CalculateRevenue(); // Tính doanh thu và tỉ lệ vé bán ra của từng phim
                        movie.CalculateRank(movies); // Tính xếp hạng của từng phim
                        // Ghi thông tin của từng phim vào tệp output
                        writer.WriteLine($"Tên phim: {movie.Name}");
                        writer.WriteLine($"Giá vé: {movie.TicketPrice:C}");
                        writer.WriteLine($"Tổng số lượng vé: {movie.TotalTickets}");
                        writer.WriteLine($"Số lượng vé bán ra: {movie.TicketsSold}");
                        writer.WriteLine($"Số lượng vé tồn: {movie.AvailableTickets}");
                        writer.WriteLine($"Tỉ lệ vé bán ra: {movie.SellRate:P}");
                        writer.WriteLine($"Doanh thu: {movie.Revenue:C}");
                        writer.WriteLine($"Xếp hạng doanh thu: {movie.Rank}");
                        writer.WriteLine();
                        progressBar.PerformStep(); // Tăng giá trị của ProgressBar
                    }
                }

                MessageBox.Show("Xử lý hoàn thành!");
            }
        }
    }

    // Lớp để định nghĩa thông tin của một bộ phim
    public class Movie
    {
        public string Name { get; set; } // Tên phim
        public double TicketPrice { get; set; } // Giá vé
        public string Theater { get; set; } // Rạp chiếu phim
        public int TotalTickets { get; set; } // Tổng số vé
        public int TicketsSold { get; set; } // Số vé đã bán
        public double Revenue { get; set; } // Doanh thu
        public double SellRate { get; set; } // Tỉ lệ vé bán ra
        public int AvailableTickets { get { return TotalTickets - TicketsSold; } } // Số vé còn lại
        public int Rank { get; set; } // Xếp hạng doanh thu

        public Movie(string name, double ticketPrice, string theater, int totalTickets, int ticketsSold)
        {
            Name = name;
            TicketPrice = ticketPrice;
            Theater = theater;
            TotalTickets = totalTickets;
            TicketsSold = ticketsSold;
        }

        // Phương thức để tính doanh thu và tỉ lệ vé bán ra
        public void CalculateRevenue()
        {
            Revenue = TicketsSold * TicketPrice;
            SellRate = (double)TicketsSold / TotalTickets;
        }

        // Phương thức để tính xếp hạng của bộ phim
        public void CalculateRank(List<Movie> movies)
        {
            // Sắp xếp danh sách phim theo doanh thu giảm dần
            movies = movies.OrderByDescending(m => m.Revenue).ToList();

            // Lặp qua danh sách đã sắp xếp để gán xếp hạng cho từng phim
            for (int i = 0; i < movies.Count; i++)
            {
                movies[i].Rank = i + 1;
            }
        }
    }
}
