namespace BTL_QuanLyKhachSan
{
    partial class frMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Cấu hình khách sạn");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Giá theo thời điểm");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cài đặt chung");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Danh Mục", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sơ đồ phòng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Danh sách đặt phòng");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Danh sách thuê phòng");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quản lý phòng", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nhân viên");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Cách tính chi phí");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.lblFormMain = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMenu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.ImageIndex = 0;
            this.tvMenu.ImageList = this.imageList1;
            this.tvMenu.Indent = 30;
            this.tvMenu.ItemHeight = 50;
            this.tvMenu.Location = new System.Drawing.Point(0, 37);
            this.tvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tvMenu.Name = "tvMenu";
            treeNode1.BackColor = System.Drawing.Color.DimGray;
            treeNode1.ForeColor = System.Drawing.Color.White;
            treeNode1.ImageKey = "GitHub.png";
            treeNode1.Name = "CauHinhKhachSan";
            treeNode1.SelectedImageKey = "GitHub.png";
            treeNode1.Text = "Cấu hình khách sạn";
            treeNode2.BackColor = System.Drawing.Color.DimGray;
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.ImageKey = "Havij.png";
            treeNode2.Name = "GiaTheoThoiDiem";
            treeNode2.SelectedImageKey = "Havij.png";
            treeNode2.Text = "Giá theo thời điểm";
            treeNode3.BackColor = System.Drawing.Color.DimGray;
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.ImageKey = "PacKet.png";
            treeNode3.Name = "CaiDatChung";
            treeNode3.SelectedImageKey = "PacKet.png";
            treeNode3.Text = "Cài đặt chung";
            treeNode4.BackColor = System.Drawing.Color.Black;
            treeNode4.ForeColor = System.Drawing.Color.White;
            treeNode4.Name = "DanhMuc";
            treeNode4.Text = "Danh Mục";
            treeNode5.BackColor = System.Drawing.Color.DimGray;
            treeNode5.ForeColor = System.Drawing.Color.White;
            treeNode5.ImageKey = "WinRar.png";
            treeNode5.Name = "SoDoPhong";
            treeNode5.SelectedImageKey = "WinRar.png";
            treeNode5.Text = "Sơ đồ phòng";
            treeNode6.BackColor = System.Drawing.Color.DimGray;
            treeNode6.ForeColor = System.Drawing.Color.White;
            treeNode6.ImageKey = "Yugioh.png";
            treeNode6.Name = "DanhSachDatPhong";
            treeNode6.SelectedImageKey = "Yugioh.png";
            treeNode6.Text = "Danh sách đặt phòng";
            treeNode7.BackColor = System.Drawing.Color.DimGray;
            treeNode7.ForeColor = System.Drawing.Color.White;
            treeNode7.Name = "DanhSachThuePhong";
            treeNode7.Text = "Danh sách thuê phòng";
            treeNode8.BackColor = System.Drawing.Color.Black;
            treeNode8.ForeColor = System.Drawing.Color.White;
            treeNode8.ImageKey = "SQL.png";
            treeNode8.Name = "QuanLyphong";
            treeNode8.SelectedImageKey = "SQL.png";
            treeNode8.Text = "Quản lý phòng";
            treeNode9.BackColor = System.Drawing.Color.Black;
            treeNode9.ForeColor = System.Drawing.Color.White;
            treeNode9.Name = "NhanVien";
            treeNode9.Text = "Nhân viên";
            treeNode10.BackColor = System.Drawing.Color.Black;
            treeNode10.ForeColor = System.Drawing.Color.White;
            treeNode10.Name = "CachTinhChiPhi";
            treeNode10.Text = "Cách tính chi phí";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode9,
            treeNode10});
            this.tvMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tvMenu.SelectedImageKey = "DissCord.png";
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(244, 541);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvMenu_BeforeExpand);
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DissCord.png");
            this.imageList1.Images.SetKeyName(1, "GitHub.png");
            this.imageList1.Images.SetKeyName(2, "Havij.png");
            this.imageList1.Images.SetKeyName(3, "PacKet.png");
            this.imageList1.Images.SetKeyName(4, "SQL.png");
            this.imageList1.Images.SetKeyName(5, "WinRar.png");
            this.imageList1.Images.SetKeyName(6, "Yugioh.png");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Thistle;
            this.pnlMain.Location = new System.Drawing.Point(244, 37);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(815, 541);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.Controls.Add(this.txbTen);
            this.pnlMenu.Controls.Add(this.lblFormMain);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1059, 37);
            this.pnlMenu.TabIndex = 2;
            // 
            // txbTen
            // 
            this.txbTen.BackColor = System.Drawing.Color.Black;
            this.txbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.ForeColor = System.Drawing.Color.White;
            this.txbTen.Location = new System.Drawing.Point(885, 9);
            this.txbTen.Name = "txbTen";
            this.txbTen.ReadOnly = true;
            this.txbTen.Size = new System.Drawing.Size(164, 22);
            this.txbTen.TabIndex = 1;
            this.txbTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormMain
            // 
            this.lblFormMain.AutoSize = true;
            this.lblFormMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMain.ForeColor = System.Drawing.Color.Navy;
            this.lblFormMain.Location = new System.Drawing.Point(12, 9);
            this.lblFormMain.Name = "lblFormMain";
            this.lblFormMain.Size = new System.Drawing.Size(242, 20);
            this.lblFormMain.TabIndex = 0;
            this.lblFormMain.Text = "Phần mềm quản lý khách sạn";
            // 
            // frMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1061, 579);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblFormMain;
        private System.Windows.Forms.TextBox txbTen;
    }
}

