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
    public partial class LAB2_bai07 : Form
    {
        public LAB2_bai07()
        {
            InitializeComponent();
            // Lấy danh sách các ổ đĩa và hiển thị chúng trên TreeView
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                treeView1.Nodes.Add(node);
                Load(node); // Tải nội dung cho mỗi ổ đĩa
            }
        }

        // Phương thức này được sử dụng để tải các thư mục và tập tin con của một thư mục đã chọn
        private void Load(TreeNode parentNode)
        {
            DirectoryInfo[] directories = ((DirectoryInfo)parentNode.Tag).GetDirectories();
            AddNodes(parentNode, directories); // Thêm các nút cho các thư mục

            FileInfo[] files = ((DirectoryInfo)parentNode.Tag).GetFiles();
            AddNodes(parentNode, files); // Thêm các nút cho các tập tin
        }

        // Phương thức này được sử dụng để thêm các nút vào TreeView cho các thư mục hoặc tập tin đã lấy được
        private void AddNodes(TreeNode parentNode, FileSystemInfo[] items)
        {
            foreach (var item in items)
            {
                TreeNode node;
                if (item is DirectoryInfo directory)
                {
                    node = new TreeNode(directory.Name);
                    node.Tag = directory;
                    node.Nodes.Add(""); // Thêm một nút trống để có thể mở rộng thư mục
                }
                else
                {
                    node = new TreeNode(item.Name);
                    node.Tag = item;
                }
                parentNode.Nodes.Add(node);
            }
        }

        // Xử lý sự kiện khi người dùng nhấp đúp chuột vào một nút trong TreeView
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo directory)
            {
                // Nếu người dùng nhấp vào một thư mục, tải nội dung của thư mục đó
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Remove();
                }
                DirectoryInfo[] subDirectories = directory.GetDirectories();
                AddNodes(e.Node, subDirectories); // Thêm các nút cho các thư mục con

                FileInfo[] files = directory.GetFiles();
                AddNodes(e.Node, files); // Thêm các nút cho các tập tin trong thư mục
            }
            else if (e.Node.Tag is FileInfo file)
            {
                // Nếu người dùng nhấp vào một tập tin, hiển thị nội dung của tập tin
                if (IsImage(file.FullName))
                {
                    DisplayImageContent(file.FullName); // Hiển thị hình ảnh nếu là hình ảnh
                }
                else
                {
                    DisplayTextContent(file.FullName); // Hiển thị văn bản nếu là tập tin văn bản
                }
            }
        }

        // Xử lý sự kiện trước khi một nút được mở rộng trong TreeView
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "")
            {
                // Nếu nút có chỉ một nút con trống, xóa nút con trống và tải nội dung cho nút
                e.Node.Nodes.Clear();
                Load(e.Node);
            }
        }

        // Kiểm tra xem một tập tin có phải là hình ảnh không
        private bool IsImage(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(filePath);
            return imageExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        // Hiển thị nội dung hình ảnh
        private void DisplayImageContent(string imagePath)
        {
            try
            {
                richTextBox1.Visible = false;
                pictureBox1.Visible = true;
                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        // Hiển thị nội dung văn bản
        private void DisplayTextContent(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;
                richTextBox1.Visible = true;
                pictureBox1.Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
