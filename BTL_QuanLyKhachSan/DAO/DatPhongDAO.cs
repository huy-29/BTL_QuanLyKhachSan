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
    class DatPhongDAO
    {
        private static DatPhongDAO instance;

        internal static DatPhongDAO Instance
        {
            get { if (instance == null) instance = new DatPhongDAO(); return instance; }
            private set { instance = value; }
        }
        private DatPhongDAO() { }

        public List<ThuePhong> GetListThuePhong(string sx)
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = "SELECT * FROM dbo.ThuePhong WHERE TienDat <> 0";
            if (sx == "Tất cả" || sx == "")
            {
                query = query + " ORDER BY CAST(MaThuePhong AS INT)";
            }
            else if (sx == "Phòng")
            {
                query = query + " ORDER BY MaPhong";
            }
            else if (sx == "Check-in")
            {
                query = query + " ORDER BY NgayCheckIn";
            }
            else if (sx == "Check-out")
            {
                query = query + " ORDER BY NgayCheckOut";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong tp = new ThuePhong(item);
                list.Add(tp);
            }
            return list;
        }

        public List<KhachHang> GetListKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KhachHang");

            foreach (DataRow item in data.Rows)
            {
                KhachHang kh = new KhachHang(item);
                list.Add(kh);
            }
            return list;
        }
        public List<ThuePhong> TimDatPhong(string KH, string P, string Start, string End, string sx)
        {
            List<ThuePhong> list = new List<ThuePhong>();
            string query = string.Format("SELECT a.* FROM dbo.ThuePhong AS a, dbo.KhachHang AS b WHERE a.MaKH = b.MaKH AND TienDat <> 0 AND (TenKH LIKE N'%{0}%' OR SoNguoi LIKE '%{0}%' OR TienDat LIKE '%{0}%') AND MaPhong LIKE '%{1}%'", KH, P);

            if(Start == "err" || End == "err")
            {
                query = query + " AND 1 = -1";
            }
            else
            {
                if (Start != "")
                {
                    query = string.Format(query + " AND NgayCheckIn >= '{0}'", Start);
                }

                if (End != "")
                {
                    query = string.Format(query + " AND NgayCheckOut <= '{0}'", End);
                }
            }

            if (sx == "Tất cả" || sx == "")
            {
                query = query + " ORDER BY CAST(a.MaThuePhong AS INT)";
            }
            else if (sx == "Phòng")
            {
                query = query + " ORDER BY MaPhong";
            }
            else if (sx == "Check-in")
            {
                query = query + " ORDER BY NgayCheckIn";
            }
            else if (sx == "Check-out")
            {
                query = query + " ORDER BY NgayCheckOut";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong tp = new ThuePhong(item);
                list.Add(tp);
            }
            return list;
        }

        public string GetMaThuePhong()
        {
            string query = string.Format("SELECT dbo.TaoMaThuePhong()");
            string MaTP = DataProvider.Instance.ExecuteScalar(query).ToString();

            return MaTP;
        }
        public string GetMaKH()
        {
            string query = string.Format("SELECT dbo.TaoMaKhachHang()");
            string MaKH = DataProvider.Instance.ExecuteScalar(query).ToString();

            return MaKH;
        }

        public string GetMaKhachHangByMaTP(string TP)
        {
            string query = string.Format("SELECT MaKH FROM dbo.ThuePhong WHERE MaThuePhong = '{0}'",TP);
            string MaKH = DataProvider.Instance.ExecuteScalar(query).ToString();

            return MaKH;
        }

        public string GetTrangThaiPhongByMaPhong(string P)
        {
            string query = string.Format("SELECT TrangThai FROM dbo.Phong WHERE MaPhong = '{0}'", P);
            string TT = DataProvider.Instance.ExecuteScalar(query).ToString();

            return TT;
        }
        public List<ThuePhong> GetListThuePhongByMaPhong(string P)
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = string.Format("SELECT * FROM dbo.ThuePhong WHERE MaPhong = '{0}' AND TienDat = 0 ORDER BY NgayCheckIn", P);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong tp = new ThuePhong(item);
                list.Add(tp);
            }
            return list;
        }
        public List<ThuePhong> GetListDatPhongByMaTP(string TP)
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = string.Format("SELECT * FROM dbo.ThuePhong WHERE MaThuePhong = '{0}'", TP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong tp = new ThuePhong(item);
                list.Add(tp);
            }
            return list;
        }
        public void NhanPhong(string TP, decimal TienDat)
        {
            decimal T = -TienDat;
            string query = string.Format("EXEC dbo.NhanPhong @MaTP = '{0}',  @TienDat = {1}", TP, T);
            DataProvider.Instance.ExecuteNonQuery(query);           
        }

        public void XoaDatPhong(string TP)
        {  
            string query = string.Format("DELETE dbo.ThanhToan WHERE MaThuePhong = '{0}'", TP);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
