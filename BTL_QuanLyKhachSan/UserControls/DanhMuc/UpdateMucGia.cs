using BTL_QuanLyKhachSan.DAO;
using BTL_QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.GiaTheoThoiDiem
{
    public partial class UpdateMucGia : Form
    {
        public UpdateMucGia()
        {
            InitializeComponent();
            lblCheck_TenMucGia.Visible = false;
            lblCheck_Loai.Visible = false;
            lblCheck_ThemNguoi.Visible = false;
            lblCheck_LoaiPhong.Visible = false;
            lblCheck_DonGiaNgay.Visible = false;
            lblCheck_DonGiaGio.Visible = false;

            lblCheck_NgayKetThuc.Visible = false;

            LoadComboBox();
        }

        public void GetMaMucGia(string MaMG)
        {
            txbMaMucGia.Text = MaMG;
            pnlLoai.Visible = false;
        }

        public void GetListMucGiaToUpdate(string MaMG)
        {
            txbMaMucGia.Text = MaMG;
            List<MucGia> list = MucGiaDAO.Instance.GetListMucGia();
            foreach(MucGia item in list)
            {
                if(item.MaMucGia == MaMG)
                {
                    txbTenMucGia.Text = item.TenMucGia;
                    
                    if(item.NgayBatDau.Year == 1900)
                    {
                        cbLoai.Text = cbLoai.Items[0].ToString();
                        pnlLoai.Visible = false;
                    }
                    else
                    {
                        pnlLoai.Visible = true;
                        cbLoai.Text = cbLoai.Items[1].ToString();
                        dtNgayBatDau.Value = item.NgayBatDau;
                        dtNgayKetThuc.Value = item.NgayKetThuc;
                    }

                    txbThemNguoi.Text = item.DonGiaThemNguoi.ToString();
                    foreach(LoaiPhong item1 in MucGiaDAO.Instance.GetListLoaiPhong())
                    {
                        if(item1.MaLoaiPhong == item.MaLoaiPhong)
                        {
                            cbLoaiPhong.Text = item1.TenLoaiPhong;
                        }
                    }
                    
                    txbDonGiaNgay.Text = item.DonGiaNgay.ToString();
                    txbDonGiaGio.Text = item.DonGiaGio.ToString();
                }
            }

            pnlLoai.Visible = false;
        }

        void LoadComboBox()
        {
            List<LoaiPhong> listLP = MucGiaDAO.Instance.GetListLoaiPhong();
  
            cbLoaiPhong.DataSource = listLP;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }
        int Check()
        {
            List<MucGia> listLP = new List<MucGia>();

            foreach (MucGia item in MucGiaDAO.Instance.GetListMucGia())
            {
                listLP.Add(item);
            }

            int a ;
            decimal b;
            if (txbTenMucGia.Text == "")
            {
                return 1;
            }

            foreach (MucGia item in listLP)
            {
                if (item.MaMucGia != txbMaMucGia.Text && string.Compare(item.TenMucGia, txbTenMucGia.Text, true) == 0)
                {
                    return 2;
                }
            }

            if (txbTenMucGia.Text.Contains("'") || txbTenMucGia.Text.Contains("--"))
            {
                return 3;
            }

            if (cbLoai.Text == "")
            {
                return 4;
            }
            if (txbThemNguoi.Text == "")
            {
                return 5;
            }
            if (Regex.IsMatch(txbThemNguoi.Text, @"^[0-9]*$") == false)
            {
                return 6;
            }
            if (cbLoaiPhong.Text == "")
            {
                return 7;
            }
            a = 8;
            foreach (LoaiPhong item1 in MucGiaDAO.Instance.GetListLoaiPhong())
            {
                if (item1.TenLoaiPhong == cbLoaiPhong.Text)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 8) { return 8; }
            if (txbDonGiaNgay.Text == "")
            {
                return 9;
            }
            if (Regex.IsMatch(txbDonGiaNgay.Text, @"^[0-9]*$") == false)
            {
                return 10;
            }
            if (txbDonGiaGio.Text == "")
            {
                return 11;
            }
            if (Regex.IsMatch(txbDonGiaGio.Text, @"^[0-9]*$") == false)
            {
                return 12;
            }
            return a;
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLoai.Text == "Giá mặc định")
            {
                pnlLoai.Visible = false;
            }
            else if(cbLoai.Text == "Giá theo khoảng ngày")
            {
                pnlLoai.Visible = true;
            }
        }

        int CheckKhoangNgay()
        {
            DateTime dt1 = dtNgayBatDau.Value;
            DateTime dt2 = dtNgayKetThuc.Value;

            int a = 0;
            if(dt2.Year < dt1.Year) { a = 1; }

            else if(dt2.Year == dt1.Year)
            {
                if(dt2.Month < dt1.Month) { a = 1; }
                else if(dt2.Month == dt1.Month)
                {
                    if(dt2.Day < dt1.Day) { a = 1; }
                }
            }
            return a;
        }

        void Update()
        {
            string MaMG = txbMaMucGia.Text;
            string TenMG = txbTenMucGia.Text;

            DateTime d1 = new DateTime(1900, 10, 10);
            DateTime d2 = new DateTime(1900, 10, 10);
            if (pnlLoai.Visible == true)
            {
                d1 = dtNgayBatDau.Value;
                d2 = dtNgayKetThuc.Value;
            }

            string Start = "";
            string End = ""; 

            if (d1.Month < 10)
            {
                if(d1.Day < 10)
                {
                    Start = string.Format(d1.Year.ToString()+"0"+d1.Month.ToString()+"0"+d1.Day.ToString());
                }
                else if(d1.Day >= 10)
                {
                    Start = string.Format(d1.Year.ToString()+"0"+d1.Month.ToString()+d1.Day.ToString());
                }
            }
            else if(d1.Month >= 10)
            {
                if (d1.Day < 10)
                {
                    Start = string.Format(d1.Year.ToString()+d1.Month.ToString()+"0"+d1.Day.ToString());
                }
                else if (d1.Day >= 10)
                {
                    Start = string.Format(d1.Year.ToString() + d1.Month.ToString() + d1.Day.ToString());
                }
            }

            if (d2.Month < 10)
            {
                if (d2.Day < 10)
                {
                    End = string.Format(d2.Year.ToString()+"0"+d2.Month.ToString()+"0"+d2.Day.ToString());
                }
                else if (d2.Day >= 10)
                {
                    End = string.Format(d2.Year.ToString()+"0"+d2.Month.ToString()+d2.Day.ToString());
                }
            }
            else if (d2.Month >= 10)
            {
                if (d2.Day < 10)
                {
                    End = string.Format(d2.Year.ToString()+d2.Month.ToString()+"0"+d2.Day.ToString());
                }
                else if (d2.Day >= 10)
                {
                    End = string.Format(d2.Year.ToString() + d2.Month.ToString() + d2.Day.ToString());
                }
            }

            decimal Them = Convert.ToDecimal(txbThemNguoi.Text);
            string TenLP = cbLoaiPhong.Text;
            decimal Ngay = Convert.ToDecimal(txbDonGiaNgay.Text);
            decimal Gio = Convert.ToDecimal(txbDonGiaGio.Text);

            MucGiaDAO.Instance.UpdateLoaiPhong(MaMG, TenMG, Ngay, Gio, Them, Start, End, TenLP);

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblCheck_TenMucGia.Visible = false;
            lblCheck_Loai.Visible = false;
            lblCheck_ThemNguoi.Visible = false;
            lblCheck_LoaiPhong.Visible = false;
            lblCheck_DonGiaNgay.Visible = false;
            lblCheck_DonGiaGio.Visible = false;
            lblCheck_NgayKetThuc.Visible = false;

            if (Check() == 1)
            {
                lblCheck_TenMucGia.Visible = true;
                lblCheck_TenMucGia.Text = "Điền tên mức giá";
            }
            else if (Check() == 2)
            {
                lblCheck_TenMucGia.Visible = true;
                lblCheck_TenMucGia.Text = "Tên mức giá đã được sử dụng";
            }
            else if (Check() == 3)
            {
                lblCheck_TenMucGia.Visible = true;
                lblCheck_TenMucGia.Text = "Tên mức giá không hợp lệ";
            }
            else if (Check() == 4)
            {
                lblCheck_Loai.Visible = true;
                lblCheck_Loai.Text = "Chọn một phương thức cho mức giá";
            }
            else if (Check() == 5)
            {
                lblCheck_ThemNguoi.Visible = true;
                lblCheck_ThemNguoi.Text = "Điền mức giá thêm người";
            }
            else if (Check() == 6)
            {
                lblCheck_ThemNguoi.Visible = true;
                lblCheck_ThemNguoi.Text = "Điền vào một số";
            }
            else if (Check() == 7)
            {
                lblCheck_LoaiPhong.Visible = true;
                lblCheck_LoaiPhong.Text = "Điền loại phòng mà mức giá áp dụng";
            }
            else if (Check() == 8)
            {
                lblCheck_LoaiPhong.Visible = true;
                lblCheck_LoaiPhong.Text = "Loại phòng không tồn tại";
            }
            else if (pnlLoai.Visible == true && CheckKhoangNgay() == 1)
            {
                lblCheck_NgayKetThuc.Visible = true;
                lblCheck_NgayKetThuc.Text = "Ngày kết thúc phải có sau ngày bắt đầu";
            }
            else if (Check() == 9)
            {
                lblCheck_DonGiaNgay.Visible = true;
                lblCheck_DonGiaNgay.Text = "Điền đơn giá theo ngày";
            }
            else if (Check() == 10)
            {
                lblCheck_DonGiaNgay.Visible = true;
                lblCheck_DonGiaNgay.Text = "Điền vào một số";
            }
            else if (Check() == 11)
            {
                lblCheck_DonGiaGio.Visible = true;
                lblCheck_DonGiaGio.Text = "Điền đơn giá theo giờ";
            }
            else if (Check() == 12)
            {
                lblCheck_DonGiaGio.Visible = true;
                lblCheck_DonGiaGio.Text = "Điền vào một số";
            }
            else if (pnlLoai.Visible == true)
            {
                if (Check() == 0 && CheckKhoangNgay() == 0) { Update(); }
                this.Close();
            }
            else if(pnlLoai.Visible == false)
            {
                if (Check() == 0) { Update(); }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<LoaiPhong> list = PhongDAO.Instance.GetListLoaiPhong();

            foreach (LoaiPhong item in list)
            {
                if (item.TenLoaiPhong == cbLoaiPhong.Text)
                {
                    txbMaLoaiPhong.Text = item.MaLoaiPhong;
                    break;
                }
            }
        }

    }
}
