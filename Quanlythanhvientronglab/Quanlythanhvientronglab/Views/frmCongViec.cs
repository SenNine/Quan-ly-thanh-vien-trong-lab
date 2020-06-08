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
    public partial class frmCongViec : Form
    {
        public frmCongViec()
        {
            InitializeComponent();
            ShowData();
        }
        private bool KiemTraError(bool check)
        {
            if(this.txtMacv.Text.Trim().Length<=0)
            {
                this.errorProvider1.SetError(this.txtMacv, "Hay nhap ma cong viec");
                check = true;
            }
            if (this.txtTencv.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txtMacv, "Hay nhap ten cong viec");
                check = true;
            }
            
            return check;
        }
        private void ShowData()
        {
            
            BindingSource src = new BindingSource();
            src.DataSource = CongViecController.GetListCV();
            this.dataCongViec.DataSource = src;
            this.dataCongViec.Columns[3].Visible = false;
            this.dataCongViec.Columns[4].Visible = false;
            this.dataCongViec.Columns[5].Visible = false;
        }
        private void addbt_Click(object sender, EventArgs e)
        {
            bool check = false;
            //Kiem tra MaCV da ton tai
            if (CongViecController.GetCV(this.txtMacv.Text.Trim()) != null)
            {
                return;
            }
            //Kiem tra hop le 
            if (KiemTraError(check) == true) return;

            ClassCongViec congviec = new ClassCongViec { MaCV = this.txtMacv.Text.Trim(), TenCV = this.txtTencv.Text.Trim(), ChiTiet = this.txtChitiet.Text.Trim() };

            if (CongViecController.AddCV(congviec) == false)
            {
                MessageBox.Show("Loi khi them cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            //Xoa control
            this.txtChitiet.Clear();
            this.txtMacv.Clear();
            this.txtTencv.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
        }

        private void dataCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay du lieu tu datagridview hien thi len textbox
            this.txtMacv.Text = dataCongViec.CurrentRow.Cells[0].Value.ToString();
            this.txtTencv.Text = dataCongViec.CurrentRow.Cells[1].Value.ToString();
            this.txtChitiet.Text = dataCongViec.CurrentRow.Cells[2].Value.ToString();
        }

        private void delbt_Click(object sender, EventArgs e)
        {
            //Kiem tra user co chon hang de xoa khong ?
            if (dataCongViec.SelectedRows.Count <= 0) 
                return;

            ClassCongViec cv = CongViecController.GetCV(this.txtMacv.Text.Trim());
            //Xoa cong viec
            if(CongViecController.DeleteCV(cv)==false)
            {
                MessageBox.Show("Loi khi xoa cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowData();
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (KiemTraError(check) == true)
                return;

            ClassCongViec congviec = new ClassCongViec 
            { MaCV = this.txtMacv.Text.Trim(), 
                TenCV = this.txtTencv.Text.Trim(), 
                ChiTiet = this.txtChitiet.Text.Trim() };

            if(CongViecController.UpdateCV(congviec)==false)
            {
                MessageBox.Show("Loi khi sua cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowData();

            this.txtChitiet.Clear();
            this.txtMacv.Clear();
            this.txtTencv.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
        }
    }
}
