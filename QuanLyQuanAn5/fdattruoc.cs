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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanAn5
{
    public partial class fdattruoc : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2GOHCLB7\CHIENSQL;Initial Catalog=QuanLyQuanAn5;Integrated Security=True";
        public fdattruoc()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsKhachTruocExists(string SDT)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM dattruoc WHERE SDT = @SDT";
            command.Parameters.AddWithValue("@SDT", SDT);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }

        private bool KiemTraTT(System.Windows.Forms.TextBox tbtenkhf2 , System.Windows.Forms.TextBox tbsdtkhf2, System.Windows.Forms.TextBox tbsoluongkhf2, System.Windows.Forms.TextBox tbemailkhf2, System.Windows.Forms.TextBox tbbanf2)
        {
            // Kiểm tra xem tất cả các TextBox có dữ liệu hay không
            return tbtenkhf2.Text.Trim().Length > 0
                && tbsdtkhf2.Text.Trim().Length > 0
                && tbsoluongkhf2.Text.Trim().Length > 0
                && tbemailkhf2.Text.Trim().Length>0
                && tbbanf2.Text.Trim().Length > 0;
        }
        private bool Checksoluongnguoi()
        {
            // Kiểm tra kiểu dữ liệu của giá
            if (int.TryParse(tbsoluongkhf2.Text, out int slkhach))
            {
                // Dữ liệu là số nguyên
                return true;
            }
            else
            {

                return false;
            }
        }
        private bool Checksdt()
        {
            // Kiểm tra kiểu dữ liệu của giá
            if (lengthsdt==10)
            {
                // Dữ liệu là số nguyên
                return true;
            }
            else
            {

                return false;
            }
        }
        private void btdattruocf2_Click(object sender, EventArgs e)
        {
            if (!KiemTraTT(tbtenkhf2, tbsdtkhf2, tbsoluongkhf2, tbemailkhf2,tbbanf2))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cho tất cả các ô nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Checksdt())
            {
                MessageBox.Show("Vui lòng điền đúng 10 số cho số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Checksoluongnguoi())
            {
                MessageBox.Show("Vui lòng nhập số người là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailInput = tbemailkhf2.Text;

            // Check if the email is valid
            if (!IsEmailValid(emailInput))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (IsKhachTruocExists(tbsdtkhf2.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không trùng, thực hiện thêm món ăn vào cơ sở dữ liệu
                command = connection.CreateCommand();
                command.CommandText = "Insert into dattruoc values(@TenKH, @SDT, @SoLuong,@Email,@BanSo)";
                command.Parameters.AddWithValue("@TenKH", tbtenkhf2.Text);
                command.Parameters.AddWithValue("@SDT", tbsdtkhf2.Text);
                command.Parameters.AddWithValue("@SoLuong", tbsoluongkhf2.Text);
                command.Parameters.AddWithValue("@Email", emailInput);
                command.Parameters.AddWithValue("@BanSo", tbbanf2.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Đã đặt bàn thành công. Vui lòng cập nhật bảng.", "Thông báo", MessageBoxButtons.OK);

                // Load lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            // Thực hiện hành động đặt bàn ở đây
            MessageBox.Show("Bàn đã được đặt thành công!");


        }
        private void CheckTableNumber()
        {
            // Lấy giá trị từ textbox
            if (int.TryParse(tbbanf2.Text, out int tableNumber))
            {
                // Kiểm tra nếu giá trị nằm ngoài phạm vi từ bàn 1 đến bàn 6
                if (tableNumber < 1 || tableNumber > 6)
                {
                    MessageBox.Show("Vui lòng nhập số bàn từ 1 đến 6.");
                    // Xoá giá trị nhập sai trong textbox
                    tbbanf2.Text = string.Empty;
                    // Focus vào textbox để người dùng nhập lại
                    tbbanf2.Focus();
                }
                else
                {
                    // Nếu giá trị hợp lệ, tiếp tục xử lý
                    // Ví dụ: Thực hiện công việc cần thiết cho bàn số này
                    // Ví dụ: Gọi hàm xử lý khi số bàn là hợp lệ
                    ProcessTable(tableNumber);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên.");
                // Xoá giá trị nhập sai trong textbox
                tbbanf2.Text = string.Empty;
                // Focus vào textbox để người dùng nhập lại
                tbbanf2.Focus();
            }
        }

        private void ProcessTable(int tableNumber)
        {
            // Thực hiện công việc cần thiết với số bàn hợp lệ ở đây
            // Ví dụ: Hiển thị thông tin, thao tác với bàn số này, vv.
            MessageBox.Show($"Bạn đang làm việc với bàn số {tableNumber}");
        }

        private void fdattruoc_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
        }

        private void tbbanf2_TextChanged(object sender, EventArgs e)
        {
            CheckTableNumber();
        }
        int lengthsdt;
        private void tbsdtkhf2_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string userInput = tbsdtkhf2.Text;

            // Kiểm tra độ dài
            lengthsdt = userInput.Length;

        }
        public bool IsEmailValid(string email)
        {
            return email.Contains("@gmail.com");
        }

        private void tbemailkhf2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btdattruocf2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
