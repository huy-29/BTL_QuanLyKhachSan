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
    class MucGiaDAO
    {
        private static MucGiaDAO instance;

        internal static MucGiaDAO Instance
        {
            get { if (instance == null) instance = new MucGiaDAO(); return instance; }
            private set { instance = value; }
        }
        private MucGiaDAO() { }

        public List<MucGia> GetListMucGia()
        {
            List<MucGia> list = new List<MucGia>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.MucGia ORDER BY CAST(MaMucGia AS INT)");

            foreach (DataRow item in data.Rows)
            {
                MucGia mg = new MucGia(item);
                list.Add(mg);
            }
            return list;
        }
        public List<LoaiPhong> GetListLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiPhong ORDER BY CAST(MaLoaiPhong AS INT)");

            foreach (DataRow item in data.Rows)
            {
                LoaiPhong tang = new LoaiPhong(item);
                list.Add(tang);
            }
            return list;
        }
        public bool UpdateLoaiPhong(string maMG, string tenMG, decimal Ngay, decimal Gio, decimal Them, string Start, string End, string TenLP)
        {
            string query = string.Format("dbo.UpdateMucGia @maMG = '{0}', @tenMG = N'{1}', @Ngay = {2}, @Gio = {3}, @ThemNguoi = {4}, @Start = '{5}', @End = '{6}', @TenLP = N'{7}'", maMG, tenMG, Ngay, Gio, Them, Start, End, TenLP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int CheckXoaMucGia(string maMG)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.ThanhToan WHERE MaMucGia = '{0}'", maMG);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public bool XoaMucGia(string maMG)
        {
            string query = string.Format("DELETE dbo.MucGia WHERE MaMucGia = '{0}'", maMG);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<MucGia> TimMucGia(string tenMG, string LP, string MinGio, string MaxGio, string MinNgay, string MaxNgay, string Start, string End)
        {
            List<MucGia> list = new List<MucGia>();

            string query = string.Format("SELECT a.* FROM dbo.MucGia as a, dbo.LoaiPhong AS b WHERE a.MaLoaiPhong = b.MaLoaiPhong AND TenMucGia LIKE N'%{0}%' AND TenLoaiPhong LIKE N'%{1}%'", tenMG, LP);

            decimal a;
            if ( (MinGio != "" && Decimal.TryParse(MinGio, out a) == false) || (MaxGio != "" && Decimal.TryParse(MaxGio, out a) == false) || 
                 (MinNgay != "" && Decimal.TryParse(MinNgay, out a) == false) || (MaxNgay != "" && Decimal.TryParse(MaxNgay, out a) == false)     )   
            {
                query = string.Format(query + " AND 1 = -1");
            }
            else
            {
                if(MinGio != "")
                {
                    query = string.Format(query + " AND DonGiaGio >= {0}", MinGio);
                }
                if (MaxGio != "")
                {
                    query = string.Format(query + " AND DonGiaGio <= {0}", MaxGio);
                }
                if (MinNgay != "")
                {
                    query = string.Format(query + " AND DonGiaNgay >= {0}", MinNgay);
                }
                if (MaxNgay != "")
                {
                    query = string.Format(query + " AND DonGiaNgay <= {0}", MaxNgay);
                }
            }

            if (Start == "err" || End == "err")
            {
                query = query + " AND 1 = -1";
            }
            else
            {
                if (Start != "")
                {
                    query = string.Format(query + " AND NgayBatDau >= '{0} 00:00'", Start);
                }
                if (End != "")
                {
                    query = string.Format(query + " AND NgayKetThuc <= '{0} 23:59'", End);
                }
            }

            query = query + " ORDER BY CAST(MaMucGia AS INT)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MucGia mg = new MucGia(item);
                list.Add(mg);
            }

            return list;
        }

        public string GetMaMG()
        {
            string query = string.Format("SELECT dbo.TaoMaMucGia()");
            string MaMG = DataProvider.Instance.ExecuteScalar(query).ToString();

            return MaMG;
        }
    }
}
