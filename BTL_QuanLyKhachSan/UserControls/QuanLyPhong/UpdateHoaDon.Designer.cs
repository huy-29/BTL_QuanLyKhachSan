
namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    partial class UpdateHoaDon
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
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.txbTongHoaDon = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.BackColor = System.Drawing.Color.White;
            this.flpMain.Location = new System.Drawing.Point(14, 16);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(519, 571);
            this.flpMain.TabIndex = 0;
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Location = new System.Drawing.Point(563, 30);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(75, 13);
            this.lblTongHoaDon.TabIndex = 1;
            this.lblTongHoaDon.Text = "Tổng hóa đơn";
            // 
            // txbTongHoaDon
            // 
            this.txbTongHoaDon.Location = new System.Drawing.Point(552, 46);
            this.txbTongHoaDon.Name = "txbTongHoaDon";
            this.txbTongHoaDon.ReadOnly = true;
            this.txbTongHoaDon.Size = new System.Drawing.Size(100, 20);
            this.txbTongHoaDon.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(552, 545);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 42);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Green;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(552, 497);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(131, 42);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // UpdateHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(695, 602);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txbTongHoaDon);
            this.Controls.Add(this.lblTongHoaDon);
            this.Controls.Add(this.flpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.TextBox txbTongHoaDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
    }
}