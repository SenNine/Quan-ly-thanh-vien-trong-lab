using Quanlythanhvientronglab.Models;
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
            
        }

        private void btn_duan_Click(object sender, EventArgs e)
        {
            frmDuAn fda = new frmDuAn();
            fda.Show();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_chucvu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_phancong_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_bangcong_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_thannhan_Click(object sender, EventArgs e)
        {
            frmCongViec fcv = new frmCongViec();
            fcv.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var _context=new DBManageContext())
            {
                ClassChucVu cv = new ClassChucVu { MaChucVu = "GD", TenChucVu = "Giam doc" };
                _context.tbChucVu.Add(cv);
                _context.SaveChanges();
            }
            MessageBox.Show("Finish");
        }
    }
}
