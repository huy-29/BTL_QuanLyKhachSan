namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    partial class UC_DanhSachTang
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
            this.lvDanhSachTang = new System.Windows.Forms.ListView();
            this.colTang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.txbMaTang_BD = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTenTang = new System.Windows.Forms.Label();
            this.txbTenTang_BD = new System.Windows.Forms.TextBox();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblCheck_txbMaTang = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDanhSachTang
            // 
            this.lvDanhSachTang.CheckBoxes = true;
            this.lvDanhSachTang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTang,
            this.colTenTang});
            this.lvDanhSachTang.FullRowSelect = true;
            this.lvDanhSachTang.GridLines = true;
            this.lvDanhSachTang.HideSelection = false;
            this.lvDanhSachTang.Location = new System.Drawing.Point(3, 42);
            this.lvDanhSachTang.Name = "lvDanhSachTang";
            this.lvDanhSachTang.Size = new System.Drawing.Size(476, 465);
            this.lvDanhSachTang.TabIndex = 29;
            this.lvDanhSachTang.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachTang.View = System.Windows.Forms.View.Details;
            this.lvDanhSachTang.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDanhSachTang_ItemChecked);
            this.lvDanhSachTang.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachTang_SelectedIndexChanged);
            // 
            // colTang
            // 
            this.colTang.Text = "Tầng";
            this.colTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTang.Width = 74;
            // 
            // colTenTang
            // 
            this.colTenTang.Text = "Tên Tầng";
            this.colTenTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenTang.Width = 313;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(702, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 39);
            this.btnXoa.TabIndex = 8;
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
            this.btnSua.TabIndex = 7;
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
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tầng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tầng";
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTang.Location = new System.Drawing.Point(80, 15);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(72, 21);
            this.cbTang.TabIndex = 3;
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // txbMaTang_BD
            // 
            this.txbMaTang_BD.Location = new System.Drawing.Point(74, 21);
            this.txbMaTang_BD.MaxLength = 10;
            this.txbMaTang_BD.Name = "txbMaTang_BD";
            this.txbMaTang_BD.Size = new System.Drawing.Size(157, 20);
            this.txbMaTang_BD.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(40, 122);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Crimson;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(164, 122);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTenTang
            // 
            this.lblTenTang.AutoSize = true;
            this.lblTenTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTang.Location = new System.Drawing.Point(3, 75);
            this.lblTenTang.Name = "lblTenTang";
            this.lblTenTang.Size = new System.Drawing.Size(69, 16);
            this.lblTenTang.TabIndex = 42;
            this.lblTenTang.Text = "Tên tầng";
            // 
            // txbTenTang_BD
            // 
            this.txbTenTang_BD.Location = new System.Drawing.Point(74, 74);
            this.txbTenTang_BD.MaxLength = 20;
            this.txbTenTang_BD.Multiline = true;
            this.txbTenTang_BD.Name = "txbTenTang_BD";
            this.txbTenTang_BD.Size = new System.Drawing.Size(231, 20);
            this.txbTenTang_BD.TabIndex = 10;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblCheck_txbMaTang);
            this.pnlUpdate.Controls.Add(this.label2);
            this.pnlUpdate.Controls.Add(this.btnHuy);
            this.pnlUpdate.Controls.Add(this.btnLuu);
            this.pnlUpdate.Controls.Add(this.txbTenTang_BD);
            this.pnlUpdate.Controls.Add(this.lblTenTang);
            this.pnlUpdate.Controls.Add(this.txbMaTang_BD);
            this.pnlUpdate.Location = new System.Drawing.Point(500, 52);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(312, 186);
            this.pnlUpdate.TabIndex = 44;
            // 
            // lblCheck_txbMaTang
            // 
            this.lblCheck_txbMaTang.AutoSize = true;
            this.lblCheck_txbMaTang.BackColor = System.Drawing.Color.White;
            this.lblCheck_txbMaTang.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_txbMaTang.Location = new System.Drawing.Point(74, 44);
            this.lblCheck_txbMaTang.Name = "lblCheck_txbMaTang";
            this.lblCheck_txbMaTang.Size = new System.Drawing.Size(28, 13);
            this.lblCheck_txbMaTang.TabIndex = 44;
            this.lblCheck_txbMaTang.Text = "       ";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(313, 11);
            this.txbTimKiem.MaxLength = 10;
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(157, 20);
            this.txbTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Firebrick;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(215, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 35);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // UC_DanhSachTang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.cbTang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDanhSachTang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "UC_DanhSachTang";
            this.Size = new System.Drawing.Size(815, 517);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDanhSachTang;
        private System.Windows.Forms.ColumnHeader colTang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.TextBox txbMaTang_BD;
        private System.Windows.Forms.ColumnHeader colTenTang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTenTang;
        private System.Windows.Forms.TextBox txbTenTang_BD;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblCheck_txbMaTang;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
