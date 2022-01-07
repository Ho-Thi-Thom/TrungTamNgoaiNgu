namespace Winform.GUI.QLKhoaThi
{
    partial class FKhoaThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemGiaoVien = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khoaThiChotSo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnXoaKhoaThi = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThemKhoaThi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.phongThiChotSo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDoDuThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnXoaThiSinhDuThi = new System.Windows.Forms.Button();
            this.btnThemDuThi = new System.Windows.Forms.Button();
            this.btnChotKhoaThi = new System.Windows.Forms.Button();
            this.btnSuaKhoaThi = new System.Windows.Forms.Button();
            this.btnChiTietPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemGiaoVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(952, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemGiaoVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGiaoVien.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnThemGiaoVien.Location = new System.Drawing.Point(10, 10);
            this.btnThemGiaoVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(145, 45);
            this.btnThemGiaoVien.TabIndex = 1;
            this.btnThemGiaoVien.Text = "Thêm giáo viên";
            this.btnThemGiaoVien.UseVisualStyleBackColor = false;
            this.btnThemGiaoVien.Click += new System.EventHandler(this.btnThemGiaoVien_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.panel5.Size = new System.Drawing.Size(492, 252);
            this.panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khoaThiChotSo,
            this.tenKhoa,
            this.ngayThi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(482, 182);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // khoaThiChotSo
            // 
            this.khoaThiChotSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.khoaThiChotSo.HeaderText = "Chốt sổ";
            this.khoaThiChotSo.Name = "khoaThiChotSo";
            this.khoaThiChotSo.ReadOnly = true;
            this.khoaThiChotSo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.khoaThiChotSo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.khoaThiChotSo.Width = 78;
            // 
            // tenKhoa
            // 
            this.tenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKhoa.HeaderText = "Khoá thi";
            this.tenKhoa.Name = "tenKhoa";
            this.tenKhoa.ReadOnly = true;
            this.tenKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ngayThi
            // 
            this.ngayThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayThi.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayThi.HeaderText = "Ngày thi";
            this.ngayThi.Name = "ngayThi";
            this.ngayThi.ReadOnly = true;
            this.ngayThi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ngayThi.Width = 82;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 50);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(282, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Khoá thi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnXoaKhoaThi);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(282, 0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel14.Size = new System.Drawing.Size(50, 50);
            this.panel14.TabIndex = 5;
            // 
            // btnXoaKhoaThi
            // 
            this.btnXoaKhoaThi.AccessibleDescription = "";
            this.btnXoaKhoaThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaKhoaThi.Enabled = false;
            this.btnXoaKhoaThi.FlatAppearance.BorderSize = 0;
            this.btnXoaKhoaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoaThi.Image = global::Winform.Properties.Resources.delete;
            this.btnXoaKhoaThi.Location = new System.Drawing.Point(5, 5);
            this.btnXoaKhoaThi.Name = "btnXoaKhoaThi";
            this.btnXoaKhoaThi.Size = new System.Drawing.Size(45, 40);
            this.btnXoaKhoaThi.TabIndex = 0;
            this.btnXoaKhoaThi.UseVisualStyleBackColor = true;
            this.btnXoaKhoaThi.Visible = false;
            this.btnXoaKhoaThi.Click += new System.EventHandler(this.btnXoaKhoaThi_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnChotKhoaThi);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(332, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel9.Size = new System.Drawing.Size(50, 50);
            this.panel9.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSuaKhoaThi);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(382, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel7.Size = new System.Drawing.Size(50, 50);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThemKhoaThi);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(432, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel6.Size = new System.Drawing.Size(50, 50);
            this.panel6.TabIndex = 1;
            // 
            // btnThemKhoaThi
            // 
            this.btnThemKhoaThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKhoaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemKhoaThi.FlatAppearance.BorderSize = 0;
            this.btnThemKhoaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoaThi.Image = global::Winform.Properties.Resources.plus;
            this.btnThemKhoaThi.Location = new System.Drawing.Point(5, 5);
            this.btnThemKhoaThi.Name = "btnThemKhoaThi";
            this.btnThemKhoaThi.Size = new System.Drawing.Size(45, 40);
            this.btnThemKhoaThi.TabIndex = 0;
            this.btnThemKhoaThi.UseVisualStyleBackColor = true;
            this.btnThemKhoaThi.Click += new System.EventHandler(this.btnThemKhoaThi_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(492, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(460, 252);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phongThiChotSo,
            this.tenPhong,
            this.trinhDo});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(10, 60);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(440, 182);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // phongThiChotSo
            // 
            this.phongThiChotSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.phongThiChotSo.HeaderText = "Chốt sổ";
            this.phongThiChotSo.Name = "phongThiChotSo";
            this.phongThiChotSo.ReadOnly = true;
            this.phongThiChotSo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phongThiChotSo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.phongThiChotSo.Width = 78;
            // 
            // tenPhong
            // 
            this.tenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenPhong.HeaderText = "Phòng thi";
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.ReadOnly = true;
            this.tenPhong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // trinhDo
            // 
            this.trinhDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.trinhDo.HeaderText = "Trình độ";
            this.trinhDo.Name = "trinhDo";
            this.trinhDo.ReadOnly = true;
            this.trinhDo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trinhDo.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 50);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(390, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phòng thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnChiTietPhong);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(390, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel8.Size = new System.Drawing.Size(50, 50);
            this.panel8.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(952, 252);
            this.panel10.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 317);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel11.Size = new System.Drawing.Size(952, 213);
            this.panel11.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dataGridView3);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(10, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(932, 203);
            this.panel12.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCCD,
            this.NguoiDung,
            this.trinhDoDuThi});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 50);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 30;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(932, 153);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // CCCD
            // 
            this.CCCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            this.CCCD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CCCD.Width = 66;
            // 
            // NguoiDung
            // 
            this.NguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NguoiDung.HeaderText = "Họ và tên";
            this.NguoiDung.Name = "NguoiDung";
            this.NguoiDung.ReadOnly = true;
            this.NguoiDung.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // trinhDoDuThi
            // 
            this.trinhDoDuThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.trinhDoDuThi.HeaderText = "Trình độ dự thi";
            this.trinhDoDuThi.Name = "trinhDoDuThi";
            this.trinhDoDuThi.ReadOnly = true;
            this.trinhDoDuThi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trinhDoDuThi.Width = 119;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(932, 50);
            this.panel13.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(832, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh sách dự thi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnXoaThiSinhDuThi);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(832, 0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel15.Size = new System.Drawing.Size(50, 50);
            this.panel15.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnThemDuThi);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(882, 0);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel16.Size = new System.Drawing.Size(50, 50);
            this.panel16.TabIndex = 1;
            // 
            // btnXoaThiSinhDuThi
            // 
            this.btnXoaThiSinhDuThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaThiSinhDuThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaThiSinhDuThi.Enabled = false;
            this.btnXoaThiSinhDuThi.FlatAppearance.BorderSize = 0;
            this.btnXoaThiSinhDuThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThiSinhDuThi.Image = global::Winform.Properties.Resources.delete;
            this.btnXoaThiSinhDuThi.Location = new System.Drawing.Point(5, 5);
            this.btnXoaThiSinhDuThi.Name = "btnXoaThiSinhDuThi";
            this.btnXoaThiSinhDuThi.Size = new System.Drawing.Size(45, 40);
            this.btnXoaThiSinhDuThi.TabIndex = 0;
            this.btnXoaThiSinhDuThi.UseVisualStyleBackColor = true;
            this.btnXoaThiSinhDuThi.Visible = false;
            this.btnXoaThiSinhDuThi.Click += new System.EventHandler(this.btnXoaThiSinhDuThi_Click);
            // 
            // btnThemDuThi
            // 
            this.btnThemDuThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDuThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemDuThi.Enabled = false;
            this.btnThemDuThi.FlatAppearance.BorderSize = 0;
            this.btnThemDuThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDuThi.Image = global::Winform.Properties.Resources.plus;
            this.btnThemDuThi.Location = new System.Drawing.Point(5, 5);
            this.btnThemDuThi.Name = "btnThemDuThi";
            this.btnThemDuThi.Size = new System.Drawing.Size(45, 40);
            this.btnThemDuThi.TabIndex = 0;
            this.btnThemDuThi.UseVisualStyleBackColor = true;
            this.btnThemDuThi.Visible = false;
            this.btnThemDuThi.Click += new System.EventHandler(this.btnThemDuThi_Click);
            // 
            // btnChotKhoaThi
            // 
            this.btnChotKhoaThi.AccessibleDescription = "";
            this.btnChotKhoaThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChotKhoaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChotKhoaThi.Enabled = false;
            this.btnChotKhoaThi.FlatAppearance.BorderSize = 0;
            this.btnChotKhoaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChotKhoaThi.Image = global::Winform.Properties.Resources._lock;
            this.btnChotKhoaThi.Location = new System.Drawing.Point(5, 5);
            this.btnChotKhoaThi.Name = "btnChotKhoaThi";
            this.btnChotKhoaThi.Size = new System.Drawing.Size(45, 40);
            this.btnChotKhoaThi.TabIndex = 0;
            this.btnChotKhoaThi.UseVisualStyleBackColor = true;
            this.btnChotKhoaThi.Visible = false;
            this.btnChotKhoaThi.Click += new System.EventHandler(this.btnChotKhoaThi_Click);
            // 
            // btnSuaKhoaThi
            // 
            this.btnSuaKhoaThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKhoaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaKhoaThi.Enabled = false;
            this.btnSuaKhoaThi.FlatAppearance.BorderSize = 0;
            this.btnSuaKhoaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKhoaThi.Image = global::Winform.Properties.Resources.edit;
            this.btnSuaKhoaThi.Location = new System.Drawing.Point(5, 5);
            this.btnSuaKhoaThi.Name = "btnSuaKhoaThi";
            this.btnSuaKhoaThi.Size = new System.Drawing.Size(45, 40);
            this.btnSuaKhoaThi.TabIndex = 0;
            this.btnSuaKhoaThi.UseVisualStyleBackColor = true;
            this.btnSuaKhoaThi.Visible = false;
            this.btnSuaKhoaThi.Click += new System.EventHandler(this.btnSuaKhoaThi_Click);
            // 
            // btnChiTietPhong
            // 
            this.btnChiTietPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTietPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChiTietPhong.Enabled = false;
            this.btnChiTietPhong.FlatAppearance.BorderSize = 0;
            this.btnChiTietPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietPhong.Image = global::Winform.Properties.Resources.next;
            this.btnChiTietPhong.Location = new System.Drawing.Point(5, 5);
            this.btnChiTietPhong.Name = "btnChiTietPhong";
            this.btnChiTietPhong.Size = new System.Drawing.Size(45, 40);
            this.btnChiTietPhong.TabIndex = 0;
            this.btnChiTietPhong.UseVisualStyleBackColor = true;
            this.btnChiTietPhong.Visible = false;
            this.btnChiTietPhong.Click += new System.EventHandler(this.btnChiTietPhong_Click);
            // 
            // FKhoaThi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(952, 530);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FKhoaThi";
            this.Text = "FTour";
            this.Load += new System.EventHandler(this.FKhoaThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemGiaoVien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSuaKhoaThi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThemKhoaThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnChotKhoaThi;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnChiTietPhong;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnXoaThiSinhDuThi;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnThemDuThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnXoaKhoaThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn khoaThiChotSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn phongThiChotSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDoDuThi;
    }
}
