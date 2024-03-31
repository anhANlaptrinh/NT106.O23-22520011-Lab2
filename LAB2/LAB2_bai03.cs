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
using System.Globalization;

namespace LAB2
{
    public partial class LAB2_bai03 : Form
    {
        public LAB2_bai03()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi người dùng nhấn vào nút "Tính toán và lưu kết quả"
        private void buttom0_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến tập tin đầu vào và tập tin đầu ra
            string inputFilePath = "C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\input3.txt";
            string outputFilePath = "C:\\Users\\ASUS\\Desktop\\WFC#\\22520011-DoHuynhAn-Lab02\\LAB2\\output3.txt";

            // Sử dụng StreamReader để đọc từng dòng trong tập tin đầu vào và StreamWriter để ghi kết quả tính toán vào tập tin đầu ra
            using (StreamReader sr = new StreamReader(inputFilePath))
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                string content = "";
                while (true)
                {
                    string expression = sr.ReadLine();
                    if (expression == null)
                    {
                        break;
                    }

                    // Tính toán kết quả của biểu thức và ghi vào tập tin đầu ra
                    double result = TinhToan.Evaluate(expression);
                    content += expression + "=" + result.ToString() + "\n";
                    sw.WriteLine(expression + "=" + result.ToString());
                }
                // Hiển thị nội dung tính toán trong TextBox
                textBox0.Text = content;
            }
        }

        // Lớp để thực hiện tính toán biểu thức
        public class TinhToan
        {
            // Phương thức để tính toán kết quả của biểu thức
            public static double Evaluate(string expression)
            {
                // Loại bỏ khoảng trắng trong biểu thức
                expression = expression.Replace(" ", "");
                return EvaluateExpression(expression);
            }

            // Phương thức để đánh giá và tính toán kết quả của biểu thức
            private static double EvaluateExpression(string expression)
            {
                Stack<double> numbers = new Stack<double>();
                Stack<char> operations = new Stack<char>();

                // Duyệt qua từng ký tự trong biểu thức
                for (int i = 0; i < expression.Length; i++)
                {
                    char c = expression[i];
                    if (c == ' ')
                        continue;

                    // Nếu ký tự là số hoặc dấu chấm thập phân
                    if (char.IsDigit(c) || c == '.')
                    {
                        string numStr = c.ToString();

                        // Tiếp tục đọc các ký tự liên tiếp là số hoặc dấu chấm thập phân
                        while (i + 1 < expression.Length && (char.IsDigit(expression[i + 1]) || expression[i + 1] == '.'))
                        {
                            numStr += expression[i + 1];
                            i++;
                        }

                        // Chuyển đổi chuỗi số thành số thực và đẩy vào ngăn xếp numbers
                        double num = double.Parse(numStr, CultureInfo.InvariantCulture);
                        numbers.Push(num);
                    }
                    // Nếu ký tự là dấu mở ngoặc '('
                    else if (c == '(')
                    {
                        operations.Push(c);
                    }
                    // Nếu ký tự là dấu đóng ngoặc ')'
                    else if (c == ')')
                    {
                        // Tiến hành tính toán các phép toán bên trong dấu ngoặc và đẩy kết quả vào ngăn xếp numbers
                        while (operations.Peek() != '(')
                        {
                            EvaluateOperation(numbers, operations);
                        }
                        operations.Pop(); // Loại bỏ dấu mở ngoặc '(' khỏi ngăn xếp operations
                    }
                    // Nếu ký tự là một toán tử (+, -, *, /)
                    else
                    {
                        // Tiến hành tính toán các phép toán có ưu tiên cao hơn hoặc bằng toán tử hiện tại và đẩy vào ngăn xếp numbers
                        while (operations.Count > 0 && GetPrecedence(operations.Peek()) >= GetPrecedence(c))
                        {
                            EvaluateOperation(numbers, operations);
                        }
                        operations.Push(c);
                    }
                }

                // Tiến hành tính toán các phép toán còn lại trong ngăn xếp operations
                while (operations.Count > 0)
                {
                    EvaluateOperation(numbers, operations);
                }

                // Trả về kết quả cuối cùng
                return numbers.Pop();
            }

            // Phương thức để thực hiện phép toán giữa hai số
            private static void EvaluateOperation(Stack<double> numbers, Stack<char> operations)
            {
                char op = operations.Pop();
                double num2 = numbers.Pop();
                double num1 = numbers.Pop();
                double result = 0;

                // Thực hiện phép toán tương ứng với toán tử và đẩy kết quả vào ngăn xếp numbers
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                }

                numbers.Push(result);
            }

            // Phương thức để lấy ưu tiên của toán tử
            private static int GetPrecedence(char op)
            {
                if (op == '+' || op == '-')
                    return 1;
                if (op == '*' || op == '/')
                    return 2;
                return 0;
            }
        }
    }
}
