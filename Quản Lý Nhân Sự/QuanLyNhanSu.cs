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
    public partial class QuanLyNhanSu : Form
    {
        public QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void hồSơNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fHoSoNV f = new fHoSoNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void phòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fPhongBan f = new fPhongBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fChucVu f = new fChucVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void trìnhĐộNgoạiNgữToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fTrinhDoNN f = new fTrinhDoNN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinTK f = new ThongTinTK();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
                this.Close();
        }

        private void quáTrìnhCôngTácToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fQuaTrinhCongTac f = new fQuaTrinhCongTac();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void QuanLyNhanSu_Load(object sender, EventArgs e)
        {

        }
    }
}
