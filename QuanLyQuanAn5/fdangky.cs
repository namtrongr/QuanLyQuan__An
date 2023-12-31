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

namespace QuanLyQuanAn5
{
    public partial class fdangky : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2GOHCLB7\CHIENSQL;Initial Catalog=QuanLyQuanAn5;Integrated Security=True";
        public fdangky()
        {
            InitializeComponent();
        }

        private void fdangky_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsAccountExists(string tendangnhap)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM taikhoan WHERE TenDangNhap = @tendangnhap";
            command.Parameters.AddWithValue("@tendangnhap", tendangnhap);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }
        private bool Checktkmk()
        {
            string userInput = tbtaikhoan.Text;
            int lengthtaikhoan = userInput.Length;
            string userInput1 = tbmatkhau.Text;
            int lengthmatkhau = userInput1.Length;


            if (lengthtaikhoan > 0 && lengthmatkhau > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        private void btndangky_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Checktkmk())
                {
                    MessageBox.Show("Vui lòng không để trống tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra xem mã món ăn đã tồn tại hay chưa
                if (IsAccountExists(tbtaikhoan.Text))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không trùng, thực hiện thêm món ăn vào cơ sở dữ liệu
                command = connection.CreateCommand();
                command.CommandText = "Insert into taikhoan values(@tendangnhap, @matkhau)";
                command.Parameters.AddWithValue("@tendangnhap", tbtaikhoan.Text);
                command.Parameters.AddWithValue("@matkhau", tbmatkhau.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("đăng ký thành thông ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
