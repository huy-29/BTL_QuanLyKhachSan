using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    public class DangNhap
    {
        private string tenDangNhap;
        private string matKhau;
        private string tenNguoiDung;
        private string chucVu;
        
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public DangNhap(string tenDangNhap, string tenNguoiDung, string chucVu, string matKhau = null)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.TenNguoiDung = tenNguoiDung;
            this.ChucVu = chucVu;
        }

        public DangNhap(DataRow row)
        {
            this.TenDangNhap = row["TaiKhoan"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.TenNguoiDung = row["Ten"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
        }
    }
}
