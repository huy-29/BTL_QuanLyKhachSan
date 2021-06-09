using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    class MucGia
    {
        private string maMucGia;
        private string tenMucGia;
        private decimal donGiaNgay;
        private decimal donGiaGio;
        private decimal donGiaThemNguoi;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string maLoaiPhong;

        public string MaMucGia { get => maMucGia; set => maMucGia = value; }
        public string TenMucGia { get => tenMucGia; set => tenMucGia = value; }
        public decimal DonGiaNgay { get => donGiaNgay; set => donGiaNgay = value; }
        public decimal DonGiaGio { get => donGiaGio; set => donGiaGio = value; }
        public decimal DonGiaThemNguoi { get => donGiaThemNguoi; set => donGiaThemNguoi = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }

        public MucGia(string maMucGia, string tenMucGia, decimal donGiaNgay, decimal donGiaGio, decimal donGiaThemNguoi, DateTime ngayBatDau, DateTime ngayKetThuc, string maLoaiPhong)
        {
            this.MaMucGia = maMucGia;
            this.TenMucGia = tenMucGia;
            this.DonGiaNgay = donGiaNgay;
            this.DonGiaGio = donGiaGio;
            this.DonGiaThemNguoi = donGiaThemNguoi;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.MaLoaiPhong = maLoaiPhong;
        }

        public MucGia(DataRow row)
        {
            this.MaMucGia = row["MaMucGia"].ToString();
            this.TenMucGia = row["TenMucGia"].ToString();
            this.DonGiaNgay = Convert.ToDecimal(row["DonGiaNgay"]);
            this.DonGiaGio = Convert.ToDecimal(row["DonGiaGio"]);
            this.DonGiaThemNguoi = Convert.ToDecimal(row["DonGiaThemNguoi"]);
            this.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
            this.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]);
            this.MaLoaiPhong = row["MaLoaiPhong"].ToString();
        }
    }
}
