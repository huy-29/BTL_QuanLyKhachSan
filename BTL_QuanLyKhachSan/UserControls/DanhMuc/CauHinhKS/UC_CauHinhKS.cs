using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyKhachSan.DTO;

namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    public partial class UC_CauHinhKS : UserControl
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }
        public UC_CauHinhKS(DangNhap dangNhap)
        {
            InitializeComponent();

            this.DangNhap = dangNhap;
        }

        private void mnsToolDanhSachPhong_Click(object sender, EventArgs e)
        {
            UC_DanhSachPhong f = new UC_DanhSachPhong(DangNhap);
            pnlCauHinhKS.Controls.Clear();
            pnlCauHinhKS.Controls.Add(f);

            foreach (ToolStripMenuItem item in mnsCauHinhKS.Items)
            {
                item.BackColor = Color.Aquamarine;
            }

            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            if (tool != null)
            {
                tool.BackColor = Color.LightGray;
            }
        }

        private void mnsToolDanhSachTang_Click(object sender, EventArgs e)
        {
            UC_DanhSachTang f = new UC_DanhSachTang(DangNhap);
            pnlCauHinhKS.Controls.Clear();
            pnlCauHinhKS.Controls.Add(f);

            foreach (ToolStripMenuItem item in mnsCauHinhKS.Items)
            {
                item.BackColor = Color.Aquamarine;
            }

            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            if (tool != null)
            {
                tool.BackColor = Color.LightGray;
            }
        }

        private void mnsToolDanhSachLoaiPhong_Click(object sender, EventArgs e)
        {
            UC_DanhSachLoaiPhong f = new UC_DanhSachLoaiPhong(DangNhap);
            pnlCauHinhKS.Controls.Clear();
            pnlCauHinhKS.Controls.Add(f);

            foreach (ToolStripMenuItem item in mnsCauHinhKS.Items)
            {
                item.BackColor = Color.Aquamarine;
            }

            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            if (tool != null)
            {
                tool.BackColor = Color.LightGray;
            }
        }

        private void mnsCauHinhKS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in mnsCauHinhKS.Items)
            {
                item.BackColor = Color.Aquamarine;
            }
            
            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            if(tool != null)
            {
                tool.BackColor = Color.LightGray;
            }
        }

        private void mnsCauHinhKS_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in mnsCauHinhKS.Items)
            {
                item.BackColor = Color.Aquamarine;
            }

            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            if (tool != null)
            {
                tool.BackColor = Color.LightGray;
            }
        }
    }
}
