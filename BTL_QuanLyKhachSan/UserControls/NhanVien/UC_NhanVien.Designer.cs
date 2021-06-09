
namespace BTL_QuanLyKhachSan.UserControls.NhanVien
{
    partial class UC_NhanVien
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Yellow, System.Drawing.Color.Empty, null);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.colTaiKhoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.chkMe = new System.Windows.Forms.CheckBox();
            this.cbTimChucVu = new System.Windows.Forms.ComboBox();
            this.lblTimChucVu = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.flpThongTin = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.lblCheck_TenDangNhap = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.pnlMatKhauCu = new System.Windows.Forms.Panel();
            this.lblCheck_MatKhauCu = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.lblCheck_MatKhau = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.pnlNhapLaiMK = new System.Windows.Forms.Panel();
            this.lblCheck_NhapLaiMK = new System.Windows.Forms.Label();
            this.lblNhapLaiMK = new System.Windows.Forms.Label();
            this.txbNhapLaiMK = new System.Windows.Forms.TextBox();
            this.pnlChucVu = new System.Windows.Forms.Panel();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.lblCheck_ChucVu = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.pnlHoTen = new System.Windows.Forms.Panel();
            this.lblCheck_HoTen = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.flpThongTin.SuspendLayout();
            this.pnlTenDangNhap.SuspendLayout();
            this.pnlMatKhauCu.SuspendLayout();
            this.pnlMatKhau.SuspendLayout();
            this.pnlNhapLaiMK.SuspendLayout();
            this.pnlChucVu.SuspendLayout();
            this.pnlHoTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Maroon;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(122, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 30);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(232, 10);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txbTimKiem.TabIndex = 28;
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.CheckBoxes = true;
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTaiKhoan,
            this.colTenNhanVien,
            this.colChucVu});
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.HideSelection = false;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            this.lvNhanVien.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10});
            this.lvNhanVien.Location = new System.Drawing.Point(0, 76);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(476, 436);
            this.lvNhanVien.TabIndex = 37;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvNhanVien_ItemChecked);
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.Text = "Tài khoản";
            this.colTaiKhoan.Width = 112;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Text = "Họ tên";
            this.colTenNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenNhanVien.Width = 193;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colChucVu.Width = 164;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(700, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 39);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(636, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 39);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(538, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chkMe
            // 
            this.chkMe.AutoSize = true;
            this.chkMe.Location = new System.Drawing.Point(43, 40);
            this.chkMe.Name = "chkMe";
            this.chkMe.Size = new System.Drawing.Size(41, 17);
            this.chkMe.TabIndex = 38;
            this.chkMe.Text = "Me";
            this.chkMe.UseVisualStyleBackColor = true;
            this.chkMe.CheckedChanged += new System.EventHandler(this.chkMe_CheckedChanged);
            // 
            // cbTimChucVu
            // 
            this.cbTimChucVu.FormattingEnabled = true;
            this.cbTimChucVu.Location = new System.Drawing.Point(232, 38);
            this.cbTimChucVu.Name = "cbTimChucVu";
            this.cbTimChucVu.Size = new System.Drawing.Size(162, 21);
            this.cbTimChucVu.TabIndex = 39;
            this.cbTimChucVu.SelectedIndexChanged += new System.EventHandler(this.cbTimChucVu_SelectedIndexChanged);
            // 
            // lblTimChucVu
            // 
            this.lblTimChucVu.AutoSize = true;
            this.lblTimChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimChucVu.Location = new System.Drawing.Point(164, 39);
            this.lblTimChucVu.Name = "lblTimChucVu";
            this.lblTimChucVu.Size = new System.Drawing.Size(62, 16);
            this.lblTimChucVu.TabIndex = 40;
            this.lblTimChucVu.Text = "Chức vụ";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(120, 381);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(120, 3, 3, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Crimson;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(220, 381);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // flpThongTin
            // 
            this.flpThongTin.Controls.Add(this.pnlTenDangNhap);
            this.flpThongTin.Controls.Add(this.pnlMatKhauCu);
            this.flpThongTin.Controls.Add(this.pnlMatKhau);
            this.flpThongTin.Controls.Add(this.pnlNhapLaiMK);
            this.flpThongTin.Controls.Add(this.pnlHoTen);
            this.flpThongTin.Controls.Add(this.pnlChucVu);
            this.flpThongTin.Controls.Add(this.btnLuu);
            this.flpThongTin.Controls.Add(this.btnHuy);
            this.flpThongTin.Location = new System.Drawing.Point(484, 76);
            this.flpThongTin.Name = "flpThongTin";
            this.flpThongTin.Size = new System.Drawing.Size(328, 436);
            this.flpThongTin.TabIndex = 41;
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.Controls.Add(this.lblCheck_TenDangNhap);
            this.pnlTenDangNhap.Controls.Add(this.lblTenDangNhap);
            this.pnlTenDangNhap.Controls.Add(this.txbTenDangNhap);
            this.pnlTenDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(322, 63);
            this.pnlTenDangNhap.TabIndex = 44;
            // 
            // lblCheck_TenDangNhap
            // 
            this.lblCheck_TenDangNhap.AutoSize = true;
            this.lblCheck_TenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_TenDangNhap.Location = new System.Drawing.Point(118, 43);
            this.lblCheck_TenDangNhap.Name = "lblCheck_TenDangNhap";
            this.lblCheck_TenDangNhap.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_TenDangNhap.TabIndex = 21;
            this.lblCheck_TenDangNhap.Text = "label1";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(3, 21);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(112, 16);
            this.lblTenDangNhap.TabIndex = 13;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(121, 20);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(201, 20);
            this.txbTenDangNhap.TabIndex = 9;
            // 
            // pnlMatKhauCu
            // 
            this.pnlMatKhauCu.Controls.Add(this.lblCheck_MatKhauCu);
            this.pnlMatKhauCu.Controls.Add(this.lblMatKhauCu);
            this.pnlMatKhauCu.Controls.Add(this.txbMatKhauCu);
            this.pnlMatKhauCu.Location = new System.Drawing.Point(0, 63);
            this.pnlMatKhauCu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMatKhauCu.Name = "pnlMatKhauCu";
            this.pnlMatKhauCu.Size = new System.Drawing.Size(322, 63);
            this.pnlMatKhauCu.TabIndex = 47;
            // 
            // lblCheck_MatKhauCu
            // 
            this.lblCheck_MatKhauCu.AutoSize = true;
            this.lblCheck_MatKhauCu.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_MatKhauCu.Location = new System.Drawing.Point(118, 43);
            this.lblCheck_MatKhauCu.Name = "lblCheck_MatKhauCu";
            this.lblCheck_MatKhauCu.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_MatKhauCu.TabIndex = 21;
            this.lblCheck_MatKhauCu.Text = "label1";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauCu.Location = new System.Drawing.Point(23, 21);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(90, 16);
            this.lblMatKhauCu.TabIndex = 13;
            this.lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(121, 20);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(201, 20);
            this.txbMatKhauCu.TabIndex = 9;
            this.txbMatKhauCu.UseSystemPasswordChar = true;
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.Controls.Add(this.lblCheck_MatKhau);
            this.pnlMatKhau.Controls.Add(this.lblMatKhau);
            this.pnlMatKhau.Controls.Add(this.txbMatKhau);
            this.pnlMatKhau.Location = new System.Drawing.Point(0, 126);
            this.pnlMatKhau.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(322, 63);
            this.pnlMatKhau.TabIndex = 45;
            // 
            // lblCheck_MatKhau
            // 
            this.lblCheck_MatKhau.AutoSize = true;
            this.lblCheck_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_MatKhau.Location = new System.Drawing.Point(118, 43);
            this.lblCheck_MatKhau.Name = "lblCheck_MatKhau";
            this.lblCheck_MatKhau.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_MatKhau.TabIndex = 21;
            this.lblCheck_MatKhau.Text = "label1";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(23, 21);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 16);
            this.lblMatKhau.TabIndex = 13;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(121, 20);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(201, 20);
            this.txbMatKhau.TabIndex = 9;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // pnlNhapLaiMK
            // 
            this.pnlNhapLaiMK.Controls.Add(this.lblCheck_NhapLaiMK);
            this.pnlNhapLaiMK.Controls.Add(this.lblNhapLaiMK);
            this.pnlNhapLaiMK.Controls.Add(this.txbNhapLaiMK);
            this.pnlNhapLaiMK.Location = new System.Drawing.Point(0, 189);
            this.pnlNhapLaiMK.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNhapLaiMK.Name = "pnlNhapLaiMK";
            this.pnlNhapLaiMK.Size = new System.Drawing.Size(322, 63);
            this.pnlNhapLaiMK.TabIndex = 46;
            // 
            // lblCheck_NhapLaiMK
            // 
            this.lblCheck_NhapLaiMK.AutoSize = true;
            this.lblCheck_NhapLaiMK.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_NhapLaiMK.Location = new System.Drawing.Point(118, 43);
            this.lblCheck_NhapLaiMK.Name = "lblCheck_NhapLaiMK";
            this.lblCheck_NhapLaiMK.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_NhapLaiMK.TabIndex = 21;
            this.lblCheck_NhapLaiMK.Text = "label1";
            // 
            // lblNhapLaiMK
            // 
            this.lblNhapLaiMK.AutoSize = true;
            this.lblNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMK.Location = new System.Drawing.Point(5, 23);
            this.lblNhapLaiMK.Name = "lblNhapLaiMK";
            this.lblNhapLaiMK.Size = new System.Drawing.Size(110, 13);
            this.lblNhapLaiMK.TabIndex = 13;
            this.lblNhapLaiMK.Text = "Nhập lại mật khẩu";
            // 
            // txbNhapLaiMK
            // 
            this.txbNhapLaiMK.Location = new System.Drawing.Point(121, 20);
            this.txbNhapLaiMK.Name = "txbNhapLaiMK";
            this.txbNhapLaiMK.Size = new System.Drawing.Size(201, 20);
            this.txbNhapLaiMK.TabIndex = 9;
            this.txbNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // pnlChucVu
            // 
            this.pnlChucVu.Controls.Add(this.cbChucVu);
            this.pnlChucVu.Controls.Add(this.lblCheck_ChucVu);
            this.pnlChucVu.Controls.Add(this.lblChucVu);
            this.pnlChucVu.Location = new System.Drawing.Point(0, 315);
            this.pnlChucVu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChucVu.Name = "pnlChucVu";
            this.pnlChucVu.Size = new System.Drawing.Size(322, 63);
            this.pnlChucVu.TabIndex = 47;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(121, 20);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(201, 21);
            this.cbChucVu.TabIndex = 40;
            // 
            // lblCheck_ChucVu
            // 
            this.lblCheck_ChucVu.AutoSize = true;
            this.lblCheck_ChucVu.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_ChucVu.Location = new System.Drawing.Point(118, 43);
            this.lblCheck_ChucVu.Name = "lblCheck_ChucVu";
            this.lblCheck_ChucVu.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_ChucVu.TabIndex = 21;
            this.lblCheck_ChucVu.Text = "label1";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(53, 21);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(62, 16);
            this.lblChucVu.TabIndex = 13;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // pnlHoTen
            // 
            this.pnlHoTen.Controls.Add(this.txbHoTen);
            this.pnlHoTen.Controls.Add(this.lblCheck_HoTen);
            this.pnlHoTen.Controls.Add(this.lblHoTen);
            this.pnlHoTen.Location = new System.Drawing.Point(0, 252);
            this.pnlHoTen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHoTen.Name = "pnlHoTen";
            this.pnlHoTen.Size = new System.Drawing.Size(322, 63);
            this.pnlHoTen.TabIndex = 48;
            // 
            // lblCheck_HoTen
            // 
            this.lblCheck_HoTen.AutoSize = true;
            this.lblCheck_HoTen.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_HoTen.Location = new System.Drawing.Point(118, 43);
            this.lblCheck_HoTen.Name = "lblCheck_HoTen";
            this.lblCheck_HoTen.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_HoTen.TabIndex = 21;
            this.lblCheck_HoTen.Text = "label1";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(53, 21);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(53, 16);
            this.lblHoTen.TabIndex = 13;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(118, 20);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(201, 20);
            this.txbHoTen.TabIndex = 22;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flpThongTin);
            this.Controls.Add(this.lblTimChucVu);
            this.Controls.Add(this.cbTimChucVu);
            this.Controls.Add(this.chkMe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.lvNhanVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(815, 517);
            this.flpThongTin.ResumeLayout(false);
            this.pnlTenDangNhap.ResumeLayout(false);
            this.pnlTenDangNhap.PerformLayout();
            this.pnlMatKhauCu.ResumeLayout(false);
            this.pnlMatKhauCu.PerformLayout();
            this.pnlMatKhau.ResumeLayout(false);
            this.pnlMatKhau.PerformLayout();
            this.pnlNhapLaiMK.ResumeLayout(false);
            this.pnlNhapLaiMK.PerformLayout();
            this.pnlChucVu.ResumeLayout(false);
            this.pnlChucVu.PerformLayout();
            this.pnlHoTen.ResumeLayout(false);
            this.pnlHoTen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader colTaiKhoan;
        private System.Windows.Forms.ColumnHeader colTenNhanVien;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox chkMe;
        private System.Windows.Forms.ComboBox cbTimChucVu;
        private System.Windows.Forms.Label lblTimChucVu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.FlowLayoutPanel flpThongTin;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.Label lblCheck_TenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Panel pnlMatKhauCu;
        private System.Windows.Forms.Label lblCheck_MatKhauCu;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txbMatKhauCu;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.Label lblCheck_MatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Panel pnlNhapLaiMK;
        private System.Windows.Forms.Label lblCheck_NhapLaiMK;
        private System.Windows.Forms.Label lblNhapLaiMK;
        private System.Windows.Forms.TextBox txbNhapLaiMK;
        private System.Windows.Forms.Panel pnlChucVu;
        private System.Windows.Forms.Label lblCheck_ChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Panel pnlHoTen;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label lblCheck_HoTen;
        private System.Windows.Forms.Label lblHoTen;
    }
}
