namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    partial class UC_DanhSachPhong
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
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lvDanhSachPhong = new System.Windows.Forms.ListView();
            this.colMaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbMaPhong_BD = new System.Windows.Forms.TextBox();
            this.txbSoNguoi_BD = new System.Windows.Forms.TextBox();
            this.lblMaPhong_BD = new System.Windows.Forms.Label();
            this.lblTang_BD = new System.Windows.Forms.Label();
            this.lblLoaiPhong_BD = new System.Windows.Forms.Label();
            this.lblSoNguoi_BD = new System.Windows.Forms.Label();
            this.cbTang_BD = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong_BD = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblCheck_LoaiPhong = new System.Windows.Forms.Label();
            this.lblCheck_Tang = new System.Windows.Forms.Label();
            this.lblCheck_MaPhong = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(76, 43);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(64, 21);
            this.cbTang.TabIndex = 4;
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTang.Location = new System.Drawing.Point(21, 44);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(49, 20);
            this.lblTang.TabIndex = 1;
            this.lblTang.Text = "Tầng";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(193, 44);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(98, 20);
            this.lblLoaiPhong.TabIndex = 2;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(297, 43);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(181, 21);
            this.cbLoaiPhong.TabIndex = 5;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(540, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(638, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 39);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(702, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lvDanhSachPhong
            // 
            this.lvDanhSachPhong.CheckBoxes = true;
            this.lvDanhSachPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhong,
            this.colTang,
            this.colLoaiPhong,
            this.colSoNguoi});
            this.lvDanhSachPhong.FullRowSelect = true;
            this.lvDanhSachPhong.GridLines = true;
            this.lvDanhSachPhong.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.lvDanhSachPhong.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvDanhSachPhong.Location = new System.Drawing.Point(3, 78);
            this.lvDanhSachPhong.Name = "lvDanhSachPhong";
            this.lvDanhSachPhong.Size = new System.Drawing.Size(476, 436);
            this.lvDanhSachPhong.TabIndex = 26;
            this.lvDanhSachPhong.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachPhong.View = System.Windows.Forms.View.Details;
            this.lvDanhSachPhong.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDanhSachPhong_ItemChecked);
            this.lvDanhSachPhong.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachPhong_SelectedIndexChanged);
            // 
            // colMaPhong
            // 
            this.colMaPhong.Text = "Tên phòng";
            this.colMaPhong.Width = 84;
            // 
            // colTang
            // 
            this.colTang.Text = "Tầng";
            this.colTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTang.Width = 74;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.Text = "Loại phòng";
            this.colLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLoaiPhong.Width = 194;
            // 
            // colSoNguoi
            // 
            this.colSoNguoi.Text = "Số người";
            this.colSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoNguoi.Width = 70;
            // 
            // txbMaPhong_BD
            // 
            this.txbMaPhong_BD.Location = new System.Drawing.Point(102, 21);
            this.txbMaPhong_BD.Name = "txbMaPhong_BD";
            this.txbMaPhong_BD.Size = new System.Drawing.Size(100, 20);
            this.txbMaPhong_BD.TabIndex = 9;
            // 
            // txbSoNguoi_BD
            // 
            this.txbSoNguoi_BD.Location = new System.Drawing.Point(102, 176);
            this.txbSoNguoi_BD.Name = "txbSoNguoi_BD";
            this.txbSoNguoi_BD.ReadOnly = true;
            this.txbSoNguoi_BD.Size = new System.Drawing.Size(100, 20);
            this.txbSoNguoi_BD.TabIndex = 25;
            // 
            // lblMaPhong_BD
            // 
            this.lblMaPhong_BD.AutoSize = true;
            this.lblMaPhong_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong_BD.Location = new System.Drawing.Point(14, 21);
            this.lblMaPhong_BD.Name = "lblMaPhong_BD";
            this.lblMaPhong_BD.Size = new System.Drawing.Size(82, 16);
            this.lblMaPhong_BD.TabIndex = 13;
            this.lblMaPhong_BD.Text = "Tên phòng";
            // 
            // lblTang_BD
            // 
            this.lblTang_BD.AutoSize = true;
            this.lblTang_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTang_BD.Location = new System.Drawing.Point(52, 72);
            this.lblTang_BD.Name = "lblTang_BD";
            this.lblTang_BD.Size = new System.Drawing.Size(44, 16);
            this.lblTang_BD.TabIndex = 14;
            this.lblTang_BD.Text = "Tầng";
            // 
            // lblLoaiPhong_BD
            // 
            this.lblLoaiPhong_BD.AutoSize = true;
            this.lblLoaiPhong_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong_BD.Location = new System.Drawing.Point(11, 122);
            this.lblLoaiPhong_BD.Name = "lblLoaiPhong_BD";
            this.lblLoaiPhong_BD.Size = new System.Drawing.Size(85, 16);
            this.lblLoaiPhong_BD.TabIndex = 15;
            this.lblLoaiPhong_BD.Text = "Loại phòng";
            // 
            // lblSoNguoi_BD
            // 
            this.lblSoNguoi_BD.AutoSize = true;
            this.lblSoNguoi_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguoi_BD.Location = new System.Drawing.Point(27, 180);
            this.lblSoNguoi_BD.Name = "lblSoNguoi_BD";
            this.lblSoNguoi_BD.Size = new System.Drawing.Size(69, 16);
            this.lblSoNguoi_BD.TabIndex = 16;
            this.lblSoNguoi_BD.Text = "Số người";
            // 
            // cbTang_BD
            // 
            this.cbTang_BD.FormattingEnabled = true;
            this.cbTang_BD.Location = new System.Drawing.Point(102, 72);
            this.cbTang_BD.Name = "cbTang_BD";
            this.cbTang_BD.Size = new System.Drawing.Size(100, 21);
            this.cbTang_BD.TabIndex = 10;
            // 
            // cbLoaiPhong_BD
            // 
            this.cbLoaiPhong_BD.FormattingEnabled = true;
            this.cbLoaiPhong_BD.Location = new System.Drawing.Point(102, 123);
            this.cbLoaiPhong_BD.Name = "cbLoaiPhong_BD";
            this.cbLoaiPhong_BD.Size = new System.Drawing.Size(200, 21);
            this.cbLoaiPhong_BD.TabIndex = 11;
            this.cbLoaiPhong_BD.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_BD_SelectedIndexChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Crimson;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(210, 244);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(106, 244);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblCheck_LoaiPhong);
            this.pnlUpdate.Controls.Add(this.lblCheck_Tang);
            this.pnlUpdate.Controls.Add(this.lblCheck_MaPhong);
            this.pnlUpdate.Controls.Add(this.lblMaPhong_BD);
            this.pnlUpdate.Controls.Add(this.btnHuy);
            this.pnlUpdate.Controls.Add(this.btnLuu);
            this.pnlUpdate.Controls.Add(this.txbMaPhong_BD);
            this.pnlUpdate.Controls.Add(this.lblTang_BD);
            this.pnlUpdate.Controls.Add(this.txbSoNguoi_BD);
            this.pnlUpdate.Controls.Add(this.lblSoNguoi_BD);
            this.pnlUpdate.Controls.Add(this.cbLoaiPhong_BD);
            this.pnlUpdate.Controls.Add(this.cbTang_BD);
            this.pnlUpdate.Controls.Add(this.lblLoaiPhong_BD);
            this.pnlUpdate.Location = new System.Drawing.Point(506, 57);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(309, 286);
            this.pnlUpdate.TabIndex = 21;
            // 
            // lblCheck_LoaiPhong
            // 
            this.lblCheck_LoaiPhong.AutoSize = true;
            this.lblCheck_LoaiPhong.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_LoaiPhong.Location = new System.Drawing.Point(99, 146);
            this.lblCheck_LoaiPhong.Name = "lblCheck_LoaiPhong";
            this.lblCheck_LoaiPhong.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_LoaiPhong.TabIndex = 23;
            this.lblCheck_LoaiPhong.Text = "label3";
            // 
            // lblCheck_Tang
            // 
            this.lblCheck_Tang.AutoSize = true;
            this.lblCheck_Tang.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_Tang.Location = new System.Drawing.Point(99, 96);
            this.lblCheck_Tang.Name = "lblCheck_Tang";
            this.lblCheck_Tang.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_Tang.TabIndex = 22;
            this.lblCheck_Tang.Text = "label2";
            // 
            // lblCheck_MaPhong
            // 
            this.lblCheck_MaPhong.AutoSize = true;
            this.lblCheck_MaPhong.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_MaPhong.Location = new System.Drawing.Point(99, 44);
            this.lblCheck_MaPhong.Name = "lblCheck_MaPhong";
            this.lblCheck_MaPhong.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_MaPhong.TabIndex = 21;
            this.lblCheck_MaPhong.Text = "label1";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(76, 12);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txbTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Maroon;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(282, 7);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txbMaLoaiPhong
            // 
            this.txbMaLoaiPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbMaLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaLoaiPhong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbMaLoaiPhong.Location = new System.Drawing.Point(682, 489);
            this.txbMaLoaiPhong.Multiline = true;
            this.txbMaLoaiPhong.Name = "txbMaLoaiPhong";
            this.txbMaLoaiPhong.ReadOnly = true;
            this.txbMaLoaiPhong.Size = new System.Drawing.Size(130, 25);
            this.txbMaLoaiPhong.TabIndex = 27;
            // 
            // UC_DanhSachPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txbMaLoaiPhong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.lvDanhSachPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblTang);
            this.Controls.Add(this.cbTang);
            this.Name = "UC_DanhSachPhong";
            this.Size = new System.Drawing.Size(815, 517);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lvDanhSachPhong;
        private System.Windows.Forms.ColumnHeader colMaPhong;
        private System.Windows.Forms.ColumnHeader colTang;
        private System.Windows.Forms.ColumnHeader colLoaiPhong;
        private System.Windows.Forms.ColumnHeader colSoNguoi;
        private System.Windows.Forms.TextBox txbMaPhong_BD;
        private System.Windows.Forms.TextBox txbSoNguoi_BD;
        private System.Windows.Forms.Label lblMaPhong_BD;
        private System.Windows.Forms.Label lblTang_BD;
        private System.Windows.Forms.Label lblLoaiPhong_BD;
        private System.Windows.Forms.Label lblSoNguoi_BD;
        private System.Windows.Forms.ComboBox cbTang_BD;
        private System.Windows.Forms.ComboBox cbLoaiPhong_BD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblCheck_LoaiPhong;
        private System.Windows.Forms.Label lblCheck_Tang;
        private System.Windows.Forms.Label lblCheck_MaPhong;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbMaLoaiPhong;
    }
}
