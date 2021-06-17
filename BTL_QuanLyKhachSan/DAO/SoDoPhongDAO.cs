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
    class SoDoPhongDAO
    {
        private static SoDoPhongDAO instance;

        internal static SoDoPhongDAO Instance
        {
            get { if (instance == null) instance = new SoDoPhongDAO(); return instance; }
            private set { instance = value; }
        }
        private SoDoPhongDAO() { }

        public List<Phong> TimPhongChoSoDoPhong(string T, string LP, string St)
        {
            List<Phong> list = new List<Phong>();

            string query = string.Format("SELECT a.* FROM dbo.Phong AS a, dbo.Tang AS b, dbo.LoaiPhong AS c WHERE a.MaTang = b.MaTang AND a.MaLoaiPhong = c.MaLoaiPhong AND a.MaTang LIKE '%{0}%' AND TenLoaiPhong LIKE N'%{1}%' AND TrangThai LIKE N'%{2}%' ORDER BY MaPhong", T, LP, St);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                list.Add(p);
            }

            return list;
        }

        public bool DoiTrangThaiPhong(string P, string TT)
        {
            string query = string.Format("UPDATE dbo.Phong SET TrangThai = N'{0}' WHERE MaPhong = '{1}'", TT, P);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
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

        public List<ThuePhong> GetListThuePhongByMaThuePhong(string TP)
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = string.Format("SELECT * FROM dbo.ThuePhong WHERE MaThuePhong = '{0}'", TP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong p = new ThuePhong(item);
                list.Add(p);
            }

            return list;
        }
        public List<KhachHang> GetListKhachHangByMaKH(string KH)
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = string.Format("SELECT * FROM dbo.KhachHang WHERE MaKH = '{0}'", KH);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang p = new KhachHang(item);
                list.Add(p);
            }

            return list;
        }
        public List<ThanhToan> GetListThanhToanHienTaiByMaThuePhong(string TP)
        {
            List<ThanhToan> list = new List<ThanhToan>();

            string query = string.Format("SELECT * FROM dbo.ThanhToan WHERE MaThuePhong = '{0}' AND YEAR(NgayKetThuc) = '1900'", TP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhToan p = new ThanhToan(item);
                list.Add(p);
            }

            return list;
        }
        public List<MucGia> GetListMucGiaByMaMucGia(string MG)
        {
            List<MucGia> list = new List<MucGia>();

            string query = string.Format("SELECT * FROM dbo.MucGia WHERE MaMucGia = '{0}'", MG);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MucGia mg = new MucGia(item);
                list.Add(mg);
            }

            return list;
        }

        public List<MucGia> GetListMucGiaByMaPhong(string P)
        {
            List<MucGia> list = new List<MucGia>();

            string query = string.Format("SELECT b.* FROM Phong AS a, dbo.MucGia AS b WHERE a.MaLoaiPhong = b.MaLoaiPhong AND MaPhong = '{0}'", P);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MucGia mg = new MucGia(item);
                list.Add(mg);
            }
            
            return list;
        }

        public List<MucGia> GetListMucGiaByTenMucGia(string TenMG)
        {
            List<MucGia> list = new List<MucGia>();

            string query = string.Format("SELECT * FROM dbo.MucGia WHERE TenMucGia = N'{0}'", TenMG);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MucGia mg = new MucGia(item);
                list.Add(mg);
            }

            return list;
        }
        public List<ThuePhong> GetListThuePhong()
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = string.Format("SELECT * FROM dbo.ThuePhong");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong tp = new ThuePhong(item);
                list.Add(tp);
            }

            return list;
        }
        public List<ThanhToan> GetListThanhToan()
        {
            List<ThanhToan> list = new List<ThanhToan>();

            string query = string.Format("SELECT * FROM dbo.ThanhToan");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhToan tp = new ThanhToan(item);
                list.Add(tp);
            }

            return list;
        }
        public List<ThuePhong> GetListThuePhongByMaPhong(string P)
        {
            List<ThuePhong> list = new List<ThuePhong>();

            string query = string.Format("SELECT * FROM dbo.ThuePhong WHERE MaPhong = '{0}' ORDER BY NgayCheckIn", P);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuePhong tp = new ThuePhong(item);
                list.Add(tp);
            }

            return list;
        }
        public string GetTrangThaiPhongByMaPhong(string P)
        {
            string query = string.Format("SELECT TrangThai FROM dbo.Phong WHERE MaPhong = '{0}'", P);
            string TT = DataProvider.Instance.ExecuteScalar(query).ToString();

            return TT;
        }
        public bool UpdateThuePhong(string Task, string MaTP, string MaKH, string MaP, int Nguoi, string Start, string End, decimal TienDat, string TenKH, string DT, string DiaChi, string TenMG, string PhuongThuc)
        {
            string query = "";
            if (Task == "Thêm" || Task == "Đặt mới")
            {
                query = string.Format("EXEC dbo.ThemMoiThuePhong @MaTP = '{0}', @MaKH = '{1}', @MaP = '{2}', @SoNg = {3}, @Start = '{4}', @End = '{5}', @TienDat = {6}, @TenKH = N'{7}', @DienThoai = '{8}', @DiaChi = N'{9}', @TenMG = N'{10}', @PhuongThuc = N'{11}' ", MaTP, MaKH, MaP, Nguoi, Start, End, TienDat, TenKH, DT, DiaChi, TenMG, PhuongThuc);
            }
            else if(Task == "Sửa đặt phòng")
            {
                query = string.Format("EXEC dbo.SuaDatPhong @MaTP = '{0}', @MaKH = '{1}', @MaP = '{2}', @SoNg = {3}, @Start = '{4}', @End = '{5}', @TienDat = {6}, @TenKH = N'{7}', @DienThoai = '{8}', @DiaChi = N'{9}', @TenMG = N'{10}', @PhuongThuc = N'{11}' ", MaTP, MaKH, MaP, Nguoi, Start, End, TienDat, TenKH, DT, DiaChi, TenMG, PhuongThuc);
            }
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string GetMaThuePhongHienTaiByMaPhong(string P)
        {
            string query = string.Format("SELECT MaThuePhong FROM dbo.ThuePhong WHERE MaPhong = '{0}' AND TienDat = 0", P);
            string TP = DataProvider.Instance.ExecuteScalar(query).ToString();
            return TP;
        }

        public DateTime GetCheckOutByMaPhongDangThue(string P)
        {
            string query = string.Format("SELECT NgayCheckOut FROM dbo.ThuePhong WHERE MaPhong = '{0}' AND TienDat = 0", P);
            DateTime CheckOut = Convert.ToDateTime(DataProvider.Instance.ExecuteScalar(query));
            return CheckOut;
        }
    }
}


















































