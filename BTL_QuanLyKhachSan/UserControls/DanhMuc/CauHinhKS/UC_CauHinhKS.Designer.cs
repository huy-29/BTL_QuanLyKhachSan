namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    partial class UC_CauHinhKS
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
            this.mnsCauHinhKS = new System.Windows.Forms.MenuStrip();
            this.mnsToolDanhSachPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsToolDanhSachTang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsToolDanhSachLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCauHinhKS = new System.Windows.Forms.Panel();
            this.mnsCauHinhKS.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsCauHinhKS
            // 
            this.mnsCauHinhKS.BackColor = System.Drawing.Color.Aquamarine;
            this.mnsCauHinhKS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsToolDanhSachPhong,
            this.mnsToolDanhSachTang,
            this.mnsToolDanhSachLoaiPhong});
            this.mnsCauHinhKS.Location = new System.Drawing.Point(0, 0);
            this.mnsCauHinhKS.Name = "mnsCauHinhKS";
            this.mnsCauHinhKS.Size = new System.Drawing.Size(815, 24);
            this.mnsCauHinhKS.TabIndex = 0;
            this.mnsCauHinhKS.Text = "menuStrip1";
            this.mnsCauHinhKS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsCauHinhKS_ItemClicked);
            this.mnsCauHinhKS.Click += new System.EventHandler(this.mnsCauHinhKS_Click);
            // 
            // mnsToolDanhSachPhong
            // 
            this.mnsToolDanhSachPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsToolDanhSachPhong.ForeColor = System.Drawing.Color.DarkMagenta;
            this.mnsToolDanhSachPhong.Name = "mnsToolDanhSachPhong";
            this.mnsToolDanhSachPhong.Size = new System.Drawing.Size(113, 20);
            this.mnsToolDanhSachPhong.Text = "Danh sách phòng";
            this.mnsToolDanhSachPhong.Click += new System.EventHandler(this.mnsToolDanhSachPhong_Click);
            // 
            // mnsToolDanhSachTang
            // 
            this.mnsToolDanhSachTang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsToolDanhSachTang.ForeColor = System.Drawing.Color.DarkMagenta;
            this.mnsToolDanhSachTang.Name = "mnsToolDanhSachTang";
            this.mnsToolDanhSachTang.Size = new System.Drawing.Size(103, 20);
            this.mnsToolDanhSachTang.Text = "Danh sách tầng";
            this.mnsToolDanhSachTang.Click += new System.EventHandler(this.mnsToolDanhSachTang_Click);
            // 
            // mnsToolDanhSachLoaiPhong
            // 
            this.mnsToolDanhSachLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsToolDanhSachLoaiPhong.ForeColor = System.Drawing.Color.DarkMagenta;
            this.mnsToolDanhSachLoaiPhong.Name = "mnsToolDanhSachLoaiPhong";
            this.mnsToolDanhSachLoaiPhong.Size = new System.Drawing.Size(135, 20);
            this.mnsToolDanhSachLoaiPhong.Text = "Danh sách loại phòng";
            this.mnsToolDanhSachLoaiPhong.Click += new System.EventHandler(this.mnsToolDanhSachLoaiPhong_Click);
            // 
            // pnlCauHinhKS
            // 
            this.pnlCauHinhKS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCauHinhKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCauHinhKS.Location = new System.Drawing.Point(0, 24);
            this.pnlCauHinhKS.Name = "pnlCauHinhKS";
            this.pnlCauHinhKS.Size = new System.Drawing.Size(815, 517);
            this.pnlCauHinhKS.TabIndex = 1;
            // 
            // UC_CauHinhKS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlCauHinhKS);
            this.Controls.Add(this.mnsCauHinhKS);
            this.Name = "UC_CauHinhKS";
            this.Size = new System.Drawing.Size(815, 541);
            this.mnsCauHinhKS.ResumeLayout(false);
            this.mnsCauHinhKS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsCauHinhKS;
        private System.Windows.Forms.ToolStripMenuItem mnsToolDanhSachPhong;
        private System.Windows.Forms.ToolStripMenuItem mnsToolDanhSachTang;
        private System.Windows.Forms.ToolStripMenuItem mnsToolDanhSachLoaiPhong;
        private System.Windows.Forms.Panel pnlCauHinhKS;
    }
}
