using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    class Phong
    {
        private string maPhong;
        private string maLoaiPhong;
        private string maTang;
        private string trangThai;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public string MaTang { get => maTang; set => maTang = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public Phong(string maPhong, string maLoaiPhong, string maTang, string trangThai)
        {
            this.MaPhong = maPhong;
            this.MaLoaiPhong = maLoaiPhong;
            this.MaTang = maTang;
            this.TrangThai = trangThai;
        }

        public Phong(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.MaLoaiPhong = row["MaLoaiPhong"].ToString();
            this.MaTang = row["MaTang"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }
    }
}
