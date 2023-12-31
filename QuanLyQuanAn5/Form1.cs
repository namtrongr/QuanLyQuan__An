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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2GOHCLB7\CHIENSQL;Initial Catalog=QuanLyQuanAn5;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {

            try
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM taikhoan WHERE TenDangNhap = @tendangnhap AND MatKhau = @matKhau";
                command.Parameters.AddWithValue("@tendangnhap", taiKhoan);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = tbtaikhoan.Text;
            string matKhau = tbmatkhau.Text;

            if (KiemTraDangNhap(taiKhoan, matKhau))
            {
                fhome f = new fhome();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Tài khoản hoặc mật khẩu sai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có thật sự muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fdangky f = new fdangky();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }
    }
}
