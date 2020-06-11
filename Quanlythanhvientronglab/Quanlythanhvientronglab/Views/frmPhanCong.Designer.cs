namespace Quanlythanhvientronglab.Views
{
    partial class frmPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listsearchG = new System.Windows.Forms.ListBox();
            this.listsearchX = new System.Windows.Forms.ListBox();
            this.listBoxX = new System.Windows.Forms.ListBox();
            this.listBoxG = new System.Windows.Forms.ListBox();
            this.txtTienDo = new System.Windows.Forms.TextBox();
            this.cbbManv = new System.Windows.Forms.ComboBox();
            this.cbbMada = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPhancong = new System.Windows.Forms.ListView();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaDA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaCVgiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaCVXong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listsearchG);
            this.groupBox1.Controls.Add(this.listsearchX);
            this.groupBox1.Controls.Add(this.listBoxX);
            this.groupBox1.Controls.Add(this.listBoxG);
            this.groupBox1.Controls.Add(this.txtTienDo);
            this.groupBox1.Controls.Add(this.cbbManv);
            this.groupBox1.Controls.Add(this.cbbMada);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1148, 437);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phân Công";
            // 
            // listsearchG
            // 
            this.listsearchG.FormattingEnabled = true;
            this.listsearchG.ItemHeight = 26;
            this.listsearchG.Location = new System.Drawing.Point(1002, 52);
            this.listsearchG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listsearchG.Name = "listsearchG";
            this.listsearchG.Size = new System.Drawing.Size(101, 108);
            this.listsearchG.TabIndex = 89;
            this.listsearchG.DoubleClick += new System.EventHandler(this.listsearchG_DoubleClick);
            // 
            // listsearchX
            // 
            this.listsearchX.FormattingEnabled = true;
            this.listsearchX.ItemHeight = 26;
            this.listsearchX.Location = new System.Drawing.Point(1002, 210);
            this.listsearchX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listsearchX.Name = "listsearchX";
            this.listsearchX.Size = new System.Drawing.Size(101, 108);
            this.listsearchX.TabIndex = 89;
            this.listsearchX.DoubleClick += new System.EventHandler(this.listsearchX_DoubleClick);
            // 
            // listBoxX
            // 
            this.listBoxX.FormattingEnabled = true;
            this.listBoxX.ItemHeight = 26;
            this.listBoxX.Location = new System.Drawing.Point(795, 210);
            this.listBoxX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxX.Name = "listBoxX";
            this.listBoxX.Size = new System.Drawing.Size(124, 108);
            this.listBoxX.TabIndex = 88;
            this.listBoxX.DoubleClick += new System.EventHandler(this.listBoxX_DoubleClick);
            // 
            // listBoxG
            // 
            this.listBoxG.FormattingEnabled = true;
            this.listBoxG.ItemHeight = 26;
            this.listBoxG.Location = new System.Drawing.Point(795, 52);
            this.listBoxG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxG.Name = "listBoxG";
            this.listBoxG.Size = new System.Drawing.Size(124, 108);
            this.listBoxG.TabIndex = 88;
            this.listBoxG.DoubleClick += new System.EventHandler(this.listBoxG_DoubleClick);
            // 
            // txtTienDo
            // 
            this.txtTienDo.Enabled = false;
            this.txtTienDo.Location = new System.Drawing.Point(807, 366);
            this.txtTienDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienDo.Name = "txtTienDo";
            this.txtTienDo.Size = new System.Drawing.Size(112, 32);
            this.txtTienDo.TabIndex = 87;
            // 
            // cbbManv
            // 
            this.cbbManv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbManv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbManv.FormattingEnabled = true;
            this.cbbManv.Location = new System.Drawing.Point(227, 52);
            this.cbbManv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbManv.Name = "cbbManv";
            this.cbbManv.Size = new System.Drawing.Size(210, 34);
            this.cbbManv.TabIndex = 86;
            // 
            // cbbMada
            // 
            this.cbbMada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMada.FormattingEnabled = true;
            this.cbbMada.Location = new System.Drawing.Point(232, 118);
            this.cbbMada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMada.Name = "cbbMada";
            this.cbbMada.Size = new System.Drawing.Size(205, 34);
            this.cbbMada.TabIndex = 86;
            this.cbbMada.SelectedIndexChanged += new System.EventHandler(this.cbbMada_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.addbtn);
            this.groupBox2.Location = new System.Drawing.Point(39, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(307, 132);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lưu";
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.save;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbtn.Location = new System.Drawing.Point(199, 20);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(70, 69);
            this.addbtn.TabIndex = 0;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "Công Việc Giao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã Dự Án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tiến Độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 26);
            this.label4.TabIndex = 77;
            this.label4.Text = "Công Việc Hoàn Thành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // listViewPhancong
            // 
            this.listViewPhancong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.MaDA,
            this.MaCVgiao,
            this.MaCVXong,
            this.TienDo});
            this.listViewPhancong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewPhancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.listViewPhancong.GridLines = true;
            this.listViewPhancong.HideSelection = false;
            this.listViewPhancong.Location = new System.Drawing.Point(0, 494);
            this.listViewPhancong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewPhancong.Name = "listViewPhancong";
            this.listViewPhancong.Size = new System.Drawing.Size(1217, 322);
            this.listViewPhancong.TabIndex = 4;
            this.listViewPhancong.UseCompatibleStateImageBehavior = false;
            this.listViewPhancong.View = System.Windows.Forms.View.Details;
            this.listViewPhancong.Click += new System.EventHandler(this.listViewPhancong_Click);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã Nhân Viên";
            this.MaNV.Width = 110;
            // 
            // MaDA
            // 
            this.MaDA.Text = "Mã Dự Án";
            this.MaDA.Width = 110;
            // 
            // MaCVgiao
            // 
            this.MaCVgiao.Text = "Công Việc Giao";
            this.MaCVgiao.Width = 171;
            // 
            // MaCVXong
            // 
            this.MaCVXong.Text = "Công Việc Hoàn Thành";
            this.MaCVXong.Width = 209;
            // 
            // TienDo
            // 
            this.TienDo.Text = "Tiến Độ";
            this.TienDo.Width = 125;
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 816);
            this.Controls.Add(this.listViewPhancong);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhanCong";
            this.Text = "frmPhanCong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbManv;
        private System.Windows.Forms.ComboBox cbbMada;
        private System.Windows.Forms.ListView listViewPhancong;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader MaDA;
        private System.Windows.Forms.ColumnHeader MaCVgiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader MaCVXong;
        private System.Windows.Forms.ColumnHeader TienDo;
        private System.Windows.Forms.TextBox txtTienDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ListBox listBoxX;
        private System.Windows.Forms.ListBox listBoxG;
        private System.Windows.Forms.ListBox listsearchG;
        private System.Windows.Forms.ListBox listsearchX;
    }
}