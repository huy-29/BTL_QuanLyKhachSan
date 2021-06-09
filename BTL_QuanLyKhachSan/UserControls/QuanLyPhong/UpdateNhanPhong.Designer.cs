namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    partial class UpdateNhanPhong
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
            this.chkDatPhong = new System.Windows.Forms.CheckBox();
            this.lblTienDat = new System.Windows.Forms.Label();
            this.txbTienDat = new System.Windows.Forms.TextBox();
            this.lblDonViTienDat = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.cbMucGia = new System.Windows.Forms.ComboBox();
            this.lblMucGia = new System.Windows.Forms.Label();
            this.cbPhuongThuc = new System.Windows.Forms.ComboBox();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblCheck_Phong = new System.Windows.Forms.Label();
            this.lblCheck_MucGia = new System.Windows.Forms.Label();
            this.lblCheck_PhuongThuc = new System.Windows.Forms.Label();
            this.txbGiaThemNguoi = new System.Windows.Forms.TextBox();
            this.lblGiaThemNguoi = new System.Windows.Forms.Label();
            this.pnlGiaTrongKhoangNgay = new System.Windows.Forms.Panel();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblCheck_TienDat = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.lblMaThuePhong = new System.Windows.Forms.Label();
            this.txbMaThuePhong = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txbDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheck_TenKH = new System.Windows.Forms.Label();
            this.lblCheck_DienThoai = new System.Windows.Forms.Label();
            this.lblCheck_DiaChi = new System.Windows.Forms.Label();
            this.lblCheck_CheckOut = new System.Windows.Forms.Label();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.txbSoNguoi = new System.Windows.Forms.TextBox();
            this.lblCheck_SoNguoi = new System.Windows.Forms.Label();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlGiaTrongKhoangNgay.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkDatPhong
            // 
            this.chkDatPhong.AutoSize = true;
            this.chkDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDatPhong.Location = new System.Drawing.Point(466, 8);
            this.chkDatPhong.Name = "chkDatPhong";
            this.chkDatPhong.Size = new System.Drawing.Size(88, 20);
            this.chkDatPhong.TabIndex = 14;
            this.chkDatPhong.Text = "Đặt phòng";
            this.chkDatPhong.UseVisualStyleBackColor = true;
            this.chkDatPhong.CheckedChanged += new System.EventHandler(this.chkDatPhong_CheckedChanged);
            // 
            // lblTienDat
            // 
            this.lblTienDat.AutoSize = true;
            this.lblTienDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDat.Location = new System.Drawing.Point(560, 9);
            this.lblTienDat.Name = "lblTienDat";
            this.lblTienDat.Size = new System.Drawing.Size(65, 16);
            this.lblTienDat.TabIndex = 1;
            this.lblTienDat.Text = "Tiền đặt";
            // 
            // txbTienDat
            // 
            this.txbTienDat.Location = new System.Drawing.Point(631, 8);
            this.txbTienDat.MaxLength = 12;
            this.txbTienDat.Name = "txbTienDat";
            this.txbTienDat.Size = new System.Drawing.Size(155, 20);
            this.txbTienDat.TabIndex = 15;
            // 
            // lblDonViTienDat
            // 
            this.lblDonViTienDat.AutoSize = true;
            this.lblDonViTienDat.BackColor = System.Drawing.Color.White;
            this.lblDonViTienDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTienDat.Location = new System.Drawing.Point(741, 11);
            this.lblDonViTienDat.Name = "lblDonViTienDat";
            this.lblDonViTienDat.Size = new System.Drawing.Size(36, 16);
            this.lblDonViTienDat.TabIndex = 13;
            this.lblDonViTienDat.Text = "VNĐ";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(464, 48);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(52, 16);
            this.lblPhong.TabIndex = 14;
            this.lblPhong.Text = "Phòng";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(521, 47);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(177, 21);
            this.cbPhong.TabIndex = 16;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // cbMucGia
            // 
            this.cbMucGia.FormattingEnabled = true;
            this.cbMucGia.Location = new System.Drawing.Point(521, 92);
            this.cbMucGia.Name = "cbMucGia";
            this.cbMucGia.Size = new System.Drawing.Size(179, 21);
            this.cbMucGia.TabIndex = 17;
            this.cbMucGia.SelectedIndexChanged += new System.EventHandler(this.cbMucGia_SelectedIndexChanged);
            this.cbMucGia.SelectedValueChanged += new System.EventHandler(this.cbMucGia_SelectedValueChanged);
            // 
            // lblMucGia
            // 
            this.lblMucGia.AutoSize = true;
            this.lblMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucGia.Location = new System.Drawing.Point(454, 96);
            this.lblMucGia.Name = "lblMucGia";
            this.lblMucGia.Size = new System.Drawing.Size(62, 16);
            this.lblMucGia.TabIndex = 16;
            this.lblMucGia.Text = "Mức giá";
            // 
            // cbPhuongThuc
            // 
            this.cbPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuongThuc.FormattingEnabled = true;
            this.cbPhuongThuc.Location = new System.Drawing.Point(521, 189);
            this.cbPhuongThuc.Name = "cbPhuongThuc";
            this.cbPhuongThuc.Size = new System.Drawing.Size(179, 21);
            this.cbPhuongThuc.TabIndex = 19;
            this.cbPhuongThuc.SelectedIndexChanged += new System.EventHandler(this.cbPhuongThuc_SelectedIndexChanged);
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuongThuc.Location = new System.Drawing.Point(420, 190);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(96, 16);
            this.lblPhuongThuc.TabIndex = 18;
            this.lblPhuongThuc.Text = "Phương thức ";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(533, 359);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 42);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(635, 359);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 42);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblCheck_Phong
            // 
            this.lblCheck_Phong.AutoSize = true;
            this.lblCheck_Phong.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_Phong.Location = new System.Drawing.Point(518, 71);
            this.lblCheck_Phong.Name = "lblCheck_Phong";
            this.lblCheck_Phong.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_Phong.TabIndex = 29;
            this.lblCheck_Phong.Text = "label4";
            // 
            // lblCheck_MucGia
            // 
            this.lblCheck_MucGia.AutoSize = true;
            this.lblCheck_MucGia.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_MucGia.Location = new System.Drawing.Point(518, 115);
            this.lblCheck_MucGia.Name = "lblCheck_MucGia";
            this.lblCheck_MucGia.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_MucGia.TabIndex = 30;
            this.lblCheck_MucGia.Text = "label5";
            // 
            // lblCheck_PhuongThuc
            // 
            this.lblCheck_PhuongThuc.AutoSize = true;
            this.lblCheck_PhuongThuc.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_PhuongThuc.Location = new System.Drawing.Point(518, 213);
            this.lblCheck_PhuongThuc.Name = "lblCheck_PhuongThuc";
            this.lblCheck_PhuongThuc.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_PhuongThuc.TabIndex = 31;
            this.lblCheck_PhuongThuc.Text = "label6";
            // 
            // txbGiaThemNguoi
            // 
            this.txbGiaThemNguoi.Location = new System.Drawing.Point(521, 140);
            this.txbGiaThemNguoi.MaxLength = 12;
            this.txbGiaThemNguoi.Name = "txbGiaThemNguoi";
            this.txbGiaThemNguoi.ReadOnly = true;
            this.txbGiaThemNguoi.Size = new System.Drawing.Size(179, 20);
            this.txbGiaThemNguoi.TabIndex = 18;
            // 
            // lblGiaThemNguoi
            // 
            this.lblGiaThemNguoi.AutoSize = true;
            this.lblGiaThemNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaThemNguoi.Location = new System.Drawing.Point(405, 141);
            this.lblGiaThemNguoi.Name = "lblGiaThemNguoi";
            this.lblGiaThemNguoi.Size = new System.Drawing.Size(111, 16);
            this.lblGiaThemNguoi.TabIndex = 34;
            this.lblGiaThemNguoi.Text = "Giá thêm người";
            // 
            // pnlGiaTrongKhoangNgay
            // 
            this.pnlGiaTrongKhoangNgay.Controls.Add(this.lblNgayBatDau);
            this.pnlGiaTrongKhoangNgay.Controls.Add(this.dtNgayKetThuc);
            this.pnlGiaTrongKhoangNgay.Controls.Add(this.dtNgayBatDau);
            this.pnlGiaTrongKhoangNgay.Controls.Add(this.lblNgayKetThuc);
            this.pnlGiaTrongKhoangNgay.Location = new System.Drawing.Point(407, 229);
            this.pnlGiaTrongKhoangNgay.Name = "pnlGiaTrongKhoangNgay";
            this.pnlGiaTrongKhoangNgay.Size = new System.Drawing.Size(378, 100);
            this.pnlGiaTrongKhoangNgay.TabIndex = 37;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(45, 15);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(64, 16);
            this.lblNgayBatDau.TabIndex = 38;
            this.lblNgayBatDau.Text = "Từ ngày";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Enabled = false;
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(115, 57);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(178, 20);
            this.dtNgayKetThuc.TabIndex = 41;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Enabled = false;
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(115, 15);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(178, 20);
            this.dtNgayBatDau.TabIndex = 39;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(34, 61);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(73, 16);
            this.lblNgayKetThuc.TabIndex = 40;
            this.lblNgayKetThuc.Text = "Đến ngày";
            // 
            // lblCheck_TienDat
            // 
            this.lblCheck_TienDat.AutoSize = true;
            this.lblCheck_TienDat.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_TienDat.Location = new System.Drawing.Point(628, 31);
            this.lblCheck_TienDat.Name = "lblCheck_TienDat";
            this.lblCheck_TienDat.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_TienDat.TabIndex = 38;
            this.lblCheck_TienDat.Text = "label4";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(5, 9);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(53, 16);
            this.lblMaKH.TabIndex = 3;
            this.lblMaKH.Text = "Mã KH";
            // 
            // txbMaKH
            // 
            this.txbMaKH.Location = new System.Drawing.Point(64, 6);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.ReadOnly = true;
            this.txbMaKH.Size = new System.Drawing.Size(100, 20);
            this.txbMaKH.TabIndex = 4;
            // 
            // lblMaThuePhong
            // 
            this.lblMaThuePhong.AutoSize = true;
            this.lblMaThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThuePhong.Location = new System.Drawing.Point(204, 11);
            this.lblMaThuePhong.Name = "lblMaThuePhong";
            this.lblMaThuePhong.Size = new System.Drawing.Size(71, 16);
            this.lblMaThuePhong.TabIndex = 5;
            this.lblMaThuePhong.Text = "Mã phiếu";
            // 
            // txbMaThuePhong
            // 
            this.txbMaThuePhong.Location = new System.Drawing.Point(281, 8);
            this.txbMaThuePhong.Name = "txbMaThuePhong";
            this.txbMaThuePhong.ReadOnly = true;
            this.txbMaThuePhong.Size = new System.Drawing.Size(100, 20);
            this.txbMaThuePhong.TabIndex = 6;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(3, 48);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(118, 16);
            this.lblTenKH.TabIndex = 7;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(127, 47);
            this.txbTenKH.MaxLength = 100;
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(207, 20);
            this.txbTenKH.TabIndex = 8;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(42, 93);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(77, 16);
            this.lblDienThoai.TabIndex = 9;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txbDienThoai
            // 
            this.txbDienThoai.Location = new System.Drawing.Point(127, 92);
            this.txbDienThoai.MaxLength = 20;
            this.txbDienThoai.Name = "txbDienThoai";
            this.txbDienThoai.Size = new System.Drawing.Size(207, 20);
            this.txbDienThoai.TabIndex = 9;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(64, 144);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(55, 16);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(127, 140);
            this.txbDiaChi.MaxLength = 100;
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(207, 20);
            this.txbDiaChi.TabIndex = 10;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(53, 244);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(67, 16);
            this.lblCheckIn.TabIndex = 20;
            this.lblCheckIn.Text = "Check in";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckIn.Location = new System.Drawing.Point(126, 244);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(178, 20);
            this.dtCheckIn.TabIndex = 12;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(44, 290);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(76, 16);
            this.lblCheckOut.TabIndex = 22;
            this.lblCheckOut.Text = "Check out";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.Location = new System.Drawing.Point(126, 286);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(178, 20);
            this.dtCheckOut.TabIndex = 13;
            // 
            // lblCheck_TenKH
            // 
            this.lblCheck_TenKH.AutoSize = true;
            this.lblCheck_TenKH.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_TenKH.Location = new System.Drawing.Point(127, 68);
            this.lblCheck_TenKH.Name = "lblCheck_TenKH";
            this.lblCheck_TenKH.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_TenKH.TabIndex = 26;
            this.lblCheck_TenKH.Text = "label1";
            // 
            // lblCheck_DienThoai
            // 
            this.lblCheck_DienThoai.AutoSize = true;
            this.lblCheck_DienThoai.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_DienThoai.Location = new System.Drawing.Point(127, 115);
            this.lblCheck_DienThoai.Name = "lblCheck_DienThoai";
            this.lblCheck_DienThoai.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_DienThoai.TabIndex = 27;
            this.lblCheck_DienThoai.Text = "label2";
            // 
            // lblCheck_DiaChi
            // 
            this.lblCheck_DiaChi.AutoSize = true;
            this.lblCheck_DiaChi.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_DiaChi.Location = new System.Drawing.Point(124, 163);
            this.lblCheck_DiaChi.Name = "lblCheck_DiaChi";
            this.lblCheck_DiaChi.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_DiaChi.TabIndex = 28;
            this.lblCheck_DiaChi.Text = "label3";
            // 
            // lblCheck_CheckOut
            // 
            this.lblCheck_CheckOut.AutoSize = true;
            this.lblCheck_CheckOut.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_CheckOut.Location = new System.Drawing.Point(126, 309);
            this.lblCheck_CheckOut.Name = "lblCheck_CheckOut";
            this.lblCheck_CheckOut.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_CheckOut.TabIndex = 33;
            this.lblCheck_CheckOut.Text = "label8";
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguoi.Location = new System.Drawing.Point(51, 190);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(69, 16);
            this.lblSoNguoi.TabIndex = 39;
            this.lblSoNguoi.Text = "Số người";
            // 
            // txbSoNguoi
            // 
            this.txbSoNguoi.Location = new System.Drawing.Point(127, 189);
            this.txbSoNguoi.MaxLength = 100;
            this.txbSoNguoi.Multiline = true;
            this.txbSoNguoi.Name = "txbSoNguoi";
            this.txbSoNguoi.Size = new System.Drawing.Size(207, 20);
            this.txbSoNguoi.TabIndex = 11;
            // 
            // lblCheck_SoNguoi
            // 
            this.lblCheck_SoNguoi.AutoSize = true;
            this.lblCheck_SoNguoi.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_SoNguoi.Location = new System.Drawing.Point(124, 212);
            this.lblCheck_SoNguoi.Name = "lblCheck_SoNguoi";
            this.lblCheck_SoNguoi.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_SoNguoi.TabIndex = 41;
            this.lblCheck_SoNguoi.Text = "label3";
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.lblCheck_SoNguoi);
            this.pnlThongTin.Controls.Add(this.txbSoNguoi);
            this.pnlThongTin.Controls.Add(this.lblSoNguoi);
            this.pnlThongTin.Controls.Add(this.lblCheck_TienDat);
            this.pnlThongTin.Controls.Add(this.pnlGiaTrongKhoangNgay);
            this.pnlThongTin.Controls.Add(this.txbGiaThemNguoi);
            this.pnlThongTin.Controls.Add(this.lblGiaThemNguoi);
            this.pnlThongTin.Controls.Add(this.lblCheck_CheckOut);
            this.pnlThongTin.Controls.Add(this.lblCheck_PhuongThuc);
            this.pnlThongTin.Controls.Add(this.lblCheck_MucGia);
            this.pnlThongTin.Controls.Add(this.lblCheck_Phong);
            this.pnlThongTin.Controls.Add(this.lblCheck_DiaChi);
            this.pnlThongTin.Controls.Add(this.lblCheck_DienThoai);
            this.pnlThongTin.Controls.Add(this.lblCheck_TenKH);
            this.pnlThongTin.Controls.Add(this.dtCheckOut);
            this.pnlThongTin.Controls.Add(this.lblCheckOut);
            this.pnlThongTin.Controls.Add(this.dtCheckIn);
            this.pnlThongTin.Controls.Add(this.lblCheckIn);
            this.pnlThongTin.Controls.Add(this.cbPhuongThuc);
            this.pnlThongTin.Controls.Add(this.lblPhuongThuc);
            this.pnlThongTin.Controls.Add(this.cbMucGia);
            this.pnlThongTin.Controls.Add(this.lblMucGia);
            this.pnlThongTin.Controls.Add(this.cbPhong);
            this.pnlThongTin.Controls.Add(this.lblPhong);
            this.pnlThongTin.Controls.Add(this.lblDonViTienDat);
            this.pnlThongTin.Controls.Add(this.txbDiaChi);
            this.pnlThongTin.Controls.Add(this.lblDiaChi);
            this.pnlThongTin.Controls.Add(this.txbDienThoai);
            this.pnlThongTin.Controls.Add(this.lblDienThoai);
            this.pnlThongTin.Controls.Add(this.txbTenKH);
            this.pnlThongTin.Controls.Add(this.lblTenKH);
            this.pnlThongTin.Controls.Add(this.txbMaThuePhong);
            this.pnlThongTin.Controls.Add(this.lblMaThuePhong);
            this.pnlThongTin.Controls.Add(this.txbMaKH);
            this.pnlThongTin.Controls.Add(this.lblMaKH);
            this.pnlThongTin.Controls.Add(this.txbTienDat);
            this.pnlThongTin.Controls.Add(this.lblTienDat);
            this.pnlThongTin.Controls.Add(this.chkDatPhong);
            this.pnlThongTin.Location = new System.Drawing.Point(12, 7);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(836, 342);
            this.pnlThongTin.TabIndex = 42;
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 20000;
            this.tt.InitialDelay = 500;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 100;
            this.tt.ShowAlways = true;
            this.tt.ToolTipTitle = "Các ngày đã sử dụng";
            // 
            // UpdateNhanPhong
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(860, 413);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateNhanPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateNhanPhong";
            this.pnlGiaTrongKhoangNgay.ResumeLayout(false);
            this.pnlGiaTrongKhoangNgay.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDatPhong;
        private System.Windows.Forms.Label lblTienDat;
        private System.Windows.Forms.TextBox txbTienDat;
        private System.Windows.Forms.Label lblDonViTienDat;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbMucGia;
        private System.Windows.Forms.Label lblMucGia;
        private System.Windows.Forms.ComboBox cbPhuongThuc;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblCheck_Phong;
        private System.Windows.Forms.Label lblCheck_MucGia;
        private System.Windows.Forms.Label lblCheck_PhuongThuc;
        private System.Windows.Forms.TextBox txbGiaThemNguoi;
        private System.Windows.Forms.Label lblGiaThemNguoi;
        private System.Windows.Forms.Panel pnlGiaTrongKhoangNgay;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblCheck_TienDat;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label lblMaThuePhong;
        private System.Windows.Forms.TextBox txbMaThuePhong;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txbDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label lblCheck_TenKH;
        private System.Windows.Forms.Label lblCheck_DienThoai;
        private System.Windows.Forms.Label lblCheck_DiaChi;
        private System.Windows.Forms.Label lblCheck_CheckOut;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.TextBox txbSoNguoi;
        private System.Windows.Forms.Label lblCheck_SoNguoi;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.ToolTip tt;
    }
}