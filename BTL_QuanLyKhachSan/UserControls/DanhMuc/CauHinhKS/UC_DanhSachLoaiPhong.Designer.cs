namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    partial class UC_DanhSachLoaiPhong
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
            this.lvDanhSachLoaiPhong = new System.Windows.Forms.ListView();
            this.colMaLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMucGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cbMucGia = new System.Windows.Forms.ComboBox();
            this.lblMucGia = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvDanhSachLoaiPhong
            // 
            this.lvDanhSachLoaiPhong.CheckBoxes = true;
            this.lvDanhSachLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLoaiPhong,
            this.colLoaiPhong,
            this.colSoNguoi,
            this.colGhiChu,
            this.colMucGia,
            this.colPhong});
            this.lvDanhSachLoaiPhong.FullRowSelect = true;
            this.lvDanhSachLoaiPhong.GridLines = true;
            this.lvDanhSachLoaiPhong.HideSelection = false;
            this.lvDanhSachLoaiPhong.Location = new System.Drawing.Point(3, 110);
            this.lvDanhSachLoaiPhong.Name = "lvDanhSachLoaiPhong";
            this.lvDanhSachLoaiPhong.ShowItemToolTips = true;
            this.lvDanhSachLoaiPhong.Size = new System.Drawing.Size(809, 399);
            this.lvDanhSachLoaiPhong.TabIndex = 12;
            this.lvDanhSachLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachLoaiPhong.View = System.Windows.Forms.View.Details;
            this.lvDanhSachLoaiPhong.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDanhSachLoaiPhong_ItemChecked);
            // 
            // colMaLoaiPhong
            // 
            this.colMaLoaiPhong.Text = "Mã loại phòng";
            this.colMaLoaiPhong.Width = 79;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.Text = "Loại phòng";
            this.colLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLoaiPhong.Width = 102;
            // 
            // colSoNguoi
            // 
            this.colSoNguoi.Text = "Số người";
            this.colSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoNguoi.Width = 72;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Text = "Ghi chú";
            this.colGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGhiChu.Width = 208;
            // 
            // colMucGia
            // 
            this.colMucGia.Text = "Mức giá sử dụng";
            this.colMucGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMucGia.Width = 182;
            // 
            // colPhong
            // 
            this.colPhong.Text = "Phòng sử dụng";
            this.colPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhong.Width = 139;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(762, 7);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(50, 39);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(702, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 39);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(638, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 39);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(540, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(91, 71);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(123, 21);
            this.cbLoaiPhong.TabIndex = 9;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(3, 70);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(91, 18);
            this.lblLoaiPhong.TabIndex = 23;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(363, 7);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 39);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(363, 71);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(113, 21);
            this.cbPhong.TabIndex = 10;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(301, 74);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(56, 18);
            this.lblPhong.TabIndex = 31;
            this.lblPhong.Text = "Phòng";
            // 
            // cbMucGia
            // 
            this.cbMucGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMucGia.FormattingEnabled = true;
            this.cbMucGia.Location = new System.Drawing.Point(633, 71);
            this.cbMucGia.Name = "cbMucGia";
            this.cbMucGia.Size = new System.Drawing.Size(123, 21);
            this.cbMucGia.TabIndex = 11;
            this.cbMucGia.SelectedIndexChanged += new System.EventHandler(this.cbMucGia_SelectedIndexChanged);
            // 
            // lblMucGia
            // 
            this.lblMucGia.AutoSize = true;
            this.lblMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucGia.Location = new System.Drawing.Point(565, 73);
            this.lblMucGia.Name = "lblMucGia";
            this.lblMucGia.Size = new System.Drawing.Size(67, 18);
            this.lblMucGia.TabIndex = 33;
            this.lblMucGia.Text = "Mức giá";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(142, 17);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(215, 20);
            this.txbTimKiem.TabIndex = 3;
            // 
            // UC_DanhSachLoaiPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.cbMucGia);
            this.Controls.Add(this.lblMucGia);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lvDanhSachLoaiPhong);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Name = "UC_DanhSachLoaiPhong";
            this.Size = new System.Drawing.Size(815, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvDanhSachLoaiPhong;
        private System.Windows.Forms.ColumnHeader colLoaiPhong;
        private System.Windows.Forms.ColumnHeader colSoNguoi;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ColumnHeader colGhiChu;
        private System.Windows.Forms.ColumnHeader colMaLoaiPhong;
        private System.Windows.Forms.ColumnHeader colMucGia;
        private System.Windows.Forms.ColumnHeader colPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cbMucGia;
        private System.Windows.Forms.Label lblMucGia;
        private System.Windows.Forms.TextBox txbTimKiem;
    }
}
