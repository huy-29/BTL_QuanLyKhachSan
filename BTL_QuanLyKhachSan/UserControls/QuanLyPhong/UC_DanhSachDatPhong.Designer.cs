namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    partial class UC_DanhSachDatPhong
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
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txbCheckOut = new System.Windows.Forms.TextBox();
            this.txbCheckIn = new System.Windows.Forms.TextBox();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lvDanhSachDatPhong = new System.Windows.Forms.ListView();
            this.colMaThuePhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txbKhachHang = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblCheck_NhanPhong = new System.Windows.Forms.Label();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(356, 105);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(76, 16);
            this.lblCheckOut.TabIndex = 71;
            this.lblCheckOut.Text = "Check out";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(45, 109);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(67, 16);
            this.lblCheckIn.TabIndex = 70;
            this.lblCheckIn.Text = "Check in";
            // 
            // txbCheckOut
            // 
            this.txbCheckOut.Location = new System.Drawing.Point(438, 104);
            this.txbCheckOut.MaxLength = 30;
            this.txbCheckOut.Multiline = true;
            this.txbCheckOut.Name = "txbCheckOut";
            this.txbCheckOut.Size = new System.Drawing.Size(184, 22);
            this.txbCheckOut.TabIndex = 68;
            // 
            // txbCheckIn
            // 
            this.txbCheckIn.Location = new System.Drawing.Point(118, 104);
            this.txbCheckIn.MaxLength = 30;
            this.txbCheckIn.Multiline = true;
            this.txbCheckIn.Name = "txbCheckIn";
            this.txbCheckIn.Size = new System.Drawing.Size(184, 22);
            this.txbCheckIn.TabIndex = 67;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.Location = new System.Drawing.Point(437, 104);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(212, 22);
            this.dtCheckOut.TabIndex = 66;
            this.dtCheckOut.CloseUp += new System.EventHandler(this.dtCheckOut_CloseUp);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckIn.Location = new System.Drawing.Point(118, 104);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(212, 22);
            this.dtCheckIn.TabIndex = 65;
            this.dtCheckIn.CloseUp += new System.EventHandler(this.dtCheckIn_CloseUp);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(694, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 49);
            this.btnTimKiem.TabIndex = 64;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lvDanhSachDatPhong
            // 
            this.lvDanhSachDatPhong.BackColor = System.Drawing.Color.White;
            this.lvDanhSachDatPhong.CheckBoxes = true;
            this.lvDanhSachDatPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaThuePhong,
            this.clTenKhachHang,
            this.clTenPhong,
            this.clSoNguoi,
            this.clCheckIn,
            this.clCheckOut,
            this.colTienDat});
            this.lvDanhSachDatPhong.FullRowSelect = true;
            this.lvDanhSachDatPhong.GridLines = true;
            this.lvDanhSachDatPhong.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.lvDanhSachDatPhong.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvDanhSachDatPhong.Location = new System.Drawing.Point(3, 132);
            this.lvDanhSachDatPhong.Name = "lvDanhSachDatPhong";
            this.lvDanhSachDatPhong.ShowItemToolTips = true;
            this.lvDanhSachDatPhong.Size = new System.Drawing.Size(809, 389);
            this.lvDanhSachDatPhong.TabIndex = 62;
            this.lvDanhSachDatPhong.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachDatPhong.View = System.Windows.Forms.View.Details;
            this.lvDanhSachDatPhong.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDanhSachDatPhong_ItemChecked);
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
            // colTienDat
            // 
            this.colTienDat.Text = "Tiền đặt cọc";
            this.colTienDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTienDat.Width = 85;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(684, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 39);
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(620, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 39);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(522, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.Chocolate;
            this.btnNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.ForeColor = System.Drawing.Color.White;
            this.btnNhanPhong.Location = new System.Drawing.Point(7, 3);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(105, 39);
            this.btnNhanPhong.TabIndex = 72;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(438, 77);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(116, 21);
            this.cbPhong.TabIndex = 73;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(380, 77);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(52, 16);
            this.lblPhong.TabIndex = 74;
            this.lblPhong.Text = "Phòng";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(24, 77);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(88, 16);
            this.lblKhachHang.TabIndex = 75;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // txbKhachHang
            // 
            this.txbKhachHang.Location = new System.Drawing.Point(118, 76);
            this.txbKhachHang.MaxLength = 50;
            this.txbKhachHang.Multiline = true;
            this.txbKhachHang.Name = "txbKhachHang";
            this.txbKhachHang.Size = new System.Drawing.Size(212, 22);
            this.txbKhachHang.TabIndex = 76;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(744, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(54, 39);
            this.btnXem.TabIndex = 77;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblCheck_NhanPhong
            // 
            this.lblCheck_NhanPhong.AutoSize = true;
            this.lblCheck_NhanPhong.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_NhanPhong.Location = new System.Drawing.Point(115, 16);
            this.lblCheck_NhanPhong.Name = "lblCheck_NhanPhong";
            this.lblCheck_NhanPhong.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_NhanPhong.TabIndex = 78;
            this.lblCheck_NhanPhong.Text = "label1";
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSapXep.Location = new System.Drawing.Point(255, 36);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(65, 16);
            this.lblSapXep.TabIndex = 80;
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
            this.cbSapXep.Location = new System.Drawing.Point(326, 35);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(149, 21);
            this.cbSapXep.TabIndex = 79;
            // 
            // UC_DanhSachDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblSapXep);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.lblCheck_NhanPhong);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txbKhachHang);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.txbCheckOut);
            this.Controls.Add(this.txbCheckIn);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lvDanhSachDatPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UC_DanhSachDatPhong";
            this.Size = new System.Drawing.Size(815, 541);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txbCheckOut;
        private System.Windows.Forms.TextBox txbCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ListView lvDanhSachDatPhong;
        private System.Windows.Forms.ColumnHeader colMaThuePhong;
        private System.Windows.Forms.ColumnHeader clTenKhachHang;
        private System.Windows.Forms.ColumnHeader clTenPhong;
        private System.Windows.Forms.ColumnHeader clSoNguoi;
        private System.Windows.Forms.ColumnHeader clCheckIn;
        private System.Windows.Forms.ColumnHeader clCheckOut;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.ColumnHeader colTienDat;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txbKhachHang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblCheck_NhanPhong;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cbSapXep;
    }
}
