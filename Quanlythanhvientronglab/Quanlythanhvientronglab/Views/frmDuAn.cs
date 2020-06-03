using Quanlythanhvientronglab.Controllers;
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
    public partial class frmDuAn : Form
    {
        public frmDuAn()
        {
            InitializeComponent();
        }
        public bool kTraNhap(bool check)
        {
            if (this.txtMaDA.Text.Trim().Length<=0)
            {
                this.errorProvider1.SetError(this.txtMaDA, "Hãy nhập Mã dự án");
                check = true;
            }                   
            else 
            {
                if (DAController.GetDuAn(this.txtMaDA.Text.Trim()) != null)
                {
                    this.errorProvider1.SetError(this.txtMaDA, "Đã tồn tại Mã dự án");
                    check = true;
                }                    
            }

            if (this.txtTenDA.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txtTenDA, "Hãy nhập Tên dự án");
                check = true;
            }    
                
            if (this.txtThongTin.Text.Trim().Length <= 0)
            {
                this.errorProvider3.SetError(this.txtThongTin, "Hãy nhập Thông tin dự án");
                check = true;
            }
                
            if (this.txtTienDo.Text.Trim().Length <= 0)
            {
                this.errorProvider4.SetError(this.txtTienDo, "Hãy nhập Tiến độ");
                check = true;
            }
                
            if (this.txtCongViec.Text.Trim().Length <= 0)
            {
                this.errorProvider5.SetError(this.txtCongViec, "Hãy nhập Tên công việc");
                check = true;
            }
            return check;
        }
        public void ClearControls()
        {
            this.txtTenDA.Clear();
            this.txtTenDA.Clear();
            this.txtThongTin.Clear();
            this.txtTienDo.Clear();
            this.txtCongViec.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
            this.errorProvider4.Clear();
            this.errorProvider5.Clear();           
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (kTraNhap(check)==true)
            {
                return;
            }    
            ClassDuAn da = new ClassDuAn { MaDA = this.txtMaDA.Text.Trim(), 
                TenDA = this.txtTenDA.Text.Trim(), 
                CongViec = this.txtCongViec.Text.Trim(), 
                ThongTinDA = this.txtThongTin.Text.Trim(), 
                TienDo = this.txtTienDo.Text.Trim() };
            DAController.AddDuAn(da);
            ClearControls();
        }
    }
}
