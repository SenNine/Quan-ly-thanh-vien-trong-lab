namespace Quanlythanhvientronglab.Views
{
    partial class frmCongViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChitiet = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.editbt = new System.Windows.Forms.Button();
            this.delbt = new System.Windows.Forms.Button();
            this.addbt = new System.Windows.Forms.Button();
            this.txtTencv = new System.Windows.Forms.TextBox();
            this.txtMacv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaDA = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewCV = new System.Windows.Forms.ListView();
            this.MaCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaDA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChiTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaDA);
            this.groupBox1.Controls.Add(this.txtChitiet);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTencv);
            this.groupBox1.Controls.Add(this.txtMacv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Công Việc";
            // 
            // txtChitiet
            // 
            this.txtChitiet.Location = new System.Drawing.Point(577, 38);
            this.txtChitiet.Name = "txtChitiet";
            this.txtChitiet.Size = new System.Drawing.Size(251, 65);
            this.txtChitiet.TabIndex = 86;
            this.txtChitiet.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.editbt);
            this.groupBox2.Controls.Add(this.delbt);
            this.groupBox2.Controls.Add(this.addbt);
            this.groupBox2.Location = new System.Drawing.Point(467, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 124);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Sửa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lưu";
            // 
            // editbt
            // 
            this.editbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.edit;
            this.editbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbt.Location = new System.Drawing.Point(274, 36);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(62, 55);
            this.editbt.TabIndex = 0;
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.editbt_Click);
            // 
            // delbt
            // 
            this.delbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.xoa;
            this.delbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delbt.Location = new System.Drawing.Point(174, 36);
            this.delbt.Name = "delbt";
            this.delbt.Size = new System.Drawing.Size(62, 55);
            this.delbt.TabIndex = 0;
            this.delbt.UseVisualStyleBackColor = true;
            this.delbt.Click += new System.EventHandler(this.delbt_Click);
            // 
            // addbt
            // 
            this.addbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.save;
            this.addbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbt.Location = new System.Drawing.Point(79, 36);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(62, 55);
            this.addbt.TabIndex = 0;
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // txtTencv
            // 
            this.txtTencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTencv.Location = new System.Drawing.Point(165, 172);
            this.txtTencv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.Size = new System.Drawing.Size(235, 28);
            this.txtTencv.TabIndex = 78;
            // 
            // txtMacv
            // 
            this.txtMacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacv.Location = new System.Drawing.Point(165, 41);
            this.txtMacv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMacv.Name = "txtMacv";
            this.txtMacv.Size = new System.Drawing.Size(235, 28);
            this.txtMacv.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 77;
            this.label4.Text = "Chi Tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên Công Việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 77;
            this.label1.Text = "Mã Công Việc";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mã Dự Án";
            // 
            // cbbMaDA
            // 
            this.cbbMaDA.FormattingEnabled = true;
            this.cbbMaDA.Location = new System.Drawing.Point(165, 111);
            this.cbbMaDA.Name = "cbbMaDA";
            this.cbbMaDA.Size = new System.Drawing.Size(235, 30);
            this.cbbMaDA.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewCV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 202);
            this.panel1.TabIndex = 4;
            // 
            // listViewCV
            // 
            this.listViewCV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaCV,
            this.TenCV,
            this.ChiTiet,
            this.MaDA});
            this.listViewCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCV.GridLines = true;
            this.listViewCV.HideSelection = false;
            this.listViewCV.Location = new System.Drawing.Point(0, 0);
            this.listViewCV.Name = "listViewCV";
            this.listViewCV.Size = new System.Drawing.Size(882, 202);
            this.listViewCV.TabIndex = 0;
            this.listViewCV.UseCompatibleStateImageBehavior = false;
            this.listViewCV.View = System.Windows.Forms.View.Details;
            this.listViewCV.Click += new System.EventHandler(this.listViewCV_Click);
            // 
            // MaCV
            // 
            this.MaCV.Text = "Mã Công Việc";
            // 
            // MaDA
            // 
            this.MaDA.Text = "Mã Dự Án";
            // 
            // TenCV
            // 
            this.TenCV.Text = "Tên Công Việc";
            // 
            // ChiTiet
            // 
            this.ChiTiet.Text = "Chi Tiết";
            // 
            // frmCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCongViec";
            this.Text = "frmCongViec";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Button delbt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.TextBox txtTencv;
        private System.Windows.Forms.TextBox txtMacv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtChitiet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ComboBox cbbMaDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewCV;
        private System.Windows.Forms.ColumnHeader MaCV;
        private System.Windows.Forms.ColumnHeader MaDA;
        private System.Windows.Forms.ColumnHeader TenCV;
        private System.Windows.Forms.ColumnHeader ChiTiet;
    }
}