using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    public class ThanhToanPhu
    {
        private string maPhieuTTP;
        private decimal soTien;
        private string ghiChu;
        private string maPhieuTT;

        public string MaPhieuTTP { get => maPhieuTTP; set => maPhieuTTP = value; }
        public decimal SoTien { get => soTien; set => soTien = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string MaPhieuTT { get => maPhieuTT; set => maPhieuTT = value; }
        
        public ThanhToanPhu(string maPhieuTTP, decimal soTien, string ghiChu, string maPhieuTT)
        {
            this.MaPhieuTTP = maPhieuTTP;
            this.SoTien = soTien;
            this.GhiChu = ghiChu;
            this.MaPhieuTT = maPhieuTT;
        }

        public ThanhToanPhu(DataRow row)
        {
            this.MaPhieuTTP = row["MaPhieuTTP"].ToString();
            this.SoTien = Convert.ToDecimal(row["SoTien"]);
            this.GhiChu = row["GhiChu"].ToString();
            this.MaPhieuTT = row["MaPhieuTT"].ToString();
        }
    }
}
