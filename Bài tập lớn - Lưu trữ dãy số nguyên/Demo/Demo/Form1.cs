using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;

namespace Demo
{
    public partial class Form1 : Form
    {
        private int[] stackArray = new int[100]; //mảng stack
        private int top = -1;

        private int[] numbers; // Mảng để lưu trữ dãy số nguyên
        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void ExecuteWithTimeMeasure()
        {
            stopwatch.Start();

            // Gọi các hàm để thực hiện chương trình
            // Ví dụ:
            // addButton_Click(null, null);
            // saveButton_Click(null, null);
            // loadButton_Click(null, null);

            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            textBoxExecutionTime.Text = timeSpan.TotalMilliseconds + " ms.";
        }

        //thêm 1 phần tử mới vào đỉnh của stack nếu stack chưa đầy, ngược lại hiển thị thông báo lỗi
        private void Push(int data)
        {
            if (top >= 99)
            {
                MessageBox.Show("Stack overflow");
            }
            else
            {
                stackArray[++top] = data;
            }
        }

        //Loại bỏ phần tử trên đỉnh của stack và trả về giá trị của phần tử đó, nếu rỗng thì hiển thị thông báo lỗi và trả về 0
        private int Pop()
        {
            if (top < 0)
            {
                MessageBox.Show("Stack is empty");
                return 0;
            }
            else
            {
                int value = stackArray[top--];
                return value;
            }
        }
        private void DisplayStackContents()
        {
            lstNumbers.Items.Clear();
            lstSum.Items.Clear();
            int sum = 0;

            for (int i = top; i >= 0; i--)
            {
                lstNumbers.Items.Add(stackArray[i]);
                /*if (i == top)
                {
                    lstNumbers.Items.Add(stackArray[i].ToString());
                }
                else
                {
                    lstNumbers.Items.Add("," + stackArray[i].ToString());
                }*/
                sum += stackArray[i];
            }
            lstSum.Items.Add(sum);
        }

        //Nhập dãy số (stack)
        private void buttonNhapStack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNhap.Text))
            {
                int number;
                if (int.TryParse(textBoxNhap.Text, out number))
                {
                    Push(number);
                    textBoxNhap.Clear();
                    DisplayStackContents();
                    ExecuteWithTimeMeasure();
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.");
                }
            }
        }

        //Dãy số sinh ngẫu nhiên
        private void GenerateRandomArray()
        {
            numbers = new int[10]; // Mảng có 10 phần tử
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); // Sinh ngẫu nhiên dãy số từ 1 đến 100
            }

            DisplayArray();
        }
        private void DisplayArray()
        {
            lstNumbers.Items.Clear();
            foreach (int number in numbers)
            {
                lstNumbers.Items.Add(number);
            }
        }
        private void buttonRandom_Click_1(object sender, EventArgs e)
        {
            lstSum.Items.Clear();
            GenerateRandomArray();
        }

        //Lưu dãy số
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                //Nếu i không phải phần tử cuối cùng trong mảng, dấu phẩy được ghi sau mỗi giá trị để tạo ra định dạng phân cách
                for (int i = top; i >= 0; i--)
                {
                    writer.Write(stackArray[i]);
                    if (i != 0)
                    {
                        writer.Write(",");
                    }
                }
            }
            MessageBox.Show("Numbers saved to file.");
            ExecuteWithTimeMeasure();
            lstNumbers.Items.Clear();
            lstSum.Items.Clear();


            /*string data = "";
            for (int i = top; i >= 0; i--)
            {
                data += stackArray[i].ToString();
                if (i != 0)
                {
                    data += ",";
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, data);
                MessageBox.Show("Numbers saved to file.");
            }
            lstNumbers.Items.Clear();*/
        }


        //Đọc file
        private void ReadButton_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
            top = -1;
            string line;
            using (StreamReader reader = new StreamReader("numbers.txt"))
            {
                line = reader.ReadLine(); //đọc 1 dòng dữ liệu từ tệp văn bản và gán nó cho biến line
            }
            string[] numbers = line.Split(',');
            foreach (var number in numbers)
            {
                if (!string.IsNullOrWhiteSpace(number))
                {
                    Push(int.Parse(number));
                }
            }
            DisplayStackContents();
            ExecuteWithTimeMeasure();

            /*
            lstNumbers.Items.Clear();
            top = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string line = File.ReadAllText(openFileDialog.FileName);
                string[] numbers = line.Split(',');
                foreach (var number in numbers)
                {
                    if (!string.IsNullOrWhiteSpace(number))
                    {
                        Push(int.Parse(number));
                    }
                }
                DisplayStackContents();
            }*/
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Vui lòng sinh dãy số trước khi thực hiện phép toán.");
                return;
            }
            // Bắt đầu đo thời gian
            stopwatch.Start();

            int resultAdd = numbers[0];
            int resultSubtract = numbers[0];
            int resultMultiply = numbers[0];
            int resultDivide = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                resultAdd += numbers[i];
                resultSubtract -= numbers[i];
                resultMultiply *= numbers[i];

                if (numbers[i] == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.");
                    stopwatch.Stop();
                    return;
                }
                resultDivide /= numbers[i];
            }

            // Kết thúc đo thời gian
            stopwatch.Stop();

            // Hiển thị kết quả
            lstSum.Items.Clear();
            lstSum.Items.Add("Cộng: " + resultAdd);
            lstSum.Items.Add("Trừ: " + resultSubtract);
            lstSum.Items.Add("Nhân: " + resultMultiply);
            lstSum.Items.Add("Chia: " + resultDivide);

            // Hiển thị thời gian thực thi trong TextBox
            textBoxExecutionTime.Text = stopwatch.ElapsedMilliseconds + " ms";
        }

        
    }
}