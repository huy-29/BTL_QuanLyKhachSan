using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string dienThoai;
        private string diaChi;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public KhachHang(string maKhachHang, string tenKhachHang, string dienThoai, string diaChi)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.DienThoai = dienThoai;
            this.DiaChi = diaChi;
        }

        public KhachHang(DataRow row)
        {
            this.MaKhachHang = row["MaKH"].ToString();
            this.TenKhachHang = row["TenKH"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }
    }
}
