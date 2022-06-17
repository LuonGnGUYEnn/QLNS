using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quản_Lý_Nhân_Sự
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }

        
        
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TUR6R90\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTenDangNhap.Text;
                string mk = txtMk.Text;
                string sql = "select * from DangNhap where TenDangNhap= '" + tk + "'and MatKhau= '" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    QuanLyNhanSu f = new QuanLyNhanSu();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();

                }
                else 
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }


        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
                this.Close();
        }
    }
}
