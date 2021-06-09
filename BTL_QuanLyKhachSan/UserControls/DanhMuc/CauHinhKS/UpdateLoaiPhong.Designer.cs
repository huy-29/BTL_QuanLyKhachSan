namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    partial class UpdateLoaiPhong
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
            this.lblMaLoaiPhong = new System.Windows.Forms.Label();
            this.lblTenLoaiPhong = new System.Windows.Forms.Label();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblMucGia = new System.Windows.Forms.Label();
            this.pnlBonus = new System.Windows.Forms.Panel();
            this.txbPhong = new System.Windows.Forms.TextBox();
            this.txbMucGia = new System.Windows.Forms.TextBox();
            this.txbMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.txbTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.txbSoNguoi = new System.Windows.Forms.TextBox();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblCheck_TenLoaiPhong = new System.Windows.Forms.Label();
            this.lblCheck_SoNguoi = new System.Windows.Forms.Label();
            this.lblCheck_GhiChu = new System.Windows.Forms.Label();
            this.pnlBonus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaLoaiPhong
            // 
            this.lblMaLoaiPhong.AutoSize = true;
            this.lblMaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiPhong.Location = new System.Drawing.Point(18, 13);
            this.lblMaLoaiPhong.Name = "lblMaLoaiPhong";
            this.lblMaLoaiPhong.Size = new System.Drawing.Size(106, 16);
            this.lblMaLoaiPhong.TabIndex = 0;
            this.lblMaLoaiPhong.Text = "Mã loại phòng";
            // 
            // lblTenLoaiPhong
            // 
            this.lblTenLoaiPhong.AutoSize = true;
            this.lblTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiPhong.Location = new System.Drawing.Point(12, 57);
            this.lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            this.lblTenLoaiPhong.Size = new System.Drawing.Size(112, 16);
            this.lblTenLoaiPhong.TabIndex = 1;
            this.lblTenLoaiPhong.Text = "Tên loại phòng";
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguoi.Location = new System.Drawing.Point(55, 105);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(69, 16);
            this.lblSoNguoi.TabIndex = 2;
            this.lblSoNguoi.Text = "Số người";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(65, 156);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(59, 16);
            this.lblGhiChu.TabIndex = 3;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(26, 89);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(110, 16);
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng sử dụng";
            // 
            // lblMucGia
            // 
            this.lblMucGia.AutoSize = true;
            this.lblMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucGia.Location = new System.Drawing.Point(16, 4);
            this.lblMucGia.Name = "lblMucGia";
            this.lblMucGia.Size = new System.Drawing.Size(120, 16);
            this.lblMucGia.TabIndex = 5;
            this.lblMucGia.Text = "Mức giá sử dụng";
            // 
            // pnlBonus
            // 
            this.pnlBonus.Controls.Add(this.txbPhong);
            this.pnlBonus.Controls.Add(this.lblMucGia);
            this.pnlBonus.Controls.Add(this.lblPhong);
            this.pnlBonus.Controls.Add(this.txbMucGia);
            this.pnlBonus.Location = new System.Drawing.Point(380, 12);
            this.pnlBonus.Name = "pnlBonus";
            this.pnlBonus.Size = new System.Drawing.Size(312, 175);
            this.pnlBonus.TabIndex = 6;
            // 
            // txbPhong
            // 
            this.txbPhong.Location = new System.Drawing.Point(142, 88);
            this.txbPhong.Multiline = true;
            this.txbPhong.Name = "txbPhong";
            this.txbPhong.ReadOnly = true;
            this.txbPhong.Size = new System.Drawing.Size(155, 72);
            this.txbPhong.TabIndex = 12;
            // 
            // txbMucGia
            // 
            this.txbMucGia.Location = new System.Drawing.Point(142, 4);
            this.txbMucGia.Multiline = true;
            this.txbMucGia.Name = "txbMucGia";
            this.txbMucGia.ReadOnly = true;
            this.txbMucGia.Size = new System.Drawing.Size(155, 72);
            this.txbMucGia.TabIndex = 11;
            // 
            // txbMaLoaiPhong
            // 
            this.txbMaLoaiPhong.Location = new System.Drawing.Point(130, 13);
            this.txbMaLoaiPhong.MaxLength = 10;
            this.txbMaLoaiPhong.Name = "txbMaLoaiPhong";
            this.txbMaLoaiPhong.ReadOnly = true;
            this.txbMaLoaiPhong.Size = new System.Drawing.Size(128, 20);
            this.txbMaLoaiPhong.TabIndex = 7;
            // 
            // txbTenLoaiPhong
            // 
            this.txbTenLoaiPhong.Location = new System.Drawing.Point(130, 57);
            this.txbTenLoaiPhong.MaxLength = 20;
            this.txbTenLoaiPhong.Name = "txbTenLoaiPhong";
            this.txbTenLoaiPhong.Size = new System.Drawing.Size(173, 20);
            this.txbTenLoaiPhong.TabIndex = 8;
            // 
            // txbSoNguoi
            // 
            this.txbSoNguoi.Location = new System.Drawing.Point(130, 105);
            this.txbSoNguoi.MaxLength = 10;
            this.txbSoNguoi.Name = "txbSoNguoi";
            this.txbSoNguoi.Size = new System.Drawing.Size(106, 20);
            this.txbSoNguoi.TabIndex = 9;
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(130, 156);
            this.txbGhiChu.MaxLength = 100;
            this.txbGhiChu.Multiline = true;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(228, 72);
            this.txbGhiChu.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(409, 258);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 41);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(522, 258);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 41);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblCheck_TenLoaiPhong
            // 
            this.lblCheck_TenLoaiPhong.AutoSize = true;
            this.lblCheck_TenLoaiPhong.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_TenLoaiPhong.Location = new System.Drawing.Point(127, 80);
            this.lblCheck_TenLoaiPhong.Name = "lblCheck_TenLoaiPhong";
            this.lblCheck_TenLoaiPhong.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_TenLoaiPhong.TabIndex = 14;
            this.lblCheck_TenLoaiPhong.Text = "label2";
            // 
            // lblCheck_SoNguoi
            // 
            this.lblCheck_SoNguoi.AutoSize = true;
            this.lblCheck_SoNguoi.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_SoNguoi.Location = new System.Drawing.Point(127, 128);
            this.lblCheck_SoNguoi.Name = "lblCheck_SoNguoi";
            this.lblCheck_SoNguoi.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_SoNguoi.TabIndex = 15;
            this.lblCheck_SoNguoi.Text = "label3";
            // 
            // lblCheck_GhiChu
            // 
            this.lblCheck_GhiChu.AutoSize = true;
            this.lblCheck_GhiChu.ForeColor = System.Drawing.Color.Red;
            this.lblCheck_GhiChu.Location = new System.Drawing.Point(127, 231);
            this.lblCheck_GhiChu.Name = "lblCheck_GhiChu";
            this.lblCheck_GhiChu.Size = new System.Drawing.Size(35, 13);
            this.lblCheck_GhiChu.TabIndex = 16;
            this.lblCheck_GhiChu.Text = "label3";
            // 
            // UpdateLoaiPhong
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(707, 324);
            this.Controls.Add(this.lblCheck_GhiChu);
            this.Controls.Add(this.lblCheck_SoNguoi);
            this.Controls.Add(this.lblCheck_TenLoaiPhong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txbSoNguoi);
            this.Controls.Add(this.txbTenLoaiPhong);
            this.Controls.Add(this.txbMaLoaiPhong);
            this.Controls.Add(this.pnlBonus);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblSoNguoi);
            this.Controls.Add(this.lblTenLoaiPhong);
            this.Controls.Add(this.lblMaLoaiPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateLoaiPhong";
            this.pnlBonus.ResumeLayout(false);
            this.pnlBonus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLoaiPhong;
        private System.Windows.Forms.Label lblTenLoaiPhong;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblMucGia;
        private System.Windows.Forms.Panel pnlBonus;
        private System.Windows.Forms.TextBox txbMaLoaiPhong;
        private System.Windows.Forms.TextBox txbTenLoaiPhong;
        private System.Windows.Forms.TextBox txbPhong;
        private System.Windows.Forms.TextBox txbMucGia;
        private System.Windows.Forms.TextBox txbSoNguoi;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblCheck_TenLoaiPhong;
        private System.Windows.Forms.Label lblCheck_SoNguoi;
        private System.Windows.Forms.Label lblCheck_GhiChu;
    }
}