namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    partial class UC_SoDoPhong
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
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.BackColor = System.Drawing.Color.LightGray;
            this.flpPhong.Location = new System.Drawing.Point(24, 69);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(761, 452);
            this.flpPhong.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(21, 26);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(78, 16);
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Trống",
            "Đang thuê",
            "Đặt trước",
            "Bảo trì"});
            this.cbTrangThai.Location = new System.Drawing.Point(96, 24);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(143, 21);
            this.cbTrangThai.TabIndex = 1;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(370, 24);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(159, 21);
            this.cbLoaiPhong.TabIndex = 2;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(287, 26);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(86, 16);
            this.lblLoaiPhong.TabIndex = 3;
            this.lblLoaiPhong.Text = "Loại Phòng";
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(655, 25);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(121, 21);
            this.cbTang.TabIndex = 3;
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTang.Location = new System.Drawing.Point(614, 29);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(44, 16);
            this.lblTang.TabIndex = 5;
            this.lblTang.Text = "Tầng";
            // 
            // UC_SoDoPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cbTang);
            this.Controls.Add(this.lblTang);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.flpPhong);
            this.Name = "UC_SoDoPhong";
            this.Size = new System.Drawing.Size(815, 541);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.Label lblTang;
    }
}
