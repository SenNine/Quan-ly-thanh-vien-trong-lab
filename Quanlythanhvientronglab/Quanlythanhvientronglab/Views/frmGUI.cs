using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythanhvientronglab.Views
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        private void btn_hosonv_Click(object sender, EventArgs e)
        {
            frmHoSoNV frmHoSo = new frmHoSoNV();
            frmHoSo.Show();
        }

        private void btn_duan_Click(object sender, EventArgs e)
        {
            frmDuAn frmda = new frmDuAn();
            frmda.Show();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            frmBangLuong frmluong = new frmBangLuong();
            frmluong.Show();
        }

        private void btn_chucvu_Click(object sender, EventArgs e)
        {
            frmChucVu frmcv = new frmChucVu();
            frmcv.Show();
        }

        private void btn_phancong_Click(object sender, EventArgs e)
        {
            frmPhanCong frmpc = new frmPhanCong();
            frmpc.Show();
        }

        private void btn_bangcong_Click(object sender, EventArgs e)
        {
            frmBangCong frmbc = new frmBangCong();
            frmbc.Show();
        }

        private void btn_thannhan_Click(object sender, EventArgs e)
        {
            frmThanNhan frmtn = new frmThanNhan();
            frmtn.Show();
        }
    }
}
