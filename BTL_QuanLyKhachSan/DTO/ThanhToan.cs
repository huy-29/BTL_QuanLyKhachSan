using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    public class ThanhToan
    {
        private string maPhieuTT;
        private string maThuePhong;
        private string maMucGia;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private int soNguoi;
        private string phuongThucTT;
        private decimal tongTien;
        private string ghiChu;

        public string MaPhieuTT { get => maPhieuTT; set => maPhieuTT = value; }
        public string MaThuePhong { get => maThuePhong; set => maThuePhong = value; }
        public string MaMucGia { get => maMucGia; set => maMucGia = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public string PhuongThucTT { get => phuongThucTT; set => phuongThucTT = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }



        public ThanhToan(string maPhieuTT, string maThuePhong, string maMucGia, DateTime ngayBatDau, DateTime ngayKetThuc, int soNguoi, string phuongThucTT, decimal tongTien, string ghiChu)
        {
            this.MaPhieuTT = maPhieuTT;
            this.MaThuePhong = maThuePhong;
            this.MaMucGia = maMucGia;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.SoNguoi = soNguoi;
            this.PhuongThucTT = phuongThucTT;
            this.TongTien = tongTien;
            this.GhiChu = ghiChu;
        }

        public ThanhToan(DataRow row)
        {
            this.MaPhieuTT = row["MaPhieuTT"].ToString();
            this.MaThuePhong = row["MaThuePhong"].ToString();
            this.MaMucGia = row["MaMucGia"].ToString();
            this.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
            this.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]);
            this.SoNguoi = Convert.ToInt32(row["SoNguoi"]);
            this.PhuongThucTT = row["PhuongThucTT"].ToString();          
            this.TongTien = Convert.ToDecimal(row["TongTien"]);

            var CheckGhiChu = row["GhiChu"];
            if (CheckGhiChu != "")
                this.GhiChu = row["GhiChu"].ToString();
        }
    }
}
