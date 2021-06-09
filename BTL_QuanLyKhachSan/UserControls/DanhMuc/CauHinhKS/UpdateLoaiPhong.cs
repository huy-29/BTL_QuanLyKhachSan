using BTL_QuanLyKhachSan.DAO;
using BTL_QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    public partial class UpdateLoaiPhong : Form
    {
        public UpdateLoaiPhong()
        {
            InitializeComponent();

            lblCheck_TenLoaiPhong.Visible = false;
            lblCheck_SoNguoi.Visible = false;
            lblCheck_GhiChu.Visible = false;
        }
        public void GetMaLoaiPhong(string MaLP) 
        {
            txbMaLoaiPhong.Text = MaLP;
            //pnlBonus.Visible = false;
            pnlBonus.Hide();
        }
        public void GetListLoaiPhong(ListViewItem lv) 
        {
            btnLuu.Visible = false;

            txbMaLoaiPhong.Text = lv.Text;
            txbMaLoaiPhong.ReadOnly = true;

            txbTenLoaiPhong.Text = lv.SubItems[0].Text;
            txbTenLoaiPhong.ReadOnly = true;
            
            txbSoNguoi.Text = lv.SubItems[1].Text;
            txbSoNguoi.ReadOnly = true;

            txbGhiChu.Text = lv.SubItems[2].Text;
            txbGhiChu.ReadOnly = true;

            txbMucGia.Text = lv.SubItems[3].Text;
            txbMucGia.ReadOnly = true;

            txbPhong.Text = lv.SubItems[4].Text;
            txbPhong.ReadOnly = true;
        }
        int Check()
        {
            List<LoaiPhong> listLP = new List<LoaiPhong>();

            foreach (LoaiPhong item in LoaiPhongDAO.Instance.GetListLoaiPhong())
            {
                listLP.Add(item);
            }

            int a = 0;
            if (txbTenLoaiPhong.Text == "")
            {
                return 1;
            }
            if (txbTenLoaiPhong.Text.Contains("--") || txbTenLoaiPhong.Text.Contains("'"))
            {
                return 2;
            }

            foreach (LoaiPhong item in listLP)
            {
                if (item.MaLoaiPhong != txbMaLoaiPhong.Text && string.Compare(item.TenLoaiPhong, txbTenLoaiPhong.Text,true) == 0)
                {
                    return 3;
                }
            }

            if (txbSoNguoi.Text == "")
            {
                return 4;
            }

            if (Regex.IsMatch(txbSoNguoi.Text, @"^[0-9]*$") == false)
            {
                return 5;
            }

            if (txbGhiChu.Text.Contains("--") || txbGhiChu.Text.Contains("'"))
            {
                return 6;
            }

            return a;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblCheck_TenLoaiPhong.Visible = false;
            lblCheck_SoNguoi.Visible = false;
            lblCheck_GhiChu.Visible = false;

            if (Check() == 0)
            {
                string MaLP = txbMaLoaiPhong.Text;
                string TenLP = txbTenLoaiPhong.Text;
                int SoNguoi = Convert.ToInt32(txbSoNguoi.Text);
                string GhiChu = txbGhiChu.Text;

                LoaiPhongDAO.Instance.UpdateLoaiPhong(MaLP, TenLP, SoNguoi, GhiChu);

                this.Close();
            }
            else if (Check() == 1)
            {
                lblCheck_TenLoaiPhong.Visible = true;
                lblCheck_TenLoaiPhong.Text = "Điền tên loại phòng";
            }
            else if (Check() == 1)
            {
                lblCheck_TenLoaiPhong.Visible = true;
                lblCheck_TenLoaiPhong.Text = "Tên phòng không hợp lệ";
            }
            else if (Check() == 3)
            {
                lblCheck_TenLoaiPhong.Visible = true;
                lblCheck_TenLoaiPhong.Text = "Tên loại phòng đã được sử dụng";
            }
            else if (Check() == 4)
            {
                lblCheck_SoNguoi.Visible = true;
                lblCheck_SoNguoi.Text = "Điền số người tối đa của loại phòng";
            }
            else if (Check() == 5)
            {
                lblCheck_SoNguoi.Visible = true;
                lblCheck_SoNguoi.Text = "Nhập vào một số";
            }
            else if (Check() == 6)
            {
                lblCheck_GhiChu.Visible = true;
                lblCheck_GhiChu.Text = "Ghi chú không hợp lệ";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
