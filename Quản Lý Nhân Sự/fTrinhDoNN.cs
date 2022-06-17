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
    public partial class fTrinhDoNN : Form
    {
        DataBase dtbase = new DataBase();
        public fTrinhDoNN()
        {
            InitializeComponent();
        }

        private void fTrinhDoNN_Load(object sender, EventArgs e)
        {
            dgvNN.DataSource = dtbase.DataReader("Select HoTen,TenNN,Xeploai from HoSoNV, NVNN, NgoaiNgu where HoSoNV.MaNV = NVNN.MaNV and NgoaiNgu.MaNN = NVNN.MaNN ");
        }

        private void dgvNN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dgvNN.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dgvNN.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dgvNN.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            { }
        }

        private void dgvNN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvNN.DataSource = dtbase.DataReader("select HoTen , TenNN from NVNN inner join HoSoNV on NVNN.MaNV = HoSoNV.MaNV inner join NgoaiNgu on NVNN.MaNN = NgoaiNgu.MaNN  where NVNN.MaNN = 'NN01'  group by TenNN, HoTen ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvNN.DataSource = dtbase.DataReader("select HoTen , TenNN from NVNN inner join HoSoNV on NVNN.MaNV = HoSoNV.MaNV inner join NgoaiNgu on NVNN.MaNN = NgoaiNgu.MaNN  where NVNN.MaNN = 'NN03'  group by TenNN, HoTen ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvNN.DataSource = dtbase.DataReader("select HoTen , TenNN from NVNN inner join HoSoNV on NVNN.MaNV = HoSoNV.MaNV inner join NgoaiNgu on NVNN.MaNN = NgoaiNgu.MaNN  where NVNN.MaNN = 'NN02'  group by TenNN, HoTen ");
        }
    }
}
