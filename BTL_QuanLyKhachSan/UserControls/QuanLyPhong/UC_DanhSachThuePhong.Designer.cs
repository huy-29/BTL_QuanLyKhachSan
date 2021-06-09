namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    partial class UC_DanhSachThuePhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Yellow, System.Drawing.Color.Empty, null);
            this.btnXem = new System.Windows.Forms.Button();
            this.txbKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txbCheckOut = new System.Windows.Forms.TextBox();
            this.txbCheckIn = new System.Windows.Forms.TextBox();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lvDanhSachThuePhong = new System.Windows.Forms.ListView();
            this.colMaThuePhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.chkCheckOutMuon = new System.Windows.Forms.CheckBox();
            this.lblCheck_ChuyenPhong = new System.Windows.Forms.Label();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(758, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(54, 39);
            this.btnXem.TabIndex = 96;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txbKhachHang
            // 
            this.txbKhachHang.Location = new System.Drawing.Point(118, 84);
            this.txbKhachHang.MaxLength = 50;
            this.txbKhachHang.Multiline = true;
            this.txbKhachHang.Name = "txbKhachHang";
            this.txbKhachHang.Size = new System.Drawing.Size(212, 22);
            this.txbKhachHang.TabIndex = 95;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(24, 85);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(88, 16);
            this.lblKhachHang.TabIndex = 94;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(380, 85);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(52, 16);
            this.lblPhong.TabIndex = 93;
            this.lblPhong.Text = "Phòng";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(438, 85);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(116, 21);
            this.cbPhong.TabIndex = 92;
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.BackColor = System.Drawing.Color.Chocolate;
            this.btnChuyenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhong.ForeColor = System.Drawing.Color.White;
            this.btnChuyenPhong.Location = new System.Drawing.Point(3, 0);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(123, 39);
            this.btnChuyenPhong.TabIndex = 91;
            this.btnChuyenPhong.Text = "Chuyển phòng";
            this.btnChuyenPhong.UseVisualStyleBackColor = false;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(356, 113);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(76, 16);
            this.lblCheckOut.TabIndex = 90;
            this.lblCheckOut.Text = "Check out";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(45, 117);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(67, 16);
            this.lblCheckIn.TabIndex = 89;
            this.lblCheckIn.Text = "Check in";
            // 
            // txbCheckOut
            // 
            this.txbCheckOut.Location = new System.Drawing.Point(438, 112);
            this.txbCheckOut.MaxLength = 30;
            this.txbCheckOut.Multiline = true;
            this.txbCheckOut.Name = "txbCheckOut";
            this.txbCheckOut.Size = new System.Drawing.Size(184, 22);
            this.txbCheckOut.TabIndex = 88;
            // 
            // txbCheckIn
            // 
            this.txbCheckIn.Location = new System.Drawing.Point(118, 112);
            this.txbCheckIn.MaxLength = 30;
            this.txbCheckIn.Multiline = true;
            this.txbCheckIn.Name = "txbCheckIn";
            this.txbCheckIn.Size = new System.Drawing.Size(184, 22);
            this.txbCheckIn.TabIndex = 87;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.Location = new System.Drawing.Point(437, 112);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(212, 22);
            this.dtCheckOut.TabIndex = 86;
            this.dtCheckOut.CloseUp += new System.EventHandler(this.dtCheckOut_CloseUp);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckIn.Location = new System.Drawing.Point(118, 112);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(212, 22);
            this.dtCheckIn.TabIndex = 85;
            this.dtCheckIn.CloseUp += new System.EventHandler(this.dtCheckIn_CloseUp);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(694, 84);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 49);
            this.btnTimKiem.TabIndex = 84;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lvDanhSachThuePhong
            // 
            this.lvDanhSachThuePhong.BackColor = System.Drawing.Color.White;
            this.lvDanhSachThuePhong.CheckBoxes = true;
            this.lvDanhSachThuePhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaThuePhong,
            this.clTenKhachHang,
            this.clTenPhong,
            this.clSoNguoi,
            this.clCheckIn,
            this.clCheckOut,
            this.colGhiChu});
            this.lvDanhSachThuePhong.FullRowSelect = true;
            this.lvDanhSachThuePhong.GridLines = true;
            this.lvDanhSachThuePhong.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.lvDanhSachThuePhong.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvDanhSachThuePhong.Location = new System.Drawing.Point(3, 140);
            this.lvDanhSachThuePhong.Name = "lvDanhSachThuePhong";
            this.lvDanhSachThuePhong.ShowItemToolTips = true;
            this.lvDanhSachThuePhong.Size = new System.Drawing.Size(809, 389);
            this.lvDanhSachThuePhong.TabIndex = 83;
            this.lvDanhSachThuePhong.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachThuePhong.View = System.Windows.Forms.View.Details;
            this.lvDanhSachThuePhong.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDanhSachThuePhong_ItemChecked);
            // 
            // colMaThuePhong
            // 
            this.colMaThuePhong.Text = "Mã thuê phòng";
            this.colMaThuePhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaThuePhong.Width = 61;
            // 
            // clTenKhachHang
            // 
            this.clTenKhachHang.Text = "Khách hàng";
            this.clTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenKhachHang.Width = 198;
            // 
            // clTenPhong
            // 
            this.clTenPhong.Text = "Phòng";
            this.clTenPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenPhong.Width = 78;
            // 
            // clSoNguoi
            // 
            this.clSoNguoi.Text = "Số người";
            this.clSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSoNguoi.Width = 59;
            // 
            // clCheckIn
            // 
            this.clCheckIn.Text = "Check in";
            this.clCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCheckIn.Width = 139;
            // 
            // clCheckOut
            // 
            this.clCheckOut.Text = "Check out";
            this.clCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCheckOut.Width = 126;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Text = "Ghi chú";
            this.colGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGhiChu.Width = 117;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.Red;
            this.btnTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.Location = new System.Drawing.Point(132, 0);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(88, 39);
            this.btnTraPhong.TabIndex = 82;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(694, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 39);
            this.btnSua.TabIndex = 81;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(596, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 80;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chkCheckOutMuon
            // 
            this.chkCheckOutMuon.AutoSize = true;
            this.chkCheckOutMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheckOutMuon.Location = new System.Drawing.Point(326, 22);
            this.chkCheckOutMuon.Name = "chkCheckOutMuon";
            this.chkCheckOutMuon.Size = new System.Drawing.Size(122, 20);
            this.chkCheckOutMuon.TabIndex = 97;
            this.chkCheckOutMuon.Text = "Check out muộn";
            this.chkCheckOutMuon.UseVisualStyleBackColor = true;
            // 
            // lblCheck_ChuyenPhong
            // 
            this.lblCheck_ChuyenPhong.AutoSize = true;
            this.lblCheck_ChuyenPhong.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_ChuyenPhong.Location = new System.Drawing.Point(3, 42);
            this.lblCheck_ChuyenPhong.Name = "lblCheck_ChuyenPhong";
            this.lblCheck_ChuyenPhong.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_ChuyenPhong.TabIndex = 98;
            this.lblCheck_ChuyenPhong.Text = "label1";
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSapXep.Location = new System.Drawing.Point(255, 49);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(65, 16);
            this.lblSapXep.TabIndex = 100;
            this.lblSapXep.Text = "Sắp xếp";
            // 
            // cbSapXep
            // 
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "Tất cả",
            "Phòng",
            "Check-in",
            "Check-out"});
            this.cbSapXep.Location = new System.Drawing.Point(326, 48);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(149, 21);
            this.cbSapXep.TabIndex = 99;
            // 
            // UC_DanhSachThuePhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblSapXep);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.lblCheck_ChuyenPhong);
            this.Controls.Add(this.chkCheckOutMuon);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txbKhachHang);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.btnChuyenPhong);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.txbCheckOut);
            this.Controls.Add(this.txbCheckIn);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lvDanhSachThuePhong);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "UC_DanhSachThuePhong";
            this.Size = new System.Drawing.Size(815, 541);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txbKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Button btnChuyenPhong;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txbCheckOut;
        private System.Windows.Forms.TextBox txbCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ListView lvDanhSachThuePhong;
        private System.Windows.Forms.ColumnHeader colMaThuePhong;
        private System.Windows.Forms.ColumnHeader clTenKhachHang;
        private System.Windows.Forms.ColumnHeader clTenPhong;
        private System.Windows.Forms.ColumnHeader clSoNguoi;
        private System.Windows.Forms.ColumnHeader clCheckIn;
        private System.Windows.Forms.ColumnHeader clCheckOut;
        private System.Windows.Forms.ColumnHeader colGhiChu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox chkCheckOutMuon;
        private System.Windows.Forms.Label lblCheck_ChuyenPhong;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cbSapXep;
    }
}
