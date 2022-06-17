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
    public partial class fChucVu : Form
    {
        DataBase dtbase = new DataBase();
        string sql = "";

        public fChucVu()
        {
            InitializeComponent();
        }

        private void fChucVu_Load(object sender, EventArgs e)
        {
            dgvCV.DataSource = dtbase.DataReader("Select * from ChucVu");
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dgvCV.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dgvCV.CurrentRow.Cells[1].Value.ToString();
                

            }
            catch (Exception ex)
            { }
        }

        private void dgvCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void XoaDanhSachCV()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }
        

    }
}

