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
    public partial class fHoSoNV : Form
    {
        DataBase dtbase = new DataBase();
        string sql = "";
        public fHoSoNV()
        {
            InitializeComponent();
        }

       

        private void fHoSoNV_Load(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = dtbase.DataReader("Select * from HoSoNV");
            //Ẩn nút Sửa,xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
           
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaNV.Text = dgvDSNV.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvDSNV.CurrentRow.Cells[1].Value.ToString();
                cbGT.Text = dgvDSNV.CurrentRow.Cells[2].Value.ToString();
                cbCV.Text = dgvDSNV.CurrentRow.Cells[10].Value.ToString();
                cbDT.Text = dgvDSNV.CurrentRow.Cells[6].Value.ToString();
                cbTG.Text = dgvDSNV.CurrentRow.Cells[7].Value.ToString();
                dtpNS.Value = (DateTime)dgvDSNV.CurrentRow.Cells[3].Value;
                txtQuequan.Text = dgvDSNV.CurrentRow.Cells[5].Value.ToString();
                txtDC.Text = dgvDSNV.CurrentRow.Cells[4].Value.ToString();
                txtDT.Text = dgvDSNV.CurrentRow.Cells[9].Value.ToString();
                txtCMND.Text = dgvDSNV.CurrentRow.Cells[8].Value.ToString();
                cbPB.Text = dgvDSNV.CurrentRow.Cells[11].Value.ToString();
                
            }
            catch (Exception ex)
            { }
        }

        private void XoaDanhSachNV()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cbGT.Text = "";
            cbCV.Text = "";
            cbDT.Text = "";
            cbTG.Text = "";
            dtpNS.Text = "";
            txtQuequan.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtCMND.Text = "";
            cbPB.Text = "";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMaNV, "Bạn không để trống MaNV trường này!");
                return;
            }
            else
            { 
                sql = "Select * From HoSoNV Where MaNV ='" + txtMaNV.Text + "'";
                DataTable dtSP = dtbase.DataReader(sql);
                if (dtSP.Rows.Count > 0)
                {
                    errChiTiet.SetError(txtMaNV, "Mã NV trùng trong cơ sở dữ liệu");
                    return;
                }
                errChiTiet.Clear();
            }


            if (txtHoTen.Text.Trim() == "")
            {
                errChiTiet.SetError(txtHoTen, "Bạn không để trống  Họ tên trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (cbGT.Text.Trim() == "")
            {
                errChiTiet.SetError(cbGT, "Bạn không để trống  Giới Tính trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (cbDT.Text.Trim() == "")
            {
                errChiTiet.SetError(cbDT, "Bạn không để trống  Dân tộc trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (cbTG.Text.Trim() == "")
            {
                errChiTiet.SetError(cbTG, "Bạn không để trống  Tôn giáo trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (dtpNS.Text.Trim() == "")
            {
                errChiTiet.SetError(dtpNS, "Bạn không để trống Ngày Sinh trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtQuequan.Text.Trim() == "")
            {
                errChiTiet.SetError(txtQuequan, "Bạn không để trống  Quê quán trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtDC.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDC, "Bạn không để trống  Địa chỉ trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtDT.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDT, "Bạn không để trống  Số đt trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtCMND.Text.Trim() == "")
            {
                errChiTiet.SetError(txtCMND, "Bạn không để trống CMND trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (cbCV.Text.Trim() == "")
            {
                errChiTiet.SetError(cbCV, "Bạn không để trống Chức vụ trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (cbPB.Text.Trim() == "")
            {
                errChiTiet.SetError(cbPB, "Bạn không để trống Phòng ban trong trường này!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }


           sql = "INSERT INTO HoSoNV(MaNV,HoTen,GioiTinh,DanToc,TonGiao,NgaySinh,QueQuan,DiaChi,DienThoai,SoCMND,MaChucVu,MaPhongBan) " 
                +"VALUES("; sql +=  "N'" + txtMaNV.Text + "',    N'" + txtHoTen.Text + "',N'" + cbGT.Text + "', N'" + cbDT.Text + "' ,N'" + cbTG.Text + "' ,  '" + String.Format("{0:MM/dd/yyyy}", dtpNS.Value.Date) + "' ,N'" + txtQuequan.Text + "',N'" + txtDC.Text + "','" + txtDT.Text + "' ,'" + txtCMND.Text + "','" + cbCV.Text + "','" + cbPB.Text + "' )";
           // sql= "insert into HoSoNV values ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + cbGT.Text + "', N'" + cbDT.Text + "' ,N'" + cbTG.Text + "' ,  '" + String.Format("{0:MM/dd/yyyy}", dtpNS.Value.Date) + "' ,N'" + txtQuequan.Text + "',N'" + txtDC.Text + "','" + txtDT.Text + "' ,'" + txtCMND.Text + "','" + cbCV.Text + "','" + cbPB.Text + "' )";
            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from HoSoNV";
            dgvDSNV.DataSource = dtbase.DataReader(sql);
            XoaDanhSachNV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (btnSua.Enabled == true)
            {
                sql = "Update HoSoNV SET ";
                sql += "HoTen = N'" + txtHoTen.Text + "',";
                sql += "GioiTinh = N'" + cbGT.Text + "',";
                sql += "DanToc = N'" + cbDT.Text + "',";
                sql += "TonGiao = N'" + cbTG.Text + "',";               
                sql += "NgaySinh = N'" + String.Format("{0:MM/dd/yyyy}", dtpNS.Value.Date) + "',";
                sql += "QueQuan = N'" + txtQuequan.Text + "',";
                sql += "DiaChi = N'" + txtDC.Text + "',";
                sql += "DienThoai = N'" + txtDT.Text + "',";
                sql += "SoCMND = N'" + txtCMND.Text + "',";
                sql += "MaChucVu = N'" + cbCV.Text + "',";
                sql += "MaPhongBan = N'" + cbPB.Text + "'";
                sql += "Where MaNV = N'" + txtMaNV.Text + "'";
                
               
            }

           
            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from HoSoNV";
            dgvDSNV.DataSource = dtbase.DataReader(sql);
            //Ẩn hiện các nút phù hợp chức năng

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            XoaDanhSachNV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa Nhân viên có mã là " + txtMaNV.Text + " không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "Delete From HoSoNV Where MaNV =N'" + txtMaNV.Text + "'";

                dtbase.DataChange(sql);
                //Cap nhat lai DataGrid
                sql = "Select * from HoSoNV";
                dgvDSNV.DataSource = dtbase.DataReader(sql);
                //Ẩn hiện các nút phù hợp chức năng
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                XoaDanhSachNV();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

     



            if (txtTKMaNV.Text.Trim() == "" & txtTKTenNV.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải nhập MaNV hoặc TenNV !!", "Thông báo", MessageBoxButtons.OK);
                errChiTiet.SetError(txtTKMaNV, "Bạn cần Mã nhân viên để tìm kiếm !");
                errChiTiet.SetError(txtTKTenNV, "Bạn cần Tên nhân viên để tìm kiếm !");
                return;
            }
            else
            {
                
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                //Viet cau lenh SQL cho tim kiem
                string sql = "SELECT * FROM HoSoNV where MaNV is not null ";
                //Tim theo MaSP khac rong
                if (txtTKMaNV.Text.Trim() != "")
                {
                    sql += " and MaNV like '%" + txtTKMaNV.Text + "%'";
                }
                //kiem tra TenSP
                if (txtTKTenNV.Text.Trim() != "")
                {
                    sql += " AND HoTen like N'%" + txtTKTenNV.Text + "%'";
                }
                //Load dữ liệu tìm được lên dataGridView
                dgvDSNV.DataSource = dtbase.DataReader(sql);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XoaDanhSachNV();

            dgvDSNV.DataSource = dtbase.DataReader("Select * from HoSoNV");
            //Ẩn nút Sửa,xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void cbGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
