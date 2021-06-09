using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    public class LoaiPhong
    {
        private string maLoaiPhong;
        private string tenLoaiPhong;
        private int soNguoi;
        private string ghiChu;

        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public LoaiPhong(string maLoaiPhong, string tenLoaiPhong, int soNguoi, string ghiChu)
        {
            this.MaLoaiPhong = maLoaiPhong;
            this.TenLoaiPhong = tenLoaiPhong;
            this.SoNguoi = soNguoi;
            this.GhiChu = ghiChu;
        }

        public LoaiPhong(DataRow row)
        {
            this.MaLoaiPhong = row["MaLoaiPhong"].ToString();
            this.TenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.SoNguoi = Convert.ToInt32(row["SoNguoi"]);
            
            var CheckGhiChu = row["GhiChu"];
            if (CheckGhiChu != "")
                this.GhiChu = row["GhiChu"].ToString();
        }
    }
}
