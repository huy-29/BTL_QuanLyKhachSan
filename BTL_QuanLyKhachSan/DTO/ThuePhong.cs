using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    public class ThuePhong
    {
        private string maThuePhong;
        private string maKhachHang;
        private string maPhong;
        private int soNguoi;
        private DateTime checkIn;
        private DateTime checkOut;
        private decimal tienDat;

        public string MaThuePhong { get => maThuePhong; set => maThuePhong = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public decimal TienDat { get => tienDat; set => tienDat = value; }

        public ThuePhong(string maThuePhong, string maKhachHang, string maPhong, int soNguoi, DateTime checkIn, DateTime checkOut, decimal tienDat)
        {
            this.MaThuePhong = maThuePhong;
            this.MaKhachHang = maKhachHang;
            this.MaPhong = maPhong;
            this.SoNguoi = soNguoi;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.TienDat = tienDat;
        }

        public ThuePhong(DataRow row)
        {
            this.MaThuePhong = row["MaThuePhong"].ToString();
            this.MaKhachHang = row["MaKH"].ToString();
            this.MaPhong = row["MaPhong"].ToString();
            this.SoNguoi = Convert.ToInt32(row["SoNguoi"]);
            this.CheckIn = Convert.ToDateTime(row["NgayCheckIn"]);
            this.CheckOut = Convert.ToDateTime(row["NgayCheckOut"]);
            this.TienDat = Convert.ToDecimal(row["TienDat"]);
        }
    }
}
