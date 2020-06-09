﻿using Quanlythanhvientronglab.Controllers;
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
        List<ClassCongViec> searchcv;
        string selectedMaDA;
        string[] arrlstCVfirst;
        public frmDuAn()
        {
            InitializeComponent();
            ShowData();
        }
        private bool KiemTra(bool check)
        {
            if(this.txtMaDA.Text.Trim().Length<=0)
            {
                this.errorProvider1.SetError(this.txtMaDA, "Hay nhap ma du an");
                check = true;
            }
            if (this.txtTenDA.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txtTenDA, "Hay nhap ten du an");
                check = true;
            }
            if(this.fromDatePicker.Value>=this.toDatePicker.Value)
            {
                this.errorProvider3.SetError(this.fromDatePicker, "Hay nhap lai ngay bat dau");
                this.errorProvider4.SetError(this.toDatePicker, "Hay nhap lai ngay ket thuc");
                check = true;
            }
            return check;
        }
        private void ShowData()
        {
            listViewda.Items.Clear();
            List<ClassDuAn> lstda = DAController.GetListDA();
            string displayCV = "";
            foreach(var i in lstda)
            {
                displayCV = "";
                foreach (var j in i.listCV)
                {
                    displayCV = displayCV + j + " ";
                }

                ListViewItem da = new ListViewItem(i.MaDA);
                da.SubItems.Add(new ListViewItem.ListViewSubItem(da, i.TenDA));
                da.SubItems.Add(new ListViewItem.ListViewSubItem(da, i.ChiTiet));
                da.SubItems.Add(new ListViewItem.ListViewSubItem(da, i.fromDate.ToString()));
                da.SubItems.Add(new ListViewItem.ListViewSubItem(da, i.toDate.ToString()));
                da.SubItems.Add(new ListViewItem.ListViewSubItem(da, displayCV));
                this.listViewda.Items.Add(da);
            }
                
            
        }
        private void ClearControls()
        {
            this.txtMaDA.Clear();
            this.txtTenDA.Clear();
            this.txtChitiet.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
            this.errorProvider4.Clear();
            this.listCongViec.Items.Clear();
            this.listSearch.Items.Clear();
            this.txtSearch.Clear();
            this.fromDatePicker.Value = DateTime.Now;
            this.toDatePicker.Value = DateTime.Now;
        }
        private void addbt_Click(object sender, EventArgs e)
        {
            //Kiem tra MaDA da ton tai hay khong
            if (DAController.GetDuAn(txtMaDA.Text.Trim()) != null)
                return;

            //kiem tra hop le
            bool check = false;
            if (KiemTra(check) == true)
                return;

            ClassDuAn da = new ClassDuAn();
            da.MaDA = txtMaDA.Text.Trim();
            da.TenDA = txtTenDA.Text.Trim();
            da.fromDate = fromDatePicker.Value;
            da.toDate = toDatePicker.Value;
            da.ChiTiet = txtChitiet.Text;
            
            string displayCV = "";
            for(int i=0;i<listCongViec.Items.Count;i++)
            {
                displayCV = displayCV + this.listCongViec.Items[i] + " ";
                da.listCV.Add(CongViecController.GetCV(this.listCongViec.Items[i].ToString()));
               
            }

            //Kiem tra congviec da thuoc du an khac hay khong
            List<ClassCongViec> congViecs = new List<ClassCongViec>();
            foreach(var i in CongViecController.GetListCV())
            {
                if (i.listDA.Count != 0)
                    congViecs.Add(i);
            }
            foreach(var j in congViecs)
            {
                foreach(var z in da.listCV)
                {
                    if (j.MaCV == z.MaCV)
                        return;
                }
            }

            
            //them vao csdl
            if(DAController.AddDuAn(da)==false)
            {
                MessageBox.Show("Loi khi them du an","Loi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //hien thi du lieu
            ShowData();

            ClearControls();
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.listSearch.Items.Clear();

            //tim congviec 
            searchcv = CongViecController.GetListCV(this.txtSearch.Text.Trim());
            if (searchcv.Count > 0)
            {
                this.listSearch.Visible = true;
            }
            else
            {
                this.listSearch.Visible = false;
            }

            //hien thi cac cong viec chua thuoc du an 
            foreach (var x in searchcv)
            {
                if(x.listDA.Count==0)
                    this.listSearch.Items.Add(x);
            }
            if (this.txtSearch.Text == "")
            {
                this.listSearch.Items.Clear();
                this.listSearch.Visible = false;
            }
        }

        private void listSearch_DoubleClick(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var x in listCongViec.Items)
            {
                if (x == this.listSearch.SelectedItem)
                {
                    count++;
                }
            }
            if (this.listSearch.SelectedIndex >= 0 && count == 0)
            {
                this.listCongViec.Items.Add(this.listSearch.SelectedItem);
            }
        }

        private void listCongViec_DoubleClick(object sender, EventArgs e)
        {
            if(this.listCongViec.SelectedIndex>=0)
            {
                this.listCongViec.Items.RemoveAt(this.listCongViec.SelectedIndex);
            }
        }

        private void listViewda_Click(object sender, EventArgs e)
        {
            try
            {
                this.listCongViec.Items.Clear();
                this.listSearch.Items.Clear();

                //MaDA dang chon
                selectedMaDA = this.listViewda.SelectedItems[0].SubItems[0].Text.Trim();

                //hien thi len textbox
                this.txtMaDA.Text= this.listViewda.SelectedItems[0].SubItems[0].Text.Trim();               
                this.txtTenDA.Text = this.listViewda.SelectedItems[0].SubItems[1].Text.Trim();
                this.txtChitiet.Text = this.listViewda.SelectedItems[0].SubItems[2].Text.Trim();
                this.fromDatePicker.Value = DateTime.Parse(this.listViewda.SelectedItems[0].SubItems[3].Text.Trim());
                this.toDatePicker.Value = DateTime.Parse(this.listViewda.SelectedItems[0].SubItems[4].Text.Trim());

                string[] arrCV = this.listViewda.SelectedItems[0].SubItems[5].Text.Trim().Split();
                arrlstCVfirst = arrCV;
                foreach(var i in arrCV)
                    foreach(var j in CongViecController.GetListCV())
                    {
                        if (i == j.MaCV)
                            this.listCongViec.Items.Add(i);
                    }
            }
            catch (Exception) { }
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (KiemTra(check) == true)
                return;
            
            ClassDuAn da = new ClassDuAn();
            da.MaDA = txtMaDA.Text.Trim();
            da.TenDA = txtTenDA.Text.Trim();
            da.fromDate = fromDatePicker.Value;
            da.toDate = toDatePicker.Value;
            da.ChiTiet = txtChitiet.Text;

            string displayCV = "";
            for (int i = 0; i < listCongViec.Items.Count; i++)
            {
                displayCV = displayCV + this.listCongViec.Items[i] + " ";
                da.listCV.Add(CongViecController.GetCV(this.listCongViec.Items[i].ToString()));
            }

            //Kiem tra congviec thuoc du an khac hay khong khi ADD
            if(selectedMaDA!=this.txtMaDA.Text.Trim())
            {
                List<ClassCongViec> congViecs = new List<ClassCongViec>();
                foreach (var i in CongViecController.GetListCV())
                {
                    if (i.listDA.Count != 0)
                        congViecs.Add(i);
                }
                foreach (var j in congViecs)
                {
                    foreach (var z in da.listCV)
                    {
                        if (j.MaCV == z.MaCV)
                        {
                            MessageBox.Show("Cong viec da thuoc du an khac", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }                            
                    }
                }
            }

            //kiem tra cong viec thuoc du an khac hay khong Update
            //foreach(var i in da.listCV)
            //{
            //    if(i.listDA.Count!=0)
            //        foreach(var j in i.listDA)
            //        {
            //            if (j.MaDA != da.MaDA)
            //            {
            //                MessageBox.Show("Cong viec da thuoc du an khac", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
                            
            //        }               
            //}

            if (DAController.UpdateDA(da)==false)
            {
                MessageBox.Show("Loi khi sua du an", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            ClearControls();
        }

        private void delbt_Click(object sender, EventArgs e)
        {
            if(DAController.DeleteDuAn(this.txtMaDA.Text.Trim())==false)
            {
                MessageBox.Show("Loi khi xoa du an", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            ClearControls();
        }
    }
}
