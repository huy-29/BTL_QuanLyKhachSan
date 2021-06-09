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
    class ThuePhongDAO
    {
        private static ThuePhongDAO instance;

        internal static ThuePhongDAO Instance
        {
            get { if (instance == null) instance = new ThuePhongDAO(); return instance; }
            private set { instance = value; }
        }
        private ThuePhongDAO() { }

        public List<ThuePhong> GetListThuePhong(string sx)
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = "SELECT * FROM dbo.ThuePhong WHERE TienDat = 0";
            if (sx == "Tất cả" || sx == "")
            {
                query = query + " ORDER BY CAST(MaThuePhong AS INT)"; 
            }
            else if(sx == "Phòng")
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

        public DateTime GetNgayBatDauByMaTP(string TP)
        {
            string query = string.Format("SELECT NgayBatDau FROM dbo.ThanhToan WHERE MaThuePhong = '{0} AND NgayKetThuc = '19001010''", TP);
            DateTime d1 = Convert.ToDateTime(DataProvider.Instance.ExecuteScalar(query));

            return d1;
        }
        public string GetGhiChuByMaTP(string TP)
        {
            string query = string.Format("SELECT GhiChu FROM dbo.ThanhToan WHERE MaThuePhong = '{0}' AND NgayKetThuc = '19001010'", TP);
            string a = DataProvider.Instance.ExecuteScalar(query).ToString();

            return a;
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

        public List<ThuePhong> TimThuePhong(string KH, string P, string Start, string End, int EndMuon, string sx)
        {
            List<ThuePhong> list = new List<ThuePhong>();
            string query = string.Format("SELECT b.* FROM dbo.KhachHang AS a, dbo.ThuePhong AS b, dbo.ThanhToan AS c WHERE a.MaKH = b.MaKH AND b.MaThuePhong = c.MaThuePhong AND TienDat = 0 AND c.NgayKetThuc = '19001010' AND (TenKH LIKE N'%{0}%' OR c.SoNguoi LIKE '%{0}%' OR GhiChu = N'%{0}%') AND MaPhong LIKE '%{1}%'", KH, P);

            if (Start == "err" || End == "err")
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

            if(EndMuon == 1)
            {
                query = string.Format(query + " AND NgayCheckOut < GETDATE()");
            }

            if (sx == "Tất cả" || sx == "")
            {
                query = query + " ORDER BY CAST(b.MaThuePhong AS INT)";
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

        public void UpdateTrangThaiPhong(string P)
        {
            string query = string.Format("EXEC dbo.UpdateTrangThaiPhong @P = '{0}'", P);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        //----------------------CHUYỂN PHÒNG------------------------
        public string GetMaThuePhongByMaPhong(string P)
        {
            string query = string.Format("SELECT MaThuePhong FROM dbo.ThuePhong WHERE MaPhong = '{0}' AND TienDat = 0", P);
            string TP = DataProvider.Instance.ExecuteScalar(query).ToString();

            return TP;
        }

        public List<ThanhToan> GetListThanhToanHienTaiByMaThuePhong(string TP)
        {
            List<ThanhToan> list = new List<ThanhToan>();

            string query = string.Format("SELECT * FROM dbo.ThanhToan WHERE MaThuePhong = '{0}' AND NgayKetThuc = '19001010'", TP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhToan p = new ThanhToan(item);
                list.Add(p);
            }

            return list;
        }
        public List<ThuePhong> GetListThuePhongByMaThuePhong(string TP)
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
        public List<Phong> GetListPhong()
        {
            List<Phong> list = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong ORDER BY MaPhong");

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                list.Add(p);
            }
            return list;
        }
        public List<Phong> GetListPhongTrong()
        {
            List<Phong> list = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong WHERE TrangThai = N'Trống' ORDER BY MaPhong");

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                list.Add(p);
            }
            return list;
        }

        public decimal GetLoaiDonGiaByMaMucGia(string MG, int Ngay)
        {
            decimal DG = 0;
            if(Ngay == 0)
            {
                string query = string.Format("SELECT DonGiaNgay FROM dbo.MucGia WHERE MaMucGia = '{0}'", MG);
                DG = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query));
            }
            else if (Ngay == 1)
            {
                string query = string.Format("SELECT DonGiaGio FROM dbo.MucGia WHERE MaMucGia = '{0}'", MG);
                DG = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query));
            }
            return DG;
        }

        public int GetChenhLechNguoiByMaTP(string TP)
        {
            string query = string.Format("SELECT a.SoNguoi - c.SoNguoi FROM dbo.ThanhToan AS a, dbo.MucGia AS b, dbo.LoaiPhong AS c WHERE a.MaMucGia = b.MaMucGia AND b.MaLoaiPhong = c.MaLoaiPhong AND a.MaThuePhong = '{0}' AND a.NgayKetThuc = '19001010'", TP);
            int max = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

            return max;
        }

        public void ChuyenPhong(string TP, string Pcu, string Pmoi, int Nguoi, string Start, string Now, string End, string tenMG, string PT, string GhiChu)
        {
            string query = string.Format("EXEC dbo.UpdateChuyenPhong @TP = '{0}', @Pcu = '{1}', @Pmoi = '{2}', @Nguoi = {3}, @Start = '{4}', @Now = '{5}', @End = '{6}', @tenMG = N'{7}', @PT = N'{8}', @GhiChu = N'{9}'", TP, Pcu, Pmoi, Nguoi, Start, Now, End, tenMG, PT, GhiChu);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
