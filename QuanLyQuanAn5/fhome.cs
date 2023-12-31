using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanAn5
{
    public partial class fhome : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2GOHCLB7\CHIENSQL;Initial Catalog=QuanLyQuanAn5;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from monan ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv1.DataSource = table;
        }

        void loaddata3()
        {
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            DataTable table3 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoadon1";
            adapter3.SelectCommand = command;
            table3.Clear();
            adapter3.Fill(table3);
            dgv4.DataSource = table3;
        }
        void loaddata4()
        {
            SqlDataAdapter adapter4 = new SqlDataAdapter();
            DataTable table4 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from donhang";
            adapter4.SelectCommand = command;
            table4.Clear();
            adapter4.Fill(table4);
            dgv.DataSource = table4;
        }
        void loaddata5()
        {
            SqlDataAdapter adapter5 = new SqlDataAdapter();
            DataTable table5 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from monan";
            adapter5.SelectCommand = command;
            table5.Clear();
            adapter5.Fill(table5);
            dgv5.DataSource = table5;
        }
        void loaddata6()
        {
            SqlDataAdapter adapter6 = new SqlDataAdapter();
            DataTable table6 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoadon2";
            adapter6.SelectCommand = command;
            table6.Clear();
            adapter6.Fill(table6);
            dgv4.DataSource = table6;
        }
        void loaddata7()
        {
            SqlDataAdapter adapter7 = new SqlDataAdapter();
            DataTable table7 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoadon3";
            adapter7.SelectCommand = command;
            table7.Clear();
            adapter7.Fill(table7);
            dgv4.DataSource = table7;
        }
        void loaddata8()
        {
            SqlDataAdapter adapter8 = new SqlDataAdapter();
            DataTable table8 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoadon4";
            adapter8.SelectCommand = command;
            table8.Clear();
            adapter8.Fill(table8);
            dgv4.DataSource = table8;
        }
        void loaddata9()
        {
            SqlDataAdapter adapter9 = new SqlDataAdapter();
            DataTable table9 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoadon5";
            adapter9.SelectCommand = command;
            table9.Clear();
            adapter9.Fill(table9);
            dgv4.DataSource = table9;
        }
        void loaddata10()
        {
            SqlDataAdapter adapter10 = new SqlDataAdapter();
            DataTable table10 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoadon6";
            adapter10.SelectCommand = command;
            table10.Clear();
            adapter10.Fill(table10);
            dgv4.DataSource = table10;
        }
        void loaddata11()
        {
            SqlDataAdapter adapter11 = new SqlDataAdapter();
            DataTable table11 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from khohang";
            adapter11.SelectCommand = command;
            table11.Clear();
            adapter11.Fill(table11);
            dgv6.DataSource = table11;
        }
        void loaddata12()
        {
            SqlDataAdapter adapter12 = new SqlDataAdapter();
            DataTable table12 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from hoivien";
            adapter12.SelectCommand = command;
            table12.Clear();
            adapter12.Fill(table12);
            dgv7.DataSource = table12;
        }
        void loaddata13()
        {
            SqlDataAdapter adapter13 = new SqlDataAdapter();
            DataTable table13 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from luong ";
            adapter13.SelectCommand = command;
            table13.Clear();
            adapter13.Fill(table13);
            dgv11.DataSource = table13;
        }
        void loaddata2()
        {
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            DataTable table2 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from thongtinns";
            adapter2.SelectCommand = command;
            table2.Clear();
            adapter2.Fill(table2);
            dgv12.DataSource = table2;
        }
        void loaddata14()
        {
            SqlDataAdapter adapter14 = new SqlDataAdapter();
            DataTable table14 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from dattruoc";
            adapter14.SelectCommand = command;
            table14.Clear();
            adapter14.Fill(table14);
            dgv13.DataSource = table14;
        }

        public fhome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
        
            tabControl1.SelectedTab = tabPage1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void fhome_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loaddata2();
            loaddata13();
            loaddata4();
            loaddata5();
            loaddata11();
            loaddata12();
            loaddata14();
        }
        private int GetPriceByItemID(string itemID)
        {
         

            command = connection.CreateCommand();
            command.CommandText = "SELECT Gia FROM monan WHERE MaMonAn= @mamonan";
            command.Parameters.AddWithValue("@mamonan", itemID);

            int price = (int)command.ExecuteScalar();

       
            return price;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                int price = GetPriceByItemID(tbmamon.Text);
                tbthanhtien.Text = price.ToString();
                command = connection.CreateCommand();
                command.CommandText = "Insert into donhang values(@madon, @mabill, @mamonan, @soluong, @thanhtien, @trangthai)";
                command.Parameters.AddWithValue("@madon", tbmadon.Text);
                command.Parameters.AddWithValue("@mabill", tbmabill.Text);
                command.Parameters.AddWithValue("@mamonan", tbmamon.Text);
                command.Parameters.AddWithValue("@soluong", tbsoluong.Text);
                command.Parameters.AddWithValue("@thanhtien", price );
                command.Parameters.AddWithValue("@trangthai", tbtrangthai.Text);
                command.ExecuteNonQuery();
                loaddata4();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from donhang where MaDon = @madon";
            command.Parameters.AddWithValue("@madon", tbmadon.Text);
            command.ExecuteNonQuery();
            loaddata4();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tbmadon.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbmabill.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbmamon.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbsoluong.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tbthanhtien.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tbtrangthai.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tbmadon.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbmabill.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbmamon.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbsoluong.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tbthanhtien.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tbtrangthai.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }
        string currentTableType;
        private void btnban1_Click(object sender, EventArgs e)
        {
            currentTableType = "hoadon1";
            loaddata3();
            UpdateTotalPrice();
        }

        private void btnban2_Click(object sender, EventArgs e)
        {
            currentTableType = "hoadon2";
            loaddata6();
            UpdateTotalPrice();
        }

        private void btnthem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgv5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv5.CurrentRow.Index;
            string MaMonAn0= dgv5.Rows[i].Cells[0].Value.ToString();
            string Gia0= dgv5.Rows[i].Cells[2].Value.ToString();
            int Gia1;
            int.TryParse(Gia0, out Gia1);


            if (currentTableType == "hoadon1")
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into hoadon1 values(@mamonan, @gia )";
                command.Parameters.AddWithValue("@mamonan", MaMonAn0);
                command.Parameters.AddWithValue("@gia", Gia1);
                command.ExecuteNonQuery();
                loaddata3();
                UpdateTotalPrice();
            }
            else if (currentTableType == "hoadon2")
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into hoadon2 values(@mamonan, @gia )";
                command.Parameters.AddWithValue("@mamonan", MaMonAn0);
                command.Parameters.AddWithValue("@gia", Gia1);
                command.ExecuteNonQuery();
                loaddata6();
                UpdateTotalPrice();
            }
            else if (currentTableType == "hoadon3")
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into hoadon3 values(@mamonan, @gia )";
                command.Parameters.AddWithValue("@mamonan", MaMonAn0);
                command.Parameters.AddWithValue("@gia", Gia1);
                command.ExecuteNonQuery();
                loaddata7();
                UpdateTotalPrice();
            }
            else if (currentTableType == "hoadon4")
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into hoadon4 values(@mamonan, @gia )";
                command.Parameters.AddWithValue("@mamonan", MaMonAn0);
                command.Parameters.AddWithValue("@gia", Gia1);
                command.ExecuteNonQuery();
                loaddata8();
                UpdateTotalPrice();
            }
            else if (currentTableType == "hoadon5")
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into hoadon5 values(@mamonan, @gia )";
                command.Parameters.AddWithValue("@mamonan", MaMonAn0);
                command.Parameters.AddWithValue("@gia", Gia1);
                command.ExecuteNonQuery();
                loaddata9();
                UpdateTotalPrice();
            }
            else if (currentTableType == "hoadon6")
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into hoadon6 values(@mamonan, @gia )";
                command.Parameters.AddWithValue("@mamonan", MaMonAn0);
                command.Parameters.AddWithValue("@gia", Gia1);
                command.ExecuteNonQuery();
                loaddata10();
                UpdateTotalPrice();
            }


        }

        private void dgv4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv4.CurrentRow.Index;

            string id2 = dgv4.Rows[i].Cells[0].Value.ToString();
            int.TryParse(id2, out id1);

        }
        int id1;

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            if (currentTableType == "hoadon1")
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hoadon1\r\nWHERE id = @id";
                command.Parameters.AddWithValue("@id", id1);
                command.ExecuteNonQuery();
                loaddata3();
            }
            else if (currentTableType == "hoadon2")
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hoadon2\r\nWHERE id = @id";
                command.Parameters.AddWithValue("@id", id1);
                command.ExecuteNonQuery();
                loaddata6();
            }
            else if (currentTableType == "hoadon3")
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hoadon3\r\nWHERE id = @id";
                command.Parameters.AddWithValue("@id", id1);
                command.ExecuteNonQuery();
                loaddata7();
            }
            else if (currentTableType == "hoadon4")
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hoadon4\r\nWHERE id = @id";
                command.Parameters.AddWithValue("@id", id1);
                command.ExecuteNonQuery();
                loaddata8();
            }
            else if (currentTableType == "hoadon5")
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hoadon5\r\nWHERE id = @id";
                command.Parameters.AddWithValue("@id", id1);
                command.ExecuteNonQuery();
                loaddata9();
            }
            else if (currentTableType == "hoadon6")
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hoadon6\r\nWHERE id = @id";
                command.Parameters.AddWithValue("@id", id1);
                command.ExecuteNonQuery();
                loaddata10();
            }

            UpdateTotalPrice();
        }

        private void btnban3_Click(object sender, EventArgs e)
        {
            currentTableType = "hoadon3";
            loaddata7();
            UpdateTotalPrice();
        }
        private bool Checkgia()
        {
            // Kiểm tra kiểu dữ liệu của giá
            if (int.TryParse(tbgiamon.Text, out int giamon1))
            {
                // Dữ liệu là số nguyên
                return true;
            }
            else
            {

                return false;
            }
        }
        private bool checkmamon()
        {
            // Kiểm tra kiểu dữ liệu của mã món
            if (int.TryParse(tbmamonan.Text, out int ktradauvao1))
            {
                // Dữ liệu là số nguyên
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra kiểu dữ liệu cho giá và mã món
                if (!Checkgia() || !checkmamon())
                {
                   
                    // Nếu kiểm tra kiểu dữ liệu không thành công, hiển thị thông báo lỗi
                    MessageBox.Show("Vui lòng kiểm tra lại giá và mã món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (!Checktemmon())
                {

                    // Nếu kiểm tra kiểu dữ liệu không thành công, hiển thị thông báo lỗi
                    MessageBox.Show("Vui lòng không để tên món ăn trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                // Kiểm tra xem mã món ăn đã tồn tại hay chưa
                if (IsMaMonAnExists(tbmamonan.Text))
                {
                    MessageBox.Show("Mã món ăn đã tồn tại. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không trùng, thực hiện thêm món ăn vào cơ sở dữ liệu
                command = connection.CreateCommand();
                command.CommandText = "Insert into monan values(@MaMonAn, @TenMonAn, @Gia)";
                command.Parameters.AddWithValue("@MaMonAn", tbmamonan.Text);
                command.Parameters.AddWithValue("@TenMonAn", tbtenmon.Text);
                command.Parameters.AddWithValue("@Gia", tbgiamon.Text);
                command.ExecuteNonQuery();
                tbmamonan.Text = "";
                tbtenmon.Text = "";
                tbgiamon.Text = "";
                // Load lại dữ liệu
                loaddata();
                loaddata5();
                MessageBox.Show("bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnsuamon_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra kiểu dữ liệu cho giá và mã món
                if (!Checkgia())
                {
                    
                    // Nếu kiểm tra kiểu dữ liệu không thành công, hiển thị thông báo lỗi
                    MessageBox.Show("Vui lòng nhập giá là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (!Checktemmon())
                {

                    // Nếu kiểm tra kiểu dữ liệu không thành công, hiển thị thông báo lỗi
                    MessageBox.Show("Vui lòng không để tên món ăn trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                command = connection.CreateCommand();
                command.CommandText = "update monan set MaMonAn= @mamonan,TenMonAn=@tenmonan,Gia= @gia where MaMonAn= @mamonan";
                command.Parameters.AddWithValue("@mamonan", tbmamonan.Text);
                command.Parameters.AddWithValue("@tenmonan", tbtenmon.Text);
                command.Parameters.AddWithValue("@gia", tbgiamon.Text);
                command.ExecuteNonQuery();
                loaddata();
                tbmamonan.Text = "";
                tbtenmon.Text = "";
                tbgiamon.Text = "";
                MessageBox.Show("bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnxoamon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

            // Kiểm tra xem người dùng đã ấn OK hay không
            if (result == DialogResult.OK)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from monan where MaMonAn = @mamonan";
                command.Parameters.AddWithValue("@mamonan", tbmamonan.Text);
                command.ExecuteNonQuery();
                loaddata();
                tbmamonan.Text = "";
                tbtenmon.Text = "";
                tbgiamon.Text = "";
            }

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgv1.CurrentRow.Index;
            tbmamonan.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tbtenmon.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            tbgiamon.Text = dgv1.Rows[i].Cells[2].Value.ToString();
        }

        private void btntimkiemmon_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from monan where TenMonAn like '%" + tbtimkiemmon.Text + "%' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv1.DataSource = table;
        }

        private void btnhienthimon_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void tbtimkiemmon_TextChanged(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from monan where TenMonAn like '%" + tbtimkiemmon.Text + "%' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv1.DataSource = table;
        }
        private int CalculateTotalPrice()
        {
            int totalPrice = 0; // Khởi tạo giá trị mặc định

            if (currentTableType == "hoadon1")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT SUM(ISNULL(Gia, 0)) FROM hoadon1";
            }
            else if (currentTableType == "hoadon2")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT SUM(ISNULL(Gia, 0)) FROM hoadon2";
            }
            else if (currentTableType == "hoadon3")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT SUM(ISNULL(Gia, 0)) FROM hoadon3";
            }
            else if (currentTableType == "hoadon4")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT SUM(ISNULL(Gia, 0)) FROM hoadon4";
            }
            else if (currentTableType == "hoadon5")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT SUM(ISNULL(Gia, 0)) FROM hoadon5";
            }
            else if (currentTableType == "hoadon6")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT SUM(ISNULL(Gia, 0)) FROM hoadon6";
            }
            else
            {
                return totalPrice; // Trả về giá trị mặc định nếu không phải các loại trên
            }

            // ExecuteScalar returns null if there are no records or the result is null
            object result = command.ExecuteScalar();

            // If the result is not null, parse the result
            if (result != null && result != DBNull.Value)
            {
                totalPrice = Convert.ToInt32(result);
            }

            return totalPrice;


        }
        private void UpdateTotalPrice()
        {
            int totalPrice = CalculateTotalPrice();
            tbtongtien.Text = totalPrice.ToString();
        }

        private void btnban4_Click(object sender, EventArgs e)
        {
            currentTableType = "hoadon4";
            loaddata8();
            UpdateTotalPrice();
        }

        private void btnban5_Click(object sender, EventArgs e)
        {
            currentTableType = "hoadon5";
            loaddata9();
            UpdateTotalPrice();
        }

        private void btnban6_Click(object sender, EventArgs e)
        {
            currentTableType = "hoadon6";
            loaddata10();
            UpdateTotalPrice();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnQLkhohang_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void dgv6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void dgv6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv6.CurrentRow.Index;
            tbmahh.Text = dgv6.Rows[i].Cells[0].Value.ToString();
            tbtenhh.Text = dgv6.Rows[i].Cells[1].Value.ToString();
            tbsoluonghh.Text = dgv6.Rows[i].Cells[2].Value.ToString();
            tbgiahh.Text = dgv6.Rows[i].Cells[3].Value.ToString();
            tbthanhtienhh.Text = dgv6.Rows[i].Cells[4].Value.ToString();
        }

        private void btnnhapkho_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into khohang values(@mahanghoa,@tenhanghoa, @soluong, @gia, @thanhtien )";
            command.Parameters.AddWithValue("@mahanghoa", tbmahh.Text);
            command.Parameters.AddWithValue("@tenhanghoa", tbtenhh.Text);
            command.Parameters.AddWithValue("@soluong", tbsoluonghh.Text);
            command.Parameters.AddWithValue("@gia", tbgiahh.Text);
            command.Parameters.AddWithValue("@thanhtien", tbthanhtienhh.Text);
            command.ExecuteNonQuery();
            loaddata11();
        }

        private void btnxuatkho_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from khohang where MaHangHoa = @mahanghoa";
            command.Parameters.AddWithValue("@mahanghoa", tbmahh.Text);
            command.ExecuteNonQuery();
            loaddata11();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbinput.Text, out int inputValue))
            {
                int factor = 1;
                if (cbtien.SelectedItem != null)
                {
                    if (cbtien.SelectedItem.ToString() == "USD")
                    {
                        factor = 24250;
                    }
                    else if (cbtien.SelectedItem.ToString() == "GBP")
                    {
                        factor = 30790;
                    }
                    else if (cbtien.SelectedItem.ToString() == "KRW")
                    {
                        factor = 18612;
                    }
                    else if (cbtien.SelectedItem.ToString() == "JPY")
                    {
                        factor = 17024;
                    }
                }

                int result = inputValue * factor;
                tboutput.Text = result.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void btnthemhv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into hoivien values(@SDT,@Email, @HoTenHv,@id)";
            command.Parameters.AddWithValue("@SDT", tbsdthv.Text);
            command.Parameters.AddWithValue("@Email", tbemail.Text);
            command.Parameters.AddWithValue("@HoTenHv", tbhotenhv.Text);
            command.Parameters.AddWithValue("@id", tbIDHv.Text);
            command.ExecuteNonQuery();
            loaddata12();
        }

        private void dgv7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv7.CurrentRow.Index;
            tbsdthv.Text = dgv7.Rows[i].Cells[0].Value.ToString();
            tbemail.Text = dgv7.Rows[i].Cells[1].Value.ToString();
            tbhotenhv.Text = dgv7.Rows[i].Cells[2].Value.ToString();
            tbIDHv.Text = dgv7.Rows[i].Cells[3].Value.ToString();
        }

        private void btnxoahv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from hoivien where SDT = @SDT";
            command.Parameters.AddWithValue("@SDT", tbsdthv.Text);
            command.ExecuteNonQuery();
            loaddata12();
        }


        private void btnsuahv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE hoivien SET   SDT = @SDT,Email = @Email, HoTenHv = @HoTenHv WHERE IDHv = @IDHv ";
            command.Parameters.AddWithValue("@Email", tbemail.Text);
            command.Parameters.AddWithValue("@HoTenHv", tbhotenhv.Text);
            command.Parameters.AddWithValue("@SDT", tbsdthv.Text);
            command.Parameters.AddWithValue("@IDHv", tbIDHv.Text);
            command.ExecuteNonQuery();
            loaddata12();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
        private bool IsMaNhanVienExists(string maNhanVien)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT n (*) FROM nhanvien WHERE MaNV = @maNV";
            command.Parameters.AddWithValue("@maNV", maNhanVien);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }
        private void btnthem1_Click_1(object sender, EventArgs e)
        {
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tbmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbtennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdoanhthu_Click(object sender, EventArgs e)
        {

        }


        private bool IsMaMonAnExists(string maMonAn)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM monan WHERE MaMonAn = @maMonAn";
            command.Parameters.AddWithValue("@maMonAn", maMonAn);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }
        private void btban1_Click(object sender, EventArgs e)
        {
           
        }

        private void btban2_Click(object sender, EventArgs e)
        {
            
        }

        private void btban3_Click(object sender, EventArgs e)
        {
            
        }

        private void btban4_Click(object sender, EventArgs e)
        {
            
        }

        private void btban5_Click(object sender, EventArgs e)
        {
           
        }

        private void btban6_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fdattruoc f = new fdattruoc();
            f.ShowDialog();
        }

        private bool IsNhanVienExists(string MaNV)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM luong WHERE MaNV = @MaNV";
            command.Parameters.AddWithValue("@MaNV", MaNV);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }
        private bool Checkngaycong()
        {
            // Kiểm tra kiểu dữ liệu của giá
            if (int.TryParse(tbngaycong1.Text, out int kieudulieungaycong))
            {
                // Dữ liệu là số nguyên
                return true;
            }
            else
            {

                return false;
            }
        }
        private bool KiemTraLuong(System.Windows.Forms.TextBox tbmanv1, System.Windows.Forms.TextBox tbtennv1, System.Windows.Forms.ComboBox cbchucvu1)
        {
            // Kiểm tra xem tất cả các TextBox có dữ liệu hay không
            return tbmanv1.Text.Trim().Length > 0
                && tbtennv1.Text.Trim().Length > 0
                && cbchucvu1.Text.Trim().Length > 0;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (!KiemTraLuong(tbmanv1, tbtennv1, cbchucvu1 ))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cho tất cả các ô nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (IsNhanVienExists(tbmanv1.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Checkngaycong())
                {
                    MessageBox.Show(" Vui lòng nhập ngày công là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không trùng, thực hiện thêm món ăn vào cơ sở dữ liệu
                command = connection.CreateCommand();
                command.CommandText = "Insert into luong values(@MaNV, @TenNV, @chucvu,@ngaycong,@tiencongngay,@thuong,@tongluong)";
                command.Parameters.AddWithValue("@MaNV", tbmanv1.Text);
                command.Parameters.AddWithValue("@TenNV", tbtennv1.Text);
                command.Parameters.AddWithValue("@chucvu", cbchucvu1.Text);
                command.Parameters.AddWithValue("@ngaycong", tbngaycong1.Text);
                command.Parameters.AddWithValue("@tiencongngay", tbluongngay1.Text);
                command.Parameters.AddWithValue("@thuong", tbthuong1.Text);
                command.Parameters.AddWithValue("@tongluong", tbtongluong1.Text);
                command.ExecuteNonQuery();
                tbmanv1.Text = "";
                tbtennv1.Text = "";
                cbchucvu1.Text = "";
                tbngaycong1.Text = "";
                tbluongngay1.Text = "";
                tbthuong1.Text = "";
                tbtongluong1.Text = "";

                // Load lại dữ liệu
                loaddata13();
                MessageBox.Show("bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

            // Kiểm tra xem người dùng đã ấn OK hay không
            if (result == DialogResult.OK)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from luong where MaNV = @MaNV";
                command.Parameters.AddWithValue("@MaNV", tbmanv1.Text);
                command.ExecuteNonQuery();
                loaddata13();
                tbmanv1.Text = "";
                tbtennv1.Text = "";
                cbchucvu1.Text = "";
                tbngaycong1.Text = "";
                tbluongngay1.Text = "";
                tbthuong1.Text = "";
                tbtongluong1.Text = "";
            }

        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgv3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv11_Click(object sender, EventArgs e)
        {

        }

        private void dgv11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv11.CurrentRow.Index;
            tbmanv1.Text = dgv11.Rows[i].Cells[0].Value.ToString();
            tbtennv1.Text = dgv11.Rows[i].Cells[1].Value.ToString();
            cbchucvu1.Text = dgv11.Rows[i].Cells[2].Value.ToString();
            tbngaycong1.Text = dgv11.Rows[i].Cells[3].Value.ToString();
            tbluongngay1.Text = dgv11.Rows[i].Cells[4].Value.ToString();
            tbthuong1.Text = dgv11.Rows[i].Cells[5].Value.ToString();
            tbtongluong1.Text = dgv11.Rows[i].Cells[6].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btsualuong_Click(object sender, EventArgs e)

        {
            if (!Checkngaycong())
            {
                MessageBox.Show(" Vui lòng nhập ngày công là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!KiemTraLuong(tbmanv1, tbtennv1, cbchucvu1))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cho tất cả các ô nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "update luong set MaNV= @MaNV,TenNV=@TenNV,ChucVu= @ChucVu,NgayCong=@NgayCong,TienCongNgay=@TienCongNgay,Thuong=@Thuong,TongLuong=@TongLuong where MaNV= @MaNV";
            command.Parameters.AddWithValue("@MaNV", tbmanv1.Text);
            command.Parameters.AddWithValue("@TenNV", tbtennv1.Text);
            command.Parameters.AddWithValue("@ChucVu", cbchucvu1.Text);
            command.Parameters.AddWithValue("@NgayCong", tbngaycong1.Text);
            command.Parameters.AddWithValue("@TienCongNgay", tbluongngay1.Text);
            command.Parameters.AddWithValue("@Thuong", tbthuong1.Text);
            command.Parameters.AddWithValue("@TongLuong", tbtongluong1.Text);
            command.ExecuteNonQuery();
            loaddata13();
            tbmanv1.Text = "";
            tbtennv1.Text = "";
            cbchucvu1.Text = "";
            tbngaycong1.Text = "";
            tbluongngay1.Text = "";
            tbthuong1.Text = "";
            tbtongluong1.Text = "";
        
            MessageBox.Show("bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
            return;

        }

        private void bttimluong_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter13 = new SqlDataAdapter();
            DataTable table13 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from luong where TenNV like '%" + tbtimkiemluong.Text + "%' ";
            adapter13.SelectCommand = command;
            table13.Clear();
            adapter13.Fill(table13);
            dgv11.DataSource = table13;
        }

        private void dgv3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttimluong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bthienthiluong_Click(object sender, EventArgs e)
        {
            loaddata13();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void tbtimkiemluong_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter13 = new SqlDataAdapter();
            DataTable table13 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from luong where TenNV like '%" + tbtimkiemluong.Text + "%' ";
            adapter13.SelectCommand = command;
            table13.Clear();
            adapter13.Fill(table13);
            dgv11.DataSource = table13;
        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }
        private bool IsNhanSuExists(string MaNV)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM thongtinns WHERE MaNV = @MaNV";
            command.Parameters.AddWithValue("@MaNV", MaNV);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }
        private bool Checkttsdt()
        {
            // Kiểm tra kiểu dữ liệu của giá
            if (lengthttsdt == 10)
            {
                // Dữ liệu là số nguyên
                return true;
            }
            else
            {

                return false;
            }
        }
        private bool KiemTraTTNV(System.Windows.Forms.TextBox tbttmanv, System.Windows.Forms.TextBox tbtttennv, System.Windows.Forms.TextBox tbttquequan, System.Windows.Forms.ComboBox cbttgioitinh)
        {
            // Kiểm tra xem tất cả các TextBox có dữ liệu hay không
            return tbttmanv.Text.Trim().Length > 0
                && tbtttennv.Text.Trim().Length > 0
                && tbttquequan.Text.Trim().Length > 0
                && cbttgioitinh.Text.Trim().Length > 0;       
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!KiemTraTTNV(tbttmanv, tbtttennv, tbttquequan, cbttgioitinh))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cho tất cả các ô nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DinhDangEmail(tbttemail.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (IsNhanSuExists(tbttmanv.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Checkttsdt())
                {
                    MessageBox.Show("Số điện thoại không hợp lệ vui lòng nhập đủ 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                command = connection.CreateCommand();
                command.CommandText = "Insert into thongtinns values(@MaNV, @TenNV, @quequan,@gioitinh,@sdt,@email,@namsinh)";
                command.Parameters.AddWithValue("@MaNV", tbttmanv.Text);
                command.Parameters.AddWithValue("@TenNV", tbtttennv.Text);
                command.Parameters.AddWithValue("@quequan", tbttquequan.Text);
                command.Parameters.AddWithValue("@gioitinh", cbttgioitinh.Text);
                command.Parameters.AddWithValue("@sdt", tbttsdt.Text);
                command.Parameters.AddWithValue("@email", tbttemail.Text);
                command.Parameters.AddWithValue("@namsinh", dtttnamsinh.Value);
                command.ExecuteNonQuery();
                tbttmanv.Text = "";
                tbtttennv.Text = "";
                tbttquequan.Text = "";
                cbttgioitinh.Text = "";
                tbttsdt.Text = "";
                tbttemail.Text = "";
                dtttnamsinh.Value = DateTime.Today;

                // Load lại dữ liệu
                loaddata2();
                MessageBox.Show("bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnxoatt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

            // Kiểm tra xem người dùng đã ấn OK hay không
            if (result == DialogResult.OK)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from thongtinns where MaNV = @MaNV";
                command.Parameters.AddWithValue("@MaNV", tbttmanv.Text);
                command.ExecuteNonQuery();
                loaddata2();
                tbttmanv.Text = "";
                tbtttennv.Text = "";
                tbttquequan.Text = "";
                cbttgioitinh.Text = "";
                tbttemail.Text = "";
                tbttsdt.Text = "";
                tbttsdt.Text = "";
                dtttnamsinh.Value = DateTime.Today;
            }

        }

        private void dgv12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv12.CurrentRow.Index;
            tbttmanv.Text = dgv12.Rows[i].Cells[0].Value.ToString();
            tbtttennv.Text = dgv12.Rows[i].Cells[1].Value.ToString();
            tbttquequan.Text = dgv12.Rows[i].Cells[2].Value.ToString();
            cbttgioitinh.Text = dgv12.Rows[i].Cells[3].Value.ToString();
            tbttsdt.Text = dgv12.Rows[i].Cells[4].Value.ToString();
            tbttemail.Text = dgv12.Rows[i].Cells[5].Value.ToString();
            dtttnamsinh.Text = dgv12.Rows[i].Cells[6].Value.ToString();
        }

        private void btnsuatt_Click(object sender, EventArgs e)
        {
            if (!Checkttsdt())
            {
                MessageBox.Show("Số điện thoại không hợp lệ vui lòng nhập đủ 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DinhDangEmail(tbttemail.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            {
                if (!KiemTraTTNV(tbttmanv, tbtttennv, tbttquequan, cbttgioitinh))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin cho tất cả các ô nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "update thongtinns set MaNV= @MaNV,TenNV=@TenNV,QueQuan= @quequan,GioiTinh=@gioitinh,SDT=@sdt,Email=@email,NamSinh=@namsinh where MaNV= @MaNV";
                command.Parameters.AddWithValue("@MaNV", tbttmanv.Text);
                command.Parameters.AddWithValue("@TenNV", tbtttennv.Text);
                command.Parameters.AddWithValue("@quequan", tbttquequan.Text);
                command.Parameters.AddWithValue("@gioitinh", cbttgioitinh.Text);
                command.Parameters.AddWithValue("@sdt", tbttsdt.Text);
                command.Parameters.AddWithValue("@email", tbttemail.Text);
                command.Parameters.AddWithValue("@namsinh", dtttnamsinh.Value);
                command.ExecuteNonQuery();
                loaddata2();
                tbttmanv.Text = "";
                tbtttennv.Text = "";
                tbttquequan.Text = "";
                cbttgioitinh.Text = "";
                tbttsdt.Text = "";
                tbttemail.Text = "";
                dtttnamsinh.Value = DateTime.Today;
                MessageBox.Show("bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                return;

            }
        }

        private void btnhienthitt_Click(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void tbtimkiemtt_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            DataTable table2 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from thongtinns where TenNV like '%" + tbtimkiemtt.Text + "%' ";
            adapter2.SelectCommand = command;
            table2.Clear();
            adapter2.Fill(table2);
            dgv12.DataSource = table2;
        }

        private void btntimkiemtt_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            DataTable table2 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select * from thongtinns where TenNV like '%" + tbtimkiemtt.Text + "%' ";
            adapter2.SelectCommand = command;
            table2.Clear();
            adapter2.Fill(table2);
            dgv12.DataSource = table2;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (LoaiBan == "ban1") {
                btban1.BackColor = Color.Green;
            }
            else if (LoaiBan == "ban2") {
                btban2.BackColor = Color.Green;
            }
            else if (LoaiBan == "ban3") {
                btban3.BackColor = Color.Green;
            }
            else if (LoaiBan == "ban4") {
                btban4.BackColor = Color.Green;
            }
            else if (LoaiBan == "ban5") {
                btban5.BackColor = Color.Green;
            }
            else if (LoaiBan == "ban6") {
                btban6.BackColor = Color.Green;
            }
            else {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo.", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (LoaiBan == "ban1")
            {
                btban1.BackColor = Color.White;
            }
            else if (LoaiBan == "ban2") {
                btban2.BackColor = Color.White;
            }
            else if (LoaiBan == "ban3") {
                btban3.BackColor = Color.White;
            }
            else if (LoaiBan == "ban4") {
                btban4.BackColor = Color.White;
            }
            else if (LoaiBan == "ban5") {
                btban5.BackColor = Color.White;
            }
            else if (LoaiBan == "ban6") {
                btban6.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Thông báo.", MessageBoxButtons.OK);
                return;
            }

        }
        string LoaiBan = "";
        private void btban1_Click_1(object sender, EventArgs e)
        {
            LoaiBan = "ban1";
        }

        private void btban2_Click_1(object sender, EventArgs e)
        {
            LoaiBan = "ban2";
        }

        private void btban3_Click_1(object sender, EventArgs e)
        {
            LoaiBan = "ban3";
        }

        private void btban4_Click_1(object sender, EventArgs e)
        {
            LoaiBan = "ban4";
        }

        private void btban5_Click_1(object sender, EventArgs e)
        {
            LoaiBan = "ban5";
        }

        private void btban6_Click_1(object sender, EventArgs e)
        {
            LoaiBan = "ban6";
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
        int sdt;
        private void dgv13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv13.CurrentRow.Index;
            string sdt1 = dgv13.Rows[i].Cells[1].Value.ToString();
            int.TryParse(sdt1, out sdt);
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata14();
        }

       
        int luongngay=0;
        int tienthuong=0;
        int ngaycong3=0;
        int tongluong = 0;
        
        private void tbngaycong1_TextChanged(object sender, EventArgs e)
        {   
            string ngaycong = tbngaycong1.Text;
            int ngaycong1;
            int.TryParse( ngaycong, out ngaycong1);
            ngaycong3 = ngaycong1;
            if (ngaycong1 >26) {
                tbthuong1.Text = "100000";
                int.TryParse(tbthuong1.Text, out tienthuong);
            }
            else
            {
                tbthuong1.Text = "0";
                int.TryParse(tbthuong1.Text, out tienthuong);
            }
            tongluong = ngaycong3 * luongngay + tienthuong;

            tbtongluong1.Text = tongluong.ToString();

        }
       
        private void cbchucvu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbchucvu1.Text == "Nhân Viên") {
                tbluongngay1.Text = "150000";
                int.TryParse(tbluongngay1.Text, out luongngay);
            }
            else if (cbchucvu1.Text == "Quản Lí")
            {
                tbluongngay1.Text = "250000";
                int.TryParse(tbluongngay1.Text, out luongngay);
            }
            else if (cbchucvu1.Text == "Đầu Bếp")
            {
                tbluongngay1.Text = "300000";
                int.TryParse(tbluongngay1.Text, out luongngay);
            }
            else if (cbchucvu1.Text == "Phụ Bếp")
            {
                tbluongngay1.Text = "150000";
                int.TryParse(tbluongngay1.Text, out luongngay);
            }
            tongluong = ngaycong3 * luongngay + tienthuong;

            tbtongluong1.Text = tongluong.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

            // Kiểm tra xem người dùng đã ấn OK hay không
            if (result == DialogResult.OK)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from dattruoc where SDT = @sdt";
                command.Parameters.AddWithValue("@sdt", sdt);
                command.ExecuteNonQuery();
                loaddata14();

                return;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void cbchucvu1_TextChanged(object sender, EventArgs e)
        {

        }
        int lengthttsdt;
        private void tbttsdt_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string userInput = tbttsdt.Text;

            // Kiểm tra độ dài
            lengthttsdt = userInput.Length;
        }
        public bool DinhDangEmail(string email)
        {
            return email.Contains("@gmail.com");
        }

        private void tbttemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbchucvu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbttgioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        int lengthtenmon;
        private void tbtenmon_TextChanged(object sender, EventArgs e)
        {
  
                // Lấy giá trị từ TextBox
                string userInput = tbtenmon.Text;

                // Kiểm tra độ dài
                lengthtenmon = userInput.Length;

        }
        private bool Checktemmon()
        {
            // Kiểm tra kiểu dữ liệu của giá
            if (lengthtenmon > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dtttnamsinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
