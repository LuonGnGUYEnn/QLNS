using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhân_Sự
{
    public partial class fPhongBan : Form
    {
        DataBase dtbase = new DataBase();
        string sql = "";
        public fPhongBan()
        {
            InitializeComponent();
        }
        private void fPhongBan_Load(object sender, EventArgs e)
        {
            dgvPb.DataSource = dtbase.DataReader("select * from phongban");
        }




        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPb_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaPb.Text = dgvPb.CurrentRow.Cells[0].Value.ToString();
                txtTenPb.Text = dgvPb.CurrentRow.Cells[1].Value.ToString();
                txtSdt.Text = dgvPb.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            { }
        }

        private void dgvPb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void XoaDanhSachNV()
        {
            txtMaPb.Text = "";
            txtTenPb.Text = "";
            txtSdt.Text = "";

        }




        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Enabled == true)
            {
                sql = "Delete From PhongBan Where MaPB =N'" + txtMaPb.Text + "'";
            }
            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from PhongBan";
            dgvPb.DataSource = dtbase.DataReader(sql);
            //Ẩn hiện các nút phù hợp chức năng
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            XoaDanhSachNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPb.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMaPb, "Bạn không để trống Mã phòng ban trong trường này!");
                return;
            }
            else
            {
                sql = "Select * From PhongBan Where MaPB ='" + txtMaPb.Text + "'";
                DataTable dtSP = dtbase.DataReader(sql);
                if (dtSP.Rows.Count > 0)
                {
                    errChiTiet.SetError(txtMaPb, "Mã PB đã được sử dụng");
                    return;
                }
                errChiTiet.Clear();
            }


            if (txtTenPb.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenPb, "Bạn không để trống Tên phòng ban trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtSdt.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSdt, "Bạn không để trống  Số điện thoại trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }


            sql = "INSERT INTO PhongBan(MaPB,TenPB,DienThoai) " + "VALUES("; sql += "'" + txtMaPb.Text + "',    N'" + txtTenPb.Text + "',  '" + txtSdt.Text + "' )";
            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from PhongBan";
            dgvPb.DataSource = dtbase.DataReader(sql);
            XoaDanhSachNV();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Enabled == true)
            {
                sql = "Update PhongBan SET ";
                sql += "TenPB = N'" + txtTenPb.Text + "',";
                sql += "DienThoai = '" + txtSdt.Text + "'";

                sql += "Where MaPB = N'" + txtMaPb.Text + "'";
            }


            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from PhongBan";
            dgvPb.DataSource = dtbase.DataReader(sql);
            //Ẩn hiện các nút phù hợp chức năng

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            XoaDanhSachNV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPb.DataSource = dtbase.DataReader("select * from sonhanvien('" + txtMaPb.Text + "')");
        }

    }
}
