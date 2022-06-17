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
    public partial class fQuaTrinhCongTac : Form
    {
        DataBase dtbase = new DataBase();
        string sql = "";
        public fQuaTrinhCongTac()
        {
            InitializeComponent();
        }

        private void dgvQTCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fQuaTrinhCongTac_Load(object sender, EventArgs e)
        {
            dgvQTCT.DataSource = dtbase.DataReader("Select * from QTCT");
            btnSua.Enabled = false;
        }

        private void dgvQTCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvQTCT.CurrentRow.Cells[0].Value.ToString();
                txtMaQTCT.Text = dgvQTCT.CurrentRow.Cells[1].Value.ToString();
                dtpTuNgay.Text = dgvQTCT.CurrentRow.Cells[2].Value.ToString();
                dtpDenNgay.Text = dgvQTCT.CurrentRow.Cells[3].Value.ToString();
              


            }
            catch (Exception ex)
            { }
            btnSua.Enabled = true;
        }

        private void XoaDanhSachQTCT()
        {
            txtMaNV.Text = "";
            txtMaQTCT.Text = "";
            dtpTuNgay.Text = "";
            dtpDenNgay.Text = "";
            
            
        }


      

       
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0 & txtMaQTCT.Text.Length == 0)
                MessageBox.Show("Bạn phải nhập MaNV hoặc MaQTCT !!", "Thông báo", MessageBoxButtons.OK);
            if (txtMaNV.Text.Length != 0 & txtMaQTCT.Text.Length == 0)
                dgvQTCT.DataSource = dtbase.DataReader("execute proc1  '" + txtMaNV.Text + "'");
            if (txtMaQTCT.Text.Length != 0 & txtMaNV.Text.Length == 0)
                dgvQTCT.DataSource = dtbase.DataReader("execute proc2  '" + txtMaQTCT.Text + "'");
            if (txtMaQTCT.Text.Length != 0 & txtMaNV.Text.Length != 0)
                dgvQTCT.DataSource = dtbase.DataReader("execute proc2  '" + txtMaQTCT.Text + "'");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (btnSua.Enabled == true)
            {
                sql = "Update QTCT SET ";

                sql += "TuNgay = '" + dtpTuNgay.Text + "',";
                sql += "DenNgay = '" + dtpDenNgay.Text + "'";

                sql += "Where MaNV = N'" + txtMaNV.Text + "'";
            }


            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from QTCT";
            dgvQTCT.DataSource = dtbase.DataReader(sql);
            //Ẩn hiện các nút phù hợp chức năng

            btnSua.Enabled = true;

            XoaDanhSachQTCT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvQTCT.DataSource = dtbase.DataReader("Select * from QTCT");
            XoaDanhSachQTCT();
        }
    }
}


