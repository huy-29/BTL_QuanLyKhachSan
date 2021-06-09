namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.GiaTheoThoiDiem
{
    partial class UC_GiaTheoThoiDiem
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
            this.lvGiaTheoThoiDiem = new System.Windows.Forms.ListView();
            this.colMaMucGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenMucGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDonGiaNgay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDonGiaGio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgayBatDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgayKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txbNgayBatDau = new System.Windows.Forms.TextBox();
            this.txbNgayKetThuc = new System.Windows.Forms.TextBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblGiaNgay = new System.Windows.Forms.Label();
            this.lblGiaGio = new System.Windows.Forms.Label();
            this.txbMinNgay = new System.Windows.Forms.TextBox();
            this.txbMaxNgay = new System.Windows.Forms.TextBox();
            this.lblMinNgay = new System.Windows.Forms.Label();
            this.lblMaxNgay = new System.Windows.Forms.Label();
            this.lblMaxGio = new System.Windows.Forms.Label();
            this.lblMinGio = new System.Windows.Forms.Label();
            this.txbMaxGio = new System.Windows.Forms.TextBox();
            this.txbMinGio = new System.Windows.Forms.TextBox();
            this.lblTenMucGia = new System.Windows.Forms.Label();
            this.cbTenMucGia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvGiaTheoThoiDiem
            // 
            this.lvGiaTheoThoiDiem.BackColor = System.Drawing.Color.White;
            this.lvGiaTheoThoiDiem.CheckBoxes = true;
            this.lvGiaTheoThoiDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaMucGia,
            this.clTenMucGia,
            this.clDonGiaNgay,
            this.clDonGiaGio,
            this.clSoNguoi,
            this.clNgayBatDau,
            this.clNgayKetThuc,
            this.clLoaiPhong});
            this.lvGiaTheoThoiDiem.FullRowSelect = true;
            this.lvGiaTheoThoiDiem.GridLines = true;
            this.lvGiaTheoThoiDiem.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.lvGiaTheoThoiDiem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvGiaTheoThoiDiem.Location = new System.Drawing.Point(6, 147);
            this.lvGiaTheoThoiDiem.Name = "lvGiaTheoThoiDiem";
            this.lvGiaTheoThoiDiem.Size = new System.Drawing.Size(806, 378);
            this.lvGiaTheoThoiDiem.TabIndex = 47;
            this.lvGiaTheoThoiDiem.UseCompatibleStateImageBehavior = false;
            this.lvGiaTheoThoiDiem.View = System.Windows.Forms.View.Details;
            this.lvGiaTheoThoiDiem.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvGiaTheoThoiDiem_ItemChecked);
            // 
            // colMaMucGia
            // 
            this.colMaMucGia.Text = "Mã mức giá";
            this.colMaMucGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaMucGia.Width = 61;
            // 
            // clTenMucGia
            // 
            this.clTenMucGia.Text = "Tên mức giá";
            this.clTenMucGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenMucGia.Width = 131;
            // 
            // clDonGiaNgay
            // 
            this.clDonGiaNgay.Text = "Đơn giá ngày";
            this.clDonGiaNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDonGiaNgay.Width = 78;
            // 
            // clDonGiaGio
            // 
            this.clDonGiaGio.Text = "Đơn giá giờ";
            this.clDonGiaGio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDonGiaGio.Width = 71;
            // 
            // clSoNguoi
            // 
            this.clSoNguoi.Text = "Số người";
            this.clSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSoNguoi.Width = 59;
            // 
            // clNgayBatDau
            // 
            this.clNgayBatDau.Text = "Ngày bắt đầu";
            this.clNgayBatDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clNgayBatDau.Width = 96;
            // 
            // clNgayKetThuc
            // 
            this.clNgayKetThuc.Text = "Ngày kết thúc";
            this.clNgayKetThuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clNgayKetThuc.Width = 96;
            // 
            // clLoaiPhong
            // 
            this.clLoaiPhong.Text = "Loại Phòng";
            this.clLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clLoaiPhong.Width = 146;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(758, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 39);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(694, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 39);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(596, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(259, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(113, 119);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(177, 22);
            this.dtNgayBatDau.TabIndex = 50;
            this.dtNgayBatDau.CloseUp += new System.EventHandler(this.dtNgayBatDau_CloseUp);
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(442, 119);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(177, 22);
            this.dtNgayKetThuc.TabIndex = 51;
            this.dtNgayKetThuc.CloseUp += new System.EventHandler(this.dtNgayKetThuc_CloseUp);
            // 
            // txbNgayBatDau
            // 
            this.txbNgayBatDau.Location = new System.Drawing.Point(113, 119);
            this.txbNgayBatDau.MaxLength = 15;
            this.txbNgayBatDau.Multiline = true;
            this.txbNgayBatDau.Name = "txbNgayBatDau";
            this.txbNgayBatDau.Size = new System.Drawing.Size(116, 22);
            this.txbNgayBatDau.TabIndex = 52;
            // 
            // txbNgayKetThuc
            // 
            this.txbNgayKetThuc.Location = new System.Drawing.Point(442, 119);
            this.txbNgayKetThuc.MaxLength = 15;
            this.txbNgayKetThuc.Multiline = true;
            this.txbNgayKetThuc.Name = "txbNgayKetThuc";
            this.txbNgayKetThuc.Size = new System.Drawing.Size(116, 22);
            this.txbNgayKetThuc.TabIndex = 53;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(6, 124);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(101, 16);
            this.lblNgayBatDau.TabIndex = 55;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(334, 124);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(102, 16);
            this.lblNgayKetThuc.TabIndex = 56;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(113, 43);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(177, 21);
            this.cbLoaiPhong.TabIndex = 57;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(22, 43);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(85, 16);
            this.lblLoaiPhong.TabIndex = 58;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // lblGiaNgay
            // 
            this.lblGiaNgay.AutoSize = true;
            this.lblGiaNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNgay.Location = new System.Drawing.Point(6, 97);
            this.lblGiaNgay.Name = "lblGiaNgay";
            this.lblGiaNgay.Size = new System.Drawing.Size(70, 16);
            this.lblGiaNgay.TabIndex = 59;
            this.lblGiaNgay.Text = "Giá ngày";
            // 
            // lblGiaGio
            // 
            this.lblGiaGio.AutoSize = true;
            this.lblGiaGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGio.Location = new System.Drawing.Point(6, 74);
            this.lblGiaGio.Name = "lblGiaGio";
            this.lblGiaGio.Size = new System.Drawing.Size(58, 16);
            this.lblGiaGio.TabIndex = 60;
            this.lblGiaGio.Text = "Giá giờ";
            // 
            // txbMinNgay
            // 
            this.txbMinNgay.Location = new System.Drawing.Point(113, 96);
            this.txbMinNgay.MaxLength = 10;
            this.txbMinNgay.Name = "txbMinNgay";
            this.txbMinNgay.Size = new System.Drawing.Size(116, 20);
            this.txbMinNgay.TabIndex = 61;
            // 
            // txbMaxNgay
            // 
            this.txbMaxNgay.Location = new System.Drawing.Point(442, 97);
            this.txbMaxNgay.MaxLength = 10;
            this.txbMaxNgay.Name = "txbMaxNgay";
            this.txbMaxNgay.Size = new System.Drawing.Size(116, 20);
            this.txbMaxNgay.TabIndex = 62;
            // 
            // lblMinNgay
            // 
            this.lblMinNgay.AutoSize = true;
            this.lblMinNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinNgay.Location = new System.Drawing.Point(82, 99);
            this.lblMinNgay.Name = "lblMinNgay";
            this.lblMinNgay.Size = new System.Drawing.Size(32, 16);
            this.lblMinNgay.TabIndex = 63;
            this.lblMinNgay.Text = "Min";
            // 
            // lblMaxNgay
            // 
            this.lblMaxNgay.AutoSize = true;
            this.lblMaxNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNgay.Location = new System.Drawing.Point(400, 99);
            this.lblMaxNgay.Name = "lblMaxNgay";
            this.lblMaxNgay.Size = new System.Drawing.Size(36, 16);
            this.lblMaxNgay.TabIndex = 64;
            this.lblMaxNgay.Text = "Max";
            // 
            // lblMaxGio
            // 
            this.lblMaxGio.AutoSize = true;
            this.lblMaxGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxGio.Location = new System.Drawing.Point(400, 75);
            this.lblMaxGio.Name = "lblMaxGio";
            this.lblMaxGio.Size = new System.Drawing.Size(36, 16);
            this.lblMaxGio.TabIndex = 68;
            this.lblMaxGio.Text = "Max";
            // 
            // lblMinGio
            // 
            this.lblMinGio.AutoSize = true;
            this.lblMinGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinGio.Location = new System.Drawing.Point(82, 75);
            this.lblMinGio.Name = "lblMinGio";
            this.lblMinGio.Size = new System.Drawing.Size(32, 16);
            this.lblMinGio.TabIndex = 67;
            this.lblMinGio.Text = "Min";
            // 
            // txbMaxGio
            // 
            this.txbMaxGio.Location = new System.Drawing.Point(442, 75);
            this.txbMaxGio.MaxLength = 10;
            this.txbMaxGio.Name = "txbMaxGio";
            this.txbMaxGio.Size = new System.Drawing.Size(116, 20);
            this.txbMaxGio.TabIndex = 66;
            // 
            // txbMinGio
            // 
            this.txbMinGio.Location = new System.Drawing.Point(113, 74);
            this.txbMinGio.MaxLength = 10;
            this.txbMinGio.Name = "txbMinGio";
            this.txbMinGio.Size = new System.Drawing.Size(116, 20);
            this.txbMinGio.TabIndex = 65;
            // 
            // lblTenMucGia
            // 
            this.lblTenMucGia.AutoSize = true;
            this.lblTenMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMucGia.Location = new System.Drawing.Point(343, 45);
            this.lblTenMucGia.Name = "lblTenMucGia";
            this.lblTenMucGia.Size = new System.Drawing.Size(93, 16);
            this.lblTenMucGia.TabIndex = 70;
            this.lblTenMucGia.Text = "Tên mức giá";
            // 
            // cbTenMucGia
            // 
            this.cbTenMucGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenMucGia.FormattingEnabled = true;
            this.cbTenMucGia.Location = new System.Drawing.Point(442, 44);
            this.cbTenMucGia.Name = "cbTenMucGia";
            this.cbTenMucGia.Size = new System.Drawing.Size(177, 21);
            this.cbTenMucGia.TabIndex = 69;
            // 
            // UC_GiaTheoThoiDiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblTenMucGia);
            this.Controls.Add(this.cbTenMucGia);
            this.Controls.Add(this.lblMaxGio);
            this.Controls.Add(this.lblMinGio);
            this.Controls.Add(this.txbMaxGio);
            this.Controls.Add(this.txbMinGio);
            this.Controls.Add(this.lblMaxNgay);
            this.Controls.Add(this.lblMinNgay);
            this.Controls.Add(this.txbMaxNgay);
            this.Controls.Add(this.txbMinNgay);
            this.Controls.Add(this.lblGiaGio);
            this.Controls.Add(this.lblGiaNgay);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.txbNgayKetThuc);
            this.Controls.Add(this.txbNgayBatDau);
            this.Controls.Add(this.dtNgayKetThuc);
            this.Controls.Add(this.dtNgayBatDau);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lvGiaTheoThoiDiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "UC_GiaTheoThoiDiem";
            this.Size = new System.Drawing.Size(815, 541);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvGiaTheoThoiDiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader clTenMucGia;
        private System.Windows.Forms.ColumnHeader clDonGiaNgay;
        private System.Windows.Forms.ColumnHeader clDonGiaGio;
        private System.Windows.Forms.ColumnHeader clSoNguoi;
        private System.Windows.Forms.ColumnHeader clNgayBatDau;
        private System.Windows.Forms.ColumnHeader colMaMucGia;
        private System.Windows.Forms.ColumnHeader clNgayKetThuc;
        private System.Windows.Forms.ColumnHeader clLoaiPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.TextBox txbNgayBatDau;
        private System.Windows.Forms.TextBox txbNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblGiaNgay;
        private System.Windows.Forms.Label lblGiaGio;
        private System.Windows.Forms.TextBox txbMinNgay;
        private System.Windows.Forms.TextBox txbMaxNgay;
        private System.Windows.Forms.Label lblMinNgay;
        private System.Windows.Forms.Label lblMaxNgay;
        private System.Windows.Forms.Label lblMaxGio;
        private System.Windows.Forms.Label lblMinGio;
        private System.Windows.Forms.TextBox txbMaxGio;
        private System.Windows.Forms.TextBox txbMinGio;
        private System.Windows.Forms.Label lblTenMucGia;
        private System.Windows.Forms.ComboBox cbTenMucGia;
    }
}
