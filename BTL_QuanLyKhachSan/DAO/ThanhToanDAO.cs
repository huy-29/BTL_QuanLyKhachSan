using BTL_QuanLyKhachSan.DTO;
using QuanLyThuHocPhi.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DAO
{
    public class ThanhToanDAO
    {
        private static ThanhToanDAO instance;

        internal static ThanhToanDAO Instance
        {
            get { if (instance == null) instance = new ThanhToanDAO(); return instance; }
            private set { instance = value; }
        }
        private ThanhToanDAO() { }

        public List<ThanhToan> GetListThanhToanByMaTP(string TP)
        {
            List<ThanhToan> list = new List<ThanhToan>();

            string query = string.Format("SELECT * FROM dbo.ThanhToan WHERE MaThuePhong = '{0}' ORDER BY NgayBatDau", TP);
         
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhToan tp = new ThanhToan(item);
                list.Add(tp);
            }
            return list;
        }

        public string GetMaPhongByMaTP(string TP)
        {
            //string query = string.Format("SELECT MaPhong FROM dbo.ThuePhong AS a, dbo.ThanhToan AS b WHERE a.MaThuePhong = b.MaThuePhong AND b.MaThuePhong = '{0}' GROUP BY MaPhong", TP);
            string query = string.Format("SELECT MaPhong FROM dbo.ThuePhong WHERE MaThuePhong = '{0}'", TP);

            string P = DataProvider.Instance.ExecuteScalar(query).ToString();

            return P;
        }
        public DateTime GetCheckInByMaTP(string TP)
        {
            string query = string.Format("SELECT NgayCheckIn FROM dbo.ThuePhong AS a, dbo.ThanhToan AS b WHERE a.MaThuePhong = b.MaThuePhong AND b.MaThuePhong = '{0}' GROUP BY NgayCheckIn", TP);

            DateTime checkin = Convert.ToDateTime(DataProvider.Instance.ExecuteScalar(query));

            return checkin;
        }
        public DateTime GetCheckOutByMaTP(string TP)
        {
            string query = string.Format("SELECT NgayCheckOut FROM dbo.ThuePhong AS a, dbo.ThanhToan AS b WHERE a.MaThuePhong = b.MaThuePhong AND b.MaThuePhong = '{0}' GROUP BY NgayCheckOut", TP);

            DateTime checkout = Convert.ToDateTime(DataProvider.Instance.ExecuteScalar(query));

            return checkout;
        }
        public string GetMucGiaByMaTT(string TT, string PT)
        {
            string query = "";
            if (PT == "Ngày")
            {
                query = string.Format("SELECT DonGiaNgay FROM dbo.ThanhToan AS a, dbo.MucGia AS b WHERE a.MaMucGia = b.MaMucGia AND a.MaPhieuTT = {0}", TT);
            }
            else if(PT == "Giờ")
            {
                query = string.Format("SELECT DonGiaGio FROM dbo.ThanhToan AS a, dbo.MucGia AS b WHERE a.MaMucGia = b.MaMucGia AND a.MaPhieuTT = {0}", TT);

            }
            string mg = DataProvider.Instance.ExecuteScalar(query).ToString();

            return mg;
        }
        public int GetChenhLechNguoiByMaTT(string TT)
        {
            string query = string.Format("SELECT a.SoNguoi - c.SoNguoi FROM dbo.ThanhToan AS a, dbo.MucGia AS b, dbo.LoaiPhong AS c WHERE a.MaMucGia = b.MaMucGia AND b.MaLoaiPhong = c.MaLoaiPhong AND a.MaPhieuTT = '{0}'", TT);
            int max = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

            return max;
        }
        public decimal GetGiaThemNguoiByMaTT(string TT)
        {
            string query = string.Format("SELECT DonGiaThemNguoi FROM dbo.ThanhToan AS a, dbo.MucGia AS b, dbo.LoaiPhong AS c WHERE a.MaMucGia = b.MaMucGia AND b.MaLoaiPhong = c.MaLoaiPhong AND a.MaPhieuTT = '{0}'", TT);
            decimal max = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query));

            return max;
        }
        public List<ThanhToanPhu> GetListThanhToanPhuByMaTT(string TT)
        {
            List<ThanhToanPhu> list = new List<ThanhToanPhu>();

            string query = string.Format("SELECT * FROM dbo.ThanhToanPhu WHERE MaPhieuTT = '{0}'", TT);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhToanPhu ttp = new ThanhToanPhu(item);
                list.Add(ttp);
            }
            return list;
        }

        public void  UpdateThanhToanPhu(string TT, decimal T, string GhiChu)
        {
            string query = string.Format("INSERT dbo.ThanhToanPhu (MaPhieuTTP, SoTien, GhiChu, MaPhieuTT) VALUES (dbo.TaoMaPhieuTTP(), {0}, N'{1}', '{2}' )", T, GhiChu, TT);

            DataProvider.Instance.ExecuteNonQuery(query);           
        }

        public void XoaThanhToanByMaTP(string TP)
        {
            string query = string.Format("SELECT * FROM dbo.ThanhToan WHERE MaThuePhong = '{0}'", TP);

            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
